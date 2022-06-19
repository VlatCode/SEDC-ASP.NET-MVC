using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrdersController : Controller
    {
        //localhost:[port]/ListOrders
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }

        //localhost:[port]/Orders/Details/{id?}
        public IActionResult Details(int? id)
        {
            Order order = OrderDb.Orders.FirstOrDefault(x => x.OrderId == id);
            if (order == null)
            {
                return EmptyResult();
            }

            return View(order);
        }

        //localhost/Orders/JsonData
        public IActionResult JsonData()
        {
            var order = new OrderDetails { OrderId = 1, Price = 10, CustomerName = "Vlatko" };
            return Json(order);
        }

        //localhost/Orders/Home
        public IActionResult Home()
        {
            return RedirectToAction("Index", "Home");
        }

        private IActionResult EmptyResult()
        {
            throw new NotImplementedException();
        }
    }
}
