using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoshCourseApp.Data;
using MoshCourseApp.Models;
using System.Web.Http;
using System.Net;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;
using HttpDeleteAttribute = System.Web.Http.HttpDeleteAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;
using Microsoft.AspNetCore.Components;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace MoshCourseApp.Controllers.Api
{
    [Route("api/[controller]")]
   
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Сейчас проект запускается - если раскоментить любой метод ниже - падает

        //GET /api/customers
        //[HttpGet]
        //public IEnumerable<Customer> GetCustomers()
        //{
        //    return _context.Customers.ToList();
        //}


        //// GET/ api/customers/1
        //public Customer GetCustomer(int id)
        //{
        //    var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

        //    if (customer == null)
        //        throw new HttpResponseException(HttpStatusCode.NotFound);

        //    return customer;
        //}

        //// POST /api/customers
        //[HttpPost]
        //public Customer CreateCustomer(Customer customer)
        //{
        //    if (!ModelState.IsValid)
        //        throw new HttpResponseException(HttpStatusCode.BadRequest);

        //    _context.Customers.Add(customer);

        //    _context.SaveChanges();

        //    return customer;
        //}

        //    // PUT /api/customers/1
        //    [HttpPut]
        //    public void UpdateCustomer(int id, Customer customer)
        //    {
        //        if (!ModelState.IsValid)
        //            throw new HttpResponseException(HttpStatusCode.BadRequest);

        //        var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

        //        if (customerInDb == null)
        //            throw new HttpResponseException(HttpStatusCode.NotFound);

        //        customerInDb.Name = customer.Name;
        //        customerInDb.BirthDate = customer.BirthDate;
        //        customerInDb.IsSubrscribedToNewsLetter = customer.IsSubrscribedToNewsLetter;
        //        customerInDb.MembershipTypeId = customer.MembershipTypeId;

        //        _context.SaveChanges();
        //    }

        //    // DELETE /api/customers
        //    [HttpDelete]
        //    public void DeleteCustomer(int id)
        //    {
        //        var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

        //        if (customerInDb == null)
        //            throw new HttpResponseException(HttpStatusCode.NotFound);

        //        _context.Customers.Remove(customerInDb);

        //        _context.SaveChanges();
        //    }


    }
}