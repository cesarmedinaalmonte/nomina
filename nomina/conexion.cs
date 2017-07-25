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
    public class CRUD
    {
        private string cadena = "Data Source=C:\\Sistema\\nomina.s3db;Version=3;";
        public SQLiteConnection cn;
       
        
       
       

        public void conectar()
        {
            cn = new SQLiteConnection(cadena);

        }
        public CRUD()
            {
            conectar();
            }

        public bool consultarSinResultado(string sql)
        {
            try
            {
                cn.Open();
                SQLiteCommand comando = new SQLiteCommand(sql,cn);
                comando.ExecuteNonQuery();
                
            }
            catch (Exception )
            {
                return false;
                
            }
            finally
            {
                cn.Clone();
            }
            return true;
        }
        //para eliminar datos
        /*public bool eliminar(string tabla, string condicion)
        {
            cn.Open();
            string sql = "delete from " + tabla + " where " + condicion;
            comando = new SQLiteCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //actualizar
        public bool actualizar (string tabla, string campos, string condicion)
        {
            cn.Open();
            string sql = "update " + tabla + " set " + " where " + condicion;
            comando = new SQLiteCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Clone();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        public DataTable consultar2(string sql)
        {
                SQLiteDataAdapter da = new SQLiteDataAdapter();
                DataTable dt = new DataTable();
            try
            {
                cn.Open();
                SQLiteCommand cmd;
                cmd = cn.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (SQLiteException ex)
            {
            }
            finally
            {
                cn.Close();
            }
               
                return dt;
          
        }
        //Insertar Datos en nomina
        public bool insertar(string sql)
        {
            cn.Open();
            SQLiteCommand comando;
            comando = new SQLiteCommand(sql, cn);
            int i = comando.ExecuteNonQuery();
            cn.Close();
            if (i > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
        /* public void CargarDatos()
         {

             SQLiteDataAdapter adaptador = new SQLiteDataAdapter("select * from empleado", );
             DataTable Tabla = new DataTable("empleado");
             adaptador.Fill(Tabla);
             Datagv1.DataSource = Tabla;
         }
         */
    }


}

