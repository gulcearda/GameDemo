using System;
namespace GameOdev
{
    public class CustomerManager : ICustomerService
    {
        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted from database:" + customer.Name);
        }

        public void Register(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
