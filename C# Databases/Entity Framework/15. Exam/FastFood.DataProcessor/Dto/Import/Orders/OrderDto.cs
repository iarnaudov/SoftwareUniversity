using FastFood.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace FastFood.DataProcessor.Dto.Import.Orders
{
    [XmlType("Order")]
    public class OrderDto
    {
        [Required]
        public string Customer { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Employee { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}\/\d{2}\/\d{4}\ \d{2}\:\d{2}$")]
        public string DateTime { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public List<ItemsDto> Items { get; set; }
        //Може да бъде и ItemsDto[], НО НИКОГА ICollection<ItemsDto>
    }
}
