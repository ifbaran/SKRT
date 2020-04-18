using System;
using System.Collections.Generic;
using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BusinessLogicLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetCustomer()
        {
            throw new NotImplementedException();
        }
        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
