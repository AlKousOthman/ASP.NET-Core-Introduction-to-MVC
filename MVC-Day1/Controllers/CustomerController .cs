using Microsoft.AspNetCore.Mvc;
using MVC_Day1.Models;

namespace MVC_Day1.Controllers
{
    public class CustomerController : Controller

      
  {
        List<Customer> customerList =
                [
                    new Customer() { Id = 1, Name = "Nawaf", Email = "nawaf@hotmail.com"},
                 new Customer() { Id = 2, Name = "Yousef", Email = "Yousef@hotmail.com"},
                  new Customer() { Id = 3, Name = "Othman", Email = "Othman@gmail.com"}

               ];

        public IActionResult Index()
        {
            return View(customerList);
        }

       public  IActionResult Details(int id)
        {
            var customer = customerList.Find(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
    }
}
