using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDeNotificacion.Services
{
    public class CommunicationService
    {
        public EmailService _emailService;
        public CommunicationService()
        {
            _emailService = new EmailService();
        }

        public void SendMessage(Customer customer, string message)
        {
            _emailService.Send(customer, message);
        }
    }
}
