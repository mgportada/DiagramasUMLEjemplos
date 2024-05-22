using ServicioDeNotificacion.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServicioDeNotificacion.Repositories
{
    public class CustomerRepository
    {
        public IDbConnection _connection;

        public CustomerRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<Customer> GetCustomers()
        {

            if (_connection.GetType() == typeof(MySQLConnection))
                Console.WriteLine("Get Customers from My SQL");
            else if (_connection.GetType() == typeof(OracleConnection))
                Console.WriteLine("Get Customers from Oracle");

            return new List<Customer>
            {
                new Customer() { Id = 1, Name = "Jose", Email = "jose@gmail.com", Phone = "111222333" },
                new Customer() { Id = 1, Name = "Marta", Email = "marta@gmail.com", Phone = "444555666" }
            };
        }
    }
}