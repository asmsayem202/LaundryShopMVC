using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaundryShopMVC.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Required]
        public int PhoneNumber { get; set; }
        public List<Invoice> invoices { get; set; } = new List<Invoice>();
    }
}