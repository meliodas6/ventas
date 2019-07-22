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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Celular Iphone";
            producto1.Precio = 10000;

            Producto producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "SAMSUNG";
            producto2.Precio = 8000;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);

            foreach (var producto in listadeProductos)
            {
                MessageBox.Show(producto.Descripcion);
            }
        }
    }
}
