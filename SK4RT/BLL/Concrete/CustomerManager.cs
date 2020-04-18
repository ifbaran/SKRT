using BLL.Abstract;
using EFEntities.Concrete;
using System.Collections.Generic;
using DAL.Abstract;

namespace BLL.Concrete
{
    public class CustomerManager : ICustomerService

    {
        private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void BllAdd(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void BllDelete(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> BllGetAll()
        {
            return _customerDal.DalGetAll();
        }

        public Customer BllGetCustomer()
        {
            throw new System.NotImplementedException();
        }

        public void BllUpdate(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}