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
    public partial class PokedexBasico : Form
    {
        Conexion miConexion = new Conexion();
        public int idActual = 1;
        public PokedexBasico()
        {
            InitializeComponent();
            asignaPokemon();
        }

        //boton derecha
        private void button2_Click(object sender, EventArgs e)
        {
            idActual++;
            if(idActual > 151)
            {
                idActual = 151;
            }
            asignaPokemon();
          
        }
        //boton Izquierda
        private void button1_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual < 1)
            {
                idActual = 151;
            }
            asignaPokemon();
        }
      
        private void asignaPokemon()
        {
            DataTable pokemonElegido = miConexion.getPokemonesPorId(idActual);
            nombrePokemon.Text = pokemonElegido.Rows[0]["nombre"].ToString();
            altura.Text = pokemonElegido.Rows[0]["altura"].ToString();
            peso.Text = pokemonElegido.Rows[0]["peso"].ToString();
            especie.Text = pokemonElegido.Rows[0]["especie"].ToString();
            habilidad.Text = pokemonElegido.Rows[0]["habilidad"].ToString();
            movimiento1.Text = pokemonElegido.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = pokemonElegido.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = pokemonElegido.Rows[0]["movimiento3"].ToString();
            tipo1.Text = pokemonElegido.Rows[0]["tipo1"].ToString();
            tipo2.Text = pokemonElegido.Rows[0]["tipo2"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])pokemonElegido.Rows[0]["imagen"]);
            
        }
        private Image convierteBlobAImagen(byte[] img)

        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        private void button3_Click(object sender, EventArgs e)
        {
            extraInfo ventana = new extraInfo();
            ventana.Show();
            ventana.asignaPokemon2(idActual);
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PokedexBasico_Load(object sender, EventArgs e)
        {

        }

        private void movimiento1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
