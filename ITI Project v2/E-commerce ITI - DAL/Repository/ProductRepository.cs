using Data;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
	public class ProductRepository : IProductRepostiory
	{
		#region Ctor And Def
		ApplicationDbContext AbContext;
		public ProductRepository(ApplicationDbContext _AbContext)
		{
			AbContext = _AbContext;
		}
		#endregion

		#region Functions
		public List<Product> GetAll()
		{
			return AbContext.Products.ToList();
		}

		public Product GetById(int id)
		{
			return AbContext.Products.FirstOrDefault(P => P.Id == id);
		}

		public void Insert(Product product)
		{
			AbContext.Products.Add(product);
			AbContext.SaveChanges();
		}

		public void Update(int id, Product newproduct)
		{
			Product oldproduct = GetById(id);
			oldproduct.Name = newproduct.Name;
			oldproduct.Sku = newproduct.Sku;
			oldproduct.Price = newproduct.Price;
			oldproduct.Weight = newproduct.Weight;
			oldproduct.Stock = newproduct.Stock;
			oldproduct.Descripition = newproduct.Descripition;
			oldproduct.CategoryId = newproduct.CategoryId;
			oldproduct.Image = newproduct.Image;
			oldproduct.Thumbnail = newproduct.Thumbnail;
			oldproduct.CreateDate = newproduct.CreateDate;
			AbContext.SaveChanges();
		}
		public void Delete(int id)
		{
			AbContext.Products.Remove(GetById(id));
			AbContext.SaveChanges();
		}

        public Product GetByIdWithCategory(int id)
        {
            return AbContext.Products.Include(P=>P.Category).FirstOrDefault(P=>P.Id==id);
        }
        #endregion

    }
}
