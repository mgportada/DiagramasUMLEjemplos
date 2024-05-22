using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDeNotificacion.Services
{
    public class EmailService
    {
        public void Send(Customer customer, string message)
        {
            Console.WriteLine($"Message sent to {customer.Name} by email");
        }
    }
}
