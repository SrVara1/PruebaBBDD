using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;//libreria de mysql
using System.Data; //libreria del datatable


namespace PruebaBBDD
{
    class Conexion
    {
        public MySqlConnection conexion; //variable de la conexion 

        public Conexion() //el constructor
        {
            conexion = new MySqlConnection("Server=127.0.0.1; Database=listapokemons; Uid=root; Pwd=; Port=3306");
        }

        public DataTable getPokemones()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("Select * from pokemon", conexion);
                MySqlDataReader resultado =consulta.ExecuteReader(); //guardo el resultado
                DataTable pokemones = new DataTable(); //formato que espera el datagridview
                pokemones.Load(resultado); // convierte mysqldatareader en datatable
                conexion.Close();
                return pokemones;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }
        public DataTable getPokemonesPorId(int _id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("Select * from pokemon WHERE id='" + _id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader(); //guardo el resultado
                DataTable pokemones = new DataTable(); //formato que espera el datagridview
                pokemones.Load(resultado); // convierte mysqldatareader en datatable
                conexion.Close();
                return pokemones;
            }
            catch (MySqlException e)
            {
                throw e;
            }

        }
     
    }
}
    

