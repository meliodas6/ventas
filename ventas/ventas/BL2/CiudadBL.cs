using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ventas.Modelos2;

namespace ventas.BL2
{
    public class CiudadBL
    {
        public List<Ciudad> ListadeCiudad { get; set; }

        public CiudadBL()
        {
            ListadeCiudad = new List<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegusigalpa");

            ListadeCiudad.Add(ciudad1);
            ListadeCiudad.Add(ciudad2);
        }
    }
}
