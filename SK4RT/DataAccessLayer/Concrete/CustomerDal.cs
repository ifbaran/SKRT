using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Abstract;
using Entities.Concrete;

namespace DataAccessLayer.Concrete
{
    public class CustomerDal : RepositoryBaseDal<Customer> , ICustomerDal
    {
        
    }
}
