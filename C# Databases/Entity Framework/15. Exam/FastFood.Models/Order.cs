﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FastFood.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastFood.Models
{
    public class Order
    {
          [Key]
          public int Id {get;set;}

          [Required]        
          public string Customer {get;set;}

          [Required]
          public DateTime DateTime {get;set;}

          [Required]
          public OrderType Type {get;set;}

          [Required]
          //[NotMapped]
          public decimal TotalPrice {get;set;}

          public int EmployeeId {get;set;}

          [Required]
          public Employee Employee {get;set;}

          public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}