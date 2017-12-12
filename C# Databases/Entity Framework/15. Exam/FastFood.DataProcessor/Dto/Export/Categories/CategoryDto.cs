
using System.Xml.Serialization;

namespace FastFood.DataProcessor.Dto.Export.Categories
{
    [XmlType("Category")]
    public class CategoryDto
    {
        public string Name { get; set; }

        public MostPopularItem MostPopularItem { get; set; }
    }
}