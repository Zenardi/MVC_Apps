﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;
using AutoMapper;
using Blockbuster.Dtos;
using Blockbuster.Models;

namespace Blockbuster.Controllers.api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        // GET /api/customers
        public IEnumerable<CustomerDto> GetCustomers()
        {
            var customerDtos = _context.Customers
                .Include(c=>c.MembershipType)
                .ToList()
                .Select(Mapper.Map<Customer, CustomerDto>);
            return customerDtos;
        }

        //Get /api/customers/1
        public /*CustomerDto*/ IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();  //throw new HttpResponseException(HttpStatusCode.NotFound);

            //return Mapper.Map<Customer,CustomerDto>(customer);
            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        //POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            //IHttpActionResult is a RESTful convention to return 201 code when create new customer
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        //PUT /api/customers/1
        [HttpPut]
        public void UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            
            Mapper.Map<CustomerDto, Customer>(customerDto, customerInDb);
            //or 
            //Mapper.Map(customerDto, customerInDb);
            _context.SaveChanges();
        }

        //DELETE /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
        }
    }
}
