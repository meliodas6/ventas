using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Allan Castro";
            cliente1.Telefono = 97336533;
            cliente1.ciudad = "Choloma";

            Cliente cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Cynthia Pleites";
            cliente2.Telefono = 95670189;
            cliente2.ciudad = "Choloma";

            Cliente cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Cristian Castro";
            cliente3.Telefono = 98876543;
            cliente3.ciudad = "San Pedro Sula";

            var listadeCliente = new List<Cliente>();
            listadeCliente.Add(cliente1);
            listadeCliente.Add(cliente2);
            listadeCliente.Add(cliente3);

            foreach (var cliente in listadeCliente)
            {
                MessageBox.Show(cliente.Nombre + " " + cliente.ciudad);
               
            }
        }
    }
}
