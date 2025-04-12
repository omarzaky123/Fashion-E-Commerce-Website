using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> GetAll();

        public int Insert(Order order);

        public void update(int id, Order order);

        public void delete(int id);

        public Order GetById(int id);
    }
}
