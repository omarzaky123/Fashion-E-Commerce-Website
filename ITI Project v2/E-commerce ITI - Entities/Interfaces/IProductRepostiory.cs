using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public interface IProductRepostiory
	{
		List<Product> GetAll();
		Product GetById(int id);
		Product GetByIdWithCategory(int id);
		void Insert (Product product);
		void Update (int id,Product newproduct);
		void Delete(int id);	

	}
}
