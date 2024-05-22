using ServicioDeNotificacion.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDeNotificacion.Services
{
    public class CustomerService
    {
        private CustomerRepository _repository;

        public CustomerService(IDbConnection connection)
        {
            _repository = new CustomerRepository(connection);
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> costumers = _repository.GetCustomers();
            return costumers;
        }
    }
}
