using System;
using System.IO;
using FastFood.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FastFood.Models;
using Newtonsoft.Json;
using FastFood.Models.Enums;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using FastFood.DataProcessor.Dto.Export;
using FastFood.DataProcessor.Dto.Export.Categories;

namespace FastFood.DataProcessor
{
	public class Serializer
	{
		public static string ExportOrdersByEmployee(FastFoodDbContext context, string employeeName, string orderType)
		{
            var type = (OrderType)Enum.Parse(typeof(OrderType), orderType);

            var orders = context.Orders
                    .Where(o => o.Employee.Name == employeeName && o.Type == type)
                    .Select(o => new OrderImportDto
                    {
                        Customer = o.Customer,
                        Items = o.OrderItems.Select(ooi => new ItemDto
                        {
                            Name = ooi.Item.Name,
                            Price = ooi.Item.Price,
                            Quantity = ooi.Quantity
                        })
                        .ToArray()
                    })
                    .ToArray();


            var employeeDto = new EmployeeDto
            {
                Name = employeeName,
                Orders = orders,
            };

            foreach (var order in employeeDto.Orders)
            {
                order.TotalPrice = order.Items.Sum(i => i.Price * i.Quantity);
                employeeDto.TotalMade += order.TotalPrice;
            }

            employeeDto.Orders = employeeDto.Orders
                    .OrderByDescending(o => o.TotalPrice)
                    .ThenByDescending(o => o.Items.Count())
                    .ToArray();

            var serializedEmployee = JsonConvert.SerializeObject(employeeDto, Newtonsoft.Json.Formatting.Indented);

            return serializedEmployee;

        }

		public static string ExportCategoryStatistics(FastFoodDbContext context, string categoriesString)
		{
            var categoryNames = categoriesString.Split(',');

            var categories = context.Categories
                .Where(c => categoryNames.Any(cn => cn == c.Name))
                .Select(c => new 
                {
                    Name = c.Name,
                    MostPopularItem = c.Items
                        .OrderByDescending(i => i.OrderItems.Sum(oi => oi.Item.Price * oi.Quantity))
                        .FirstOrDefault()
                })
                .Select(c => new Dto.Export.Categories.CategoryDto
                {
                    Name = c.Name,
                    MostPopularItem = new Dto.Export.Categories.MostPopularItem
                    {
                        Name = c.MostPopularItem.Name,
                        TotalMade = c.MostPopularItem.OrderItems.Sum(oi => oi.Item.Price * oi.Quantity),
                        TimesSold = c.MostPopularItem.OrderItems.Sum(oi => oi.Quantity)
                    }
                })
                .OrderByDescending(c => c.MostPopularItem.TotalMade)
                .ThenByDescending(c => c.MostPopularItem.TimesSold)
                .ToArray();

            var sb = new StringBuilder();

            var serializer = new XmlSerializer(typeof(CategoryDto[]), new XmlRootAttribute("Categories"));
            serializer.Serialize(new StringWriter(sb), categories, new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty }));

            var result = sb.ToString();
            return result;
        }
	}
}