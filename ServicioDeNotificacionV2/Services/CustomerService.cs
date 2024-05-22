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
        private IRepository _repository;

        public CustomerService(IRepository repository)
        {
            _repository = repository;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> costumers = _repository.GetCustomers();
            return costumers;
        }
    }
}
