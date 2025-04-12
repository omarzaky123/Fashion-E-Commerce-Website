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
    public class OrderRepository : IOrderRepository
    {
        ApplicationDbContext context;
        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public int Insert(Order order)
        {
            context.Add(order);
            return context.SaveChanges();
        }

        public void update(int id, Order order)
        {
            context.Update(order);
            context.SaveChanges();
        }

        public void delete(int id)
        {
            context.Orders.Remove(GetById(id));
            context.SaveChanges();
        }

        public Order GetById(int id)
        {
            Order order = context.Orders.Find(id);
            return order;
        }
    }
}
