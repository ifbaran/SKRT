using System.Collections.Generic;
using EFEntities.Concrete;

namespace BLL.Abstract
{
    public interface ICustomerService
    {
        List<Customer> BllGetAll();
        Customer BllGetCustomer();
        void BllAdd(Customer customer);
        void BllUpdate(Customer customer);
        void BllDelete(Customer customer);
    }
}