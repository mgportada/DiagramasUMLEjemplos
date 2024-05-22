using ServicioDeNotificacion.Repositories;
using ServicioDeNotificacion.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDeNotificacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dependency
            ISender sender = new SMSService();
            IDbConnection connection = new MySQLConnection();
            IRepository repository = new CustomerRepository(connection);

            // Dependenct Injection
            var customerService = new CustomerService(repository);
            var communicationService = new CommunicationService(sender);

            // Program
            var customers = customerService.GetCustomers();
            var message = "Message to broadcast to all customers";

            foreach (var customer in customers)
            {
                communicationService.SendMessage(customer, message);
            }
        }
    }
}
