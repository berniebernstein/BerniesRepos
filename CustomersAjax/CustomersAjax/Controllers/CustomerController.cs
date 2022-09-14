using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomersAjax.Models;

namespace CustomersAjax.Controllers
{
    public class CustomerController : Controller
    {
        Customer customer;
        List<Customer> customers;

        public CustomerController()
        {
            customers = new List<Customer>();
            customers.Add(new Customer(0, "Bernie", 67));
            customers.Add(new Customer(1, "Kimerly", 63));
            customers.Add(new Customer(2, "Zach", 38));
            customers.Add(new Customer(3, "Renee", 0));
            customers.Add(new Customer(4, "Grace", 31));
            customers.Add(new Customer(5, "Bert", 5));
        }

        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[0]);
            return View("Customer", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string customerNumber)
        {
            Tuple<List<Customer>, Customer> tuple;
            //tuple = new Tuple<List<Customer>, Customer>(customers, customers[Int32.Parse(customerNumber)]);
            return PartialView("_CustomerDetails", customers[Int32.Parse(customerNumber)]);
        }
    }
}