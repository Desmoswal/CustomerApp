using CustomerAppDAL.Repositories;
using CustomerAppDAL.UOW;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAppDAL
{
    public class DALFacade
    {
        public ICustomerRepository CustomerRepository
        {
            //get { return new CustomerRepositoryFakeDB(); } 
            get
            {
                return new CustomerRepositoryEFMemory(new Context.InMemoryContext());
            }
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return new UnitOfWorkMem();
            }
        }
    }
}
