using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars3A
{
    public partial class Peliculas : Form
    {
        public Peliculas()
        {
            InitializeComponent();
        }
        //public String asd = "2";

        private void pbST4_Click(object sender, EventArgs e)
        {
            int episodio = 1;
            DetallePelicula hope = new DetallePelicula(episodio);
            hope.Show();
            
        }

        private void pbST5_Click(object sender, EventArgs e)
        {
            int episodio = 2;
            DetallePelicula hope = new DetallePelicula(episodio);
            hope.Show();
        }

        private void pbST6_Click(object sender, EventArgs e)
        {
            int episodio = 3;
            DetallePelicula hope = new DetallePelicula(episodio);
            hope.Show();
        }

        private void pbST1_Click(object sender, EventArgs e)
        {
            int episodio = 4;
            DetallePelicula hope = new DetallePelicula(episodio);
            hope.Show();
        }

        private void pbST2_Click(object sender, EventArgs e)
        {
            int episodio = 5;
            DetallePelicula hope = new DetallePelicula(episodio);
            hope.Show();
        }

        private void pbST3_Click(object sender, EventArgs e)
        {
            int episodio = 6;
            DetallePelicula hope = new DetallePelicula(episodio);
            hope.Show();
        }

        private void pbST7_Click(object sender, EventArgs e)
        {
            int episodio = 7;
            DetallePelicula hope = new DetallePelicula(episodio);
            hope.Show();
        }
    }
}
