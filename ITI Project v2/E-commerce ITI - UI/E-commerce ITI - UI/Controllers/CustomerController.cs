using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace E_commerce_ITI___UI.Controllers
{
    public class CustomerController : Controller
    {

        ICustomerRepository CustomerRepository ;

        public CustomerController(ICustomerRepository CustomerRepository)
        {
            this.CustomerRepository = CustomerRepository;
        }
        
       public ActionResult Index()
        {
            return View(CustomerRepository.GetAll());
        }

        public ActionResult Details(int id)
        {
            return View(CustomerRepository.GetById(id));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            CustomerRepository.Insert(customer);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            return View(CustomerRepository.GetById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            CustomerRepository.update(id, customer);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            CustomerRepository.delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
