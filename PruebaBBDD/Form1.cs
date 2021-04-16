using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBBDD
{
    public partial class Form1 : Form
    {
        Conexion miConexion = new Conexion(); //esta variable es del tipo que hemos creado para conectarnos la BBDD MySql

        DataTable misPokemones = new DataTable(); //variable que almacenan el array de dos dimensiones resultado de la consulta

        public Form1()
        {
            InitializeComponent();
            misPokemones = miConexion.getPokemones();
            dataGridView1.DataSource = misPokemones;        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
