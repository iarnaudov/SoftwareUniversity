using System;
using FastFood.Data;
using System.Text;
using Newtonsoft.Json;
using FastFood.Models;
using System.Collections.Generic;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Globalization;
using FastFood.Models.Enums;
using FastFood.DataProcessor.Dto.Import.Orders;
using FastFood.DataProcessor.Dto.Import;

namespace FastFood.DataProcessor
{
	public static class Deserializer
	{
		private const string FailureMessage = "Invalid data format.";
		private const string SuccessMessage = "Record {0} successfully imported.";

        public static string ImportEmployees(FastFoodDbContext context, string jsonString)
		{
            var deserializedEmployees = JsonConvert.DeserializeObject<EmployeeDto[]>(jsonString);

            var sb = new StringBuilder();

            var employees = new List<Employee>();

            var positions = new List<Position>();

            foreach (var employeeDto in deserializedEmployees)
            {
                if (!IsValid(employeeDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var existingPosition = positions.SingleOrDefault(p => p.Name == employeeDto.Position);
                if (existingPosition == null)
                {
                    existingPosition = new Position()
                    {
                        Name = employeeDto.Position
                    };
                    positions.Add(existingPosition);
                }

                var employee = new Employee()
                {
                    Name = employeeDto.Name,
                    Age = employeeDto.Age,
                    Position = existingPosition
                };

                employees.Add(employee);
                sb.AppendLine(string.Format(SuccessMessage, employeeDto.Name));
            }

            context.Employees.AddRange(employees);

            context.SaveChanges();

            var result = sb.ToString().TrimEnd();
            return result;
        }

		public static string ImportItems(FastFoodDbContext context, string jsonString)
		{
            var sb = new StringBuilder();

            var deserializedItems = JsonConvert.DeserializeObject<ItemDto[]>(jsonString);

            var validItems = new List<Item>();
            
            var categories = new List<Category>();

            foreach (var itemDto in deserializedItems)
            {
                if (!IsValid(itemDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var itemAlreadyExists = validItems.Any(s => s.Name == itemDto.Name);
                if (itemAlreadyExists)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var existingCategory = categories.SingleOrDefault(c => c.Name == itemDto.Category);
                if (existingCategory == null)
                {
                    existingCategory = new Category
                    {
                        Name = itemDto.Category
                    };
                    categories.Add(existingCategory);
                }

             // var item = Mapper.Map<Item>(itemDto);
                var item = new Item()
                {
                    Name = itemDto.Name,
                    Price = itemDto.Price,
                    Category = existingCategory
                };

                validItems.Add(item);

                sb.AppendLine(string.Format(SuccessMessage, itemDto.Name));
            }

            context.Items.AddRange(validItems);
            context.SaveChanges();

            var result = sb.ToString().TrimEnd();
            return result;

        }

        public static string ImportOrders(FastFoodDbContext context, string xmlString)
        {

            var serializer = new XmlSerializer(typeof(OrderDto[]), new XmlRootAttribute("Orders"));
            var deserializedOrders = (OrderDto[])serializer.Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(xmlString)));

            var employees = context.Employees.ToList();

            var items = context.Items.ToList();

            var sb = new StringBuilder();

            var orderedItems = new List<OrderItem>();

            var validOrders = new List<Order>();

            foreach (var orderDto in deserializedOrders)
            {
                if (!IsValid(orderDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var validateAllItems = orderDto.Items.All(IsValid);
                if (!validateAllItems)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var doItemsExist = orderDto.Items.All(oi => items.Any(i => i.Name == oi.Name));
                if (!doItemsExist)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var existingEmployee = employees.SingleOrDefault(e => e.Name == orderDto.Employee);
                if (existingEmployee == null)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var validDate = new DateTime();
                try
                {
                    validDate = DateTime.ParseExact(orderDto.DateTime, @"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                OrderType type;
                try
                {
                   type = (OrderType)Enum.Parse(typeof(OrderType), orderDto.Type);
                }
                catch (Exception)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var orderItems = new List<OrderItem>();

                foreach (var item in orderDto.Items)
                {
                    orderItems.Add(new OrderItem()
                    {
                        Item = context.Items.Single(it => it.Name == item.Name),
                        Quantity = item.Quantity
                    });
                }

                var order = new Order()
                {
                    Customer = orderDto.Customer,
                    Employee = existingEmployee,
                    DateTime = validDate,
                    Type = type,
                    OrderItems = orderItems
                };


                validOrders.Add(order);
                sb.AppendLine($"Order for {orderDto.Customer} on {orderDto.DateTime} added");
            }

            context.Orders.AddRange(validOrders);

            context.SaveChanges();

            var result = sb.ToString().TrimEnd();
            return result;

        }
            
        private static bool IsValid(object obj)
        {
            var validationContext = new ValidationContext(obj);
            var validationResults = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
            return isValid;
        }
    }
}