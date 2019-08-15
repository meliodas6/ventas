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
    public partial class Herencia : Form
    {
        public Herencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var heroe1 = new SuperPoder();
            heroe1.NombreHeroe = "Superman";

            var heroe2 = new SuperPoder();
            heroe2.NombreHeroe = "Spiderman";

            var heroe3 = new SuperPoder();
            heroe3.NombreHeroe = "Batman";

            var ListadeHeroes = new List<SuperPoder>();
            ListadeHeroes.Add(heroe1);

            ListadeHeroes.Add(heroe2);

            ListadeHeroes.Add(heroe3);

            foreach(var heroe in ListadeHeroes)
            {
                MessageBox.Show(heroe.NombreHeroe);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Villano1 = new SuperPoder();
            Villano1.NombreVillano = "Joker";

            var Villano2 = new SuperPoder();
            Villano2.NombreVillano = "Lex Lutor";

            var Villano3 = new SuperPoder();
            Villano3.NombreVillano = "Thanos";

            var ListadeVillanos = new List<SuperPoder>();
            ListadeVillanos.Add(Villano1);

            ListadeVillanos.Add(Villano2);

            ListadeVillanos.Add(Villano3);

            foreach (var villano in ListadeVillanos)
            {
                MessageBox.Show(villano.NombreVillano);
            }
        }
    }
}
