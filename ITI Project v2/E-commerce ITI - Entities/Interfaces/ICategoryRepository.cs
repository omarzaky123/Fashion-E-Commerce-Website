using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	public interface ICategoryRepository
	{
		List<Category> GetAll();
		List<Product> GetRelativeProducts(int id);

        Category GetById(int id);
		void Insert(Category category);
		void Update(int id, Category newcategory);
		void Delete(int id);


	}
}
