using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace Lab_1.Models
{
    public class Customer
    {
        [Key]
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength =3, ErrorMessage ="Нужно ввести имя")]
        public string Name { get; set; }
        [Required]
        [StringLength(11, MinimumLength =11)]
        [Range(89000000000, 89999999999, ErrorMessage ="Некорректный номер сотового телефона")]
        public string Phone { get; set; }
    }
}