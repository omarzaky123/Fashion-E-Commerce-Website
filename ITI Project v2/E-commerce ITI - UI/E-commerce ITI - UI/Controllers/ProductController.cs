using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace E_commerce_ITI___UI.Controllers
{
    public class ProductController : Controller
    {

		#region Ctor And Def
		IProductRepostiory IProductRepostiory;
		ICategoryRepository ICategoryRepository;
		public ProductController(IProductRepostiory _IProductRepostiory,
		ICategoryRepository _ICategoryRepository)
		{
			IProductRepostiory = _IProductRepostiory;
			ICategoryRepository = _ICategoryRepository;
		}

		#endregion

		#region Display
		public IActionResult Index()
        {
            return View(IProductRepostiory.GetAll());
        }
		public IActionResult IndexAdmin()
		{
			return View(IProductRepostiory.GetAll());
		}

		public IActionResult Details(int id)
		{
			return View(IProductRepostiory.GetByIdWithCategory(id));
		}
        #endregion

        #region Insert
        public IActionResult InsertForm()
        {
            ViewBag.Categories=ICategoryRepository.GetAll();
            return View (); 
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult SaveInsert(Product product) 
        {
            if (ModelState.IsValid == true)
            {
				ViewBag.Categories = ICategoryRepository.GetAll();
				IProductRepostiory.Insert(product);
                return RedirectToAction("IndexAdmin");
            }
            else
            {
				ViewBag.Categories = ICategoryRepository.GetAll();
				return View("InsertForm",product);  
            }
        }

        #endregion

        #region Update

        public IActionResult UpdateForm(int id)
        {
			ViewBag.Categories = ICategoryRepository.GetAll();
			Product product = IProductRepostiory.GetById (id);
            return View(product);
        }

		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public IActionResult SaveUpdate(int id, Product newproduct) 
        {
            if (ModelState.IsValid == true)
            {
				ViewBag.Categories = ICategoryRepository.GetAll();
				IProductRepostiory.Update(id, newproduct);
                return RedirectToAction("IndexAdmin");
            }
            else 
            {
				ViewBag.Categories = ICategoryRepository.GetAll();
				Product oldproduct = IProductRepostiory.GetById(id);
				return View("UpdateForm", oldproduct);
            }
        }


        #endregion

        #region Delete
        public IActionResult Delete(int id) 
        { 
            IProductRepostiory.Delete(id);
            return RedirectToAction("IndexAdmin");
        }


        #endregion

    }
}
