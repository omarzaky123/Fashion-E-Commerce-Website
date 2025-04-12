using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Interfaces;
using Models;

namespace Repository
{
	public class CategoryRepository : ICategoryRepository
	{

		#region Ctor And Def
		ApplicationDbContext AbContext;
		public CategoryRepository(ApplicationDbContext _AbContext)
		{
			AbContext = _AbContext;
		}


		#endregion

		#region Functions
		public List<Category> GetAll()
		{
			return AbContext.Categories.ToList();
		}
        public List<Product> GetRelativeProducts(int id)
        {
            return AbContext.Products.Where(P=>P.CategoryId==id).ToList();
        }

        public Category GetById(int id)
		{
			return AbContext.Categories.FirstOrDefault(C => C.Id == id);
		}

		public void Insert(Category category)
		{
			AbContext.Categories.Add(category);
			AbContext.SaveChanges();
		}

		public void Update(int id, Category newcategory)
		{
			Category oldcategory = GetById(id);
			oldcategory.Name= newcategory.Name;
			oldcategory.Description= newcategory.Description;
			oldcategory.Thumbnail= newcategory.Thumbnail;
			AbContext.SaveChanges();
		}
		public void Delete(int id)
		{
			AbContext.Categories.Remove(GetById(id));
			AbContext.SaveChanges();
		}

        #endregion
    }
}
