using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nomina
{
    public partial class Insertardatos : Form
    {
        public Insertardatos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Insertardatos_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CRUD obconexion = new CRUD();
            if (obconexion.consultarSinResultado("insert into empleado(nombre_empleado, apellido_empleado, sexo_empleado, salario_empleado) values('" + this.TboxNombre.Text + "','" + this.TboxApellido.Text + "','" + this.CombSexo.Text + "','" + this.Tboxsalario.Text + "')"))
            {
                MessageBox.Show("Registro Exitoso");

            }
            else { MessageBox.Show("Error al Registrar"); }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD obCRUD = new CRUD();
            DataTable dt_empleado = obCRUD.consultar2(" SELECT  * FROM empleado where id='" + Tboxid.Text + "' ");
            foreach (DataRow dr in dt_empleado.Rows)
            {
                string ID, nombre, apellidos;
                ID = dr["idempleado_empleado"].ToString();
                nombre = dr["nombre_empleado"].ToString();
                apellidos = dr["apellidos_empleado"].ToString();
                TboxNombre.Text = nombre;
                TboxApellido.Text = apellidos;
                Tboxid.Text = ID;
                try
                {

                    //pictureBox1.Image = Image.FromFile(@"C:\sistema\imagenes\" + txtID.Text + ".jpg");

                }
                catch (Exception)
                {

                }

            }
        }
    }
}

