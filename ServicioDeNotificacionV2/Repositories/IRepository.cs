using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDeNotificacion.Repositories
{
    public interface IRepository
    {
        System.Collections.Generic.List<Customer> GetCustomers();
    }
}
