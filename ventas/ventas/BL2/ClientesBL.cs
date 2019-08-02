using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos2;

namespace ventas.BL2
{
    public class ClientesBL
    {
        public List<Cliente> ListadeCliente { get; set; }

        public ClientesBL()
        {
            ListadeCliente = new List<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegusigalpa");

            var cliente1 = new Cliente(1, "Allan Castro", 97336533, ciudad1);
            var cliente2 = new Cliente(2, "Cynthia Pleites", 99565443, ciudad1);
            var cliente3 = new Cliente(2, "Rafael Ordoñez", 99678467, ciudad2);

            ListadeCliente.Add(cliente1);
            ListadeCliente.Add(cliente2);
            ListadeCliente.Add(cliente3);
        }
    }
}
