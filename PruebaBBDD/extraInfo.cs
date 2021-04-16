using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PruebaBBDD
{
    public partial class extraInfo : Form
    {
        Conexion miConexion = new Conexion();
        int idActual = 1;
        public extraInfo()
        {
            InitializeComponent();
            
        }
        public void asignaPokemon2(int idActualExtra)
        {
            DataTable pokemonElegido = miConexion.getPokemonesPorId(idActualExtra);
            descripcion.Text = pokemonElegido.Rows[0]["descripcion"].ToString();
            pictureBox2.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            nombrePokemon2.Text = pokemonElegido.Rows[0]["nombre"].ToString();
            habitat.Text = pokemonElegido.Rows[0]["habitat"].ToString();
            especie.Text = pokemonElegido.Rows[0]["especie"].ToString();
            idActual = idActualExtra;


        }
        private Image convierteBlobAImagen(byte[] img)

        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        //boton izquierda
        private void button1_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual < 1)
            {
                idActual = 151;
            }
            asignaPokemon2(idActual);

        }

        //boton derecha
        private void button2_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual > 151)
            {
                idActual = 151;
            }
            asignaPokemon2(idActual);

        }
    }
}
