using BlazorServerSide.Context;
using BlazorServerSide.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorServerSide.Application
{
    public class CustomerService
    {
        private readonly ApiContext _context;

        public CustomerService(ApiContext context)
        {
            _context = context;
        }

        public void Save(Customer customer)
        {
            customer.Id = Guid.NewGuid();
            _context.Add(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            var customerDb = GetById(customer.Id);

            if (customerDb != null)
            {
                customerDb.Nome = customer.Nome;
                customerDb.Sobrenome = customer.Sobrenome;
                customerDb.Idade = customer.Idade;
                _context.SaveChanges();
            }
        }

        public object Delete(Guid id)
        {
            return new object();
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(Guid id)
        {
            return _context.Customers.FirstOrDefault(p => p.Id == id);
        }
    }
}
