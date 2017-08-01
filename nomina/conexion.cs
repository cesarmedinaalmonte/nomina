using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace nomina
{
    
    //Esta es la clase CRUD que contine los metodos para consultar, ingresar, actulizar los Datos de la base de Datos nomina
    public class CRUD
    {
        //Aqui tenemos dos varibles definida en la clase para usarlas en los metodos siguientes
        private string cadena = "Data Source=C:\\Sistema\\nomina.s3db;Version=3;";//Esta es la variable que contiene la direccion de la conexion a la base de datos
        public SQLiteConnection cn;//variable tipo sqliteconnection para ejecutar el mando para la conexion 

        //Este metodo lo utilizo para conectar a la base de Datos
        public void conectar()
        {
            cn = new SQLiteConnection(cadena);

        }
        //Este metodo se llama igual que la clase para cuando se llame la clase se ejecute la conexion a la base de dato
        public CRUD()
            {
            conectar();
            }
        // Este metodo se utiliza para hacer las consulta a la base de datos sin resultado, es decir para ingresar,actualizar,borrar datos.
        public bool consultarSinResultado(string sql)//este metodo es de tipo boolean es decir que devuelve un valor logico, es decir falso o verdadero
        {
            try //este es el control de errores 
            {
                cn.Open();
                SQLiteCommand comando = new SQLiteCommand(sql,cn);
                comando.ExecuteNonQuery();
                
            }
            catch (Exception )
            {
                return false;// esto son los retornos de falso si no se ejecuta  correctamente la sentencia SQL
                
            }
            finally
            {
                cn.Close();
            }
            return true;// Si todo se ejecuto correctamente el metodo retorna un valor verdadero.
        }
        // este metodo es para consultar la base de datos y desvolver un resultado, es decir para un SELECT
        public DataTable consultar2(string sql)
        {
                SQLiteDataAdapter da = new SQLiteDataAdapter();//se define una varible del tipo SQL data Adapter que va a contener los datos de la tabla consultado
                DataTable dt = new DataTable(); // Esta varible de tipo Datatable es para que los datos que tendra la variable data adapter se puedan adaptar en esta varible
            try
            {
                cn.Open();//abrir la conexion
                SQLiteCommand cmd;// variable de tipo SQLitecommand para contener la sentencia sql
                cmd = cn.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt); //se llena la variable DataTable con los la informacion de la variable data adapter 
            }
            catch (SQLiteException ex)
            {
            }
            finally
            {
                cn.Close();
            }
               
                return dt;// retorna la variable con los datos de la table organizados.
        }
        
    }


}

