using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetAll();

        public int Insert(Customer customer);

        public void update(int id, Customer customer);

        public void delete(int id);

        public Customer GetById(int id);
    }
}
