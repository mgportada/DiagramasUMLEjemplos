using ServicioDeNotificacion.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServicioDeNotificacion.Repositories
{
    public class CustomerRepository
    {
        public MySQLConnection _connection;

        public CustomerRepository()
        {
            _connection = new MySQLConnection();
        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer() { Id = 1, Name = "Jose", Email = "jose@gmail.com", Phone = "111222333" },
                new Customer() { Id = 1, Name = "Marta", Email = "marta@gmail.com", Phone = "444555666" }
            };
        }
    }
}