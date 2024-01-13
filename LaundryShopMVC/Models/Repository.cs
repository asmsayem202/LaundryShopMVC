using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaundryShopMVC.Models
{
    public class Repository
    {
        static List<Customer> Data = new List<Customer>();
        public Repository()
        {

            if (Data.Count == 0)
            {

                Customer customer1 = new Customer();
                customer1.Id = 0;
                customer1.Name = "Sayem";
                customer1.Address = "Ctg";
                customer1.PhoneNumber = 1274108;
                customer1.invoices.Add(new Invoice()
                {
                    OrderDate = Convert.ToDateTime("11-2-23"),
                    LaundryType = InvoiceType.DryWash,
                    ItemName = "Shirt",
                    Price = 20,
                    Qty = 3,
                });
                Data.Add(customer1);

                Customer customer2 = new Customer();
                customer2.Id = 1;
                customer2.Name = "Tamzid";
                customer2.Address = "Shawndip";
                customer2.PhoneNumber = 1274209;
                customer2.invoices.Add(new Invoice()
                {
                    OrderDate = Convert.ToDateTime("10-2-23"),
                    LaundryType = InvoiceType.Wash,
                    ItemName = "Pant",
                    Price = 25,
                    Qty = 5,
                });
                Data.Add(customer2);

            }
        }

        public List<Customer> GetList()
        {

            return Data;
        }

        internal Customer Get(int id)
        {
            return Data.Find(m => m.Id == id);
        }

        internal void Save(Customer customer)
        {
            Data.Add(customer);
        }

        internal void Delete(Customer customer)
        {
            var idx = Data.FindIndex(_ => _.Id == customer.Id);

            if (idx == -1) return;
            Data.RemoveAt(idx);
        }

        internal void Update(Customer customer)
        {
            var idx = Data.FindIndex(_ => _.Id == customer.Id);

            if (idx == -1) return;

            Data[idx] = customer;
        }
    }
}
