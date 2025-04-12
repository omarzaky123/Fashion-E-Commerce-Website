using E_commerce_ITI___UI.ViewModels;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace E_commerce_ITI___UI.Controllers
{
	public class CategoryController : Controller
	{
		#region Ctor And Def
		IProductRepostiory IProductRepostiory;
		ICategoryRepository ICategoryRepository;
		public CategoryController(IProductRepostiory _IProductRepostiory,
		ICategoryRepository _ICategoryRepository)
		{
			IProductRepostiory = _IProductRepostiory;
			ICategoryRepository = _ICategoryRepository;
		}

		#endregion

		#region Display
		public IActionResult IndexAdmin()
		{
			return View(ICategoryRepository.GetAll());
		}
		public IActionResult Details(int id)
		{
            CategoryDetails categoryDetails = new CategoryDetails();

			categoryDetails.CategoryName = ICategoryRepository.GetById(id).Name;
			categoryDetails.CategoryDescripition=ICategoryRepository.GetById(id).Description;
			categoryDetails.CategoryThumbnail = ICategoryRepository.GetById(id).Thumbnail;

			categoryDetails.Products = ICategoryRepository.GetRelativeProducts(id);
            return View(categoryDetails);
		}
		#endregion

		#region Insert

		public IActionResult InsertForm()
		{
			return View();
		}

		public IActionResult SaveInsert(Category category)
		{
			if (ModelState.IsValid == true)
			{
				ICategoryRepository.Insert(category);
				return RedirectToAction("IndexAdmin");	
			}
			else
			{
				return View("InsertForm",category);
			}
		}

		#endregion

		#region Update

		public IActionResult UpdateForm(int id) 
		{
			Category category =ICategoryRepository.GetById(id);
			return View(category);
		}

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult SaveUpdate(int id,Category newcategory) 
		{
			if (ModelState.IsValid)
			{
				ICategoryRepository.Update(id, newcategory);
				return RedirectToAction("IndexAdmin");
			}
			else 
			{
				Category oldcategory = ICategoryRepository.GetById(id);
				return View("UpdateForm",oldcategory);	
			}
		}
		#endregion

		#region Delete

		public IActionResult Delete(int id) 
		{
			ICategoryRepository.Delete(id);
			return RedirectToAction("IndexAdmin");
		}

		#endregion
	}
}

