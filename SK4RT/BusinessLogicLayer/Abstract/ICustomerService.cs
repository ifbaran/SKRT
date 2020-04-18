using System.Collections.Generic;
using Entities;
using Entities.Concrete;

namespace BusinessLogicLayer.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetCustomer();
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}