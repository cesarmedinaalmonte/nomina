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
    public class conexion
    {
        private string cadena = "Data Source=C:\\Sistema\\nomina.s3db;Version=3;";
        public SQLiteConnection cn;
        private SQLiteCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SQLiteDataAdapter da;
        public SQLiteCommand comando;

        public void conectar()
        {
            cn = new SQLiteConnection(cadena);

        }
        public conexion()
            {
            conectar();
            }

        public void consultar(string sql, string tabla)
        {
            ds.Tables.Clear();
            da = new SQLiteDataAdapter(sql,cn);
            cmb = new SQLiteCommandBuilder(da);
            da.Fill(ds, tabla);
        }
        //para eliminar datos
        public bool eliminar(string tabla, string condicion)
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
            string sql = "update" + tabla + "set" + "where" + condicion;
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
        }
        public DataTable consultar2(string tabla)
        {
            string sql = "select * from " + tabla;
            da = new SQLiteDataAdapter(sql, cn); 
            DataSet dts = new DataSet();
            da.Fill(dts, tabla);
            DataTable dt = new DataTable();
            dt = dts.Tables[tabla];
            return dt;
      

          
        }
        //Insertar Datos en nomina
        public bool insertar(string sql)
        {
            cn.Open();
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

