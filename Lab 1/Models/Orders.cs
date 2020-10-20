using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab_1.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CustomerEmail { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата заказа")]
        public DateTime DateOfBuying { get; set; }
    }
}