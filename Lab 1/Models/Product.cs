using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace Lab_1.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Type { get; set; }
        [Range(1, 200)]
        public float Cost { get; set; }

    }
}