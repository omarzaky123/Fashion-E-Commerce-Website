using Data;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        ApplicationDbContext context;
        public CustomerRepository(ApplicationDbContext context)
        {
            this.context = context;
        }


        public IEnumerable<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public int Insert(Customer customer)
        {
            context.Add(customer);
            return context.SaveChanges();
        }

        public void update(int id, Customer customer)
        {
            context.Update(customer);
            context.SaveChanges();
        }

        public void delete(int id)
        {
            context.Customers.Remove(GetById(id));
            context.SaveChanges();
        }

        public Customer GetById(int id)
        {
            Customer customer = context.Customers.Find(id);
            return customer;
        }
    }
}
