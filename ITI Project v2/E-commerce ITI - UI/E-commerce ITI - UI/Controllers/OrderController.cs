using Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce_ITI___UI.Controllers
{
    public class OrderController : Controller
    {
        IOrderRepository OrderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            this.OrderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            return View(OrderRepository.GetAll());
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
