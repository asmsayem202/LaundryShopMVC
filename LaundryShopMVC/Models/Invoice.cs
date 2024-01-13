using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaundryShopMVC.Models
{
    public class Invoice
    {
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public InvoiceType LaundryType { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
    }

    public enum InvoiceType
    {
        Press,
        Wash,
        DryWash
    }
}