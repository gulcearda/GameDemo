using System;
namespace GameOdev
{
    public interface ICustomerService
    {
        void Register(Customer customer);

        void Update(Customer customer);

        void Delete(Customer customer);
    }
}
