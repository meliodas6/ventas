using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.BL2;
using ventas.Modelos2;

namespace ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var clienteBL = new ClientesBL();
            listadeClienteBindingSource.DataSource = clienteBL.ListadeCliente;

            var ciudadBL = new CiudadBL();
            listadeClienteBindingSource.DataSource = ciudadBL.ListadeCiudad;
        }

    }
}
