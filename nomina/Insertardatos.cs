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
            conexion obconexion = new conexion();
            string sql = "insert into empleado(nombre_empleado, apellido_empleado, sexo_empleado, salario_empleado) values('"+this.TboxNombre.Text+"','"+this.TboxApellido.Text+"','"+this.CombSexo.Text+"','"+this.TboxSalario.Text+ "')"; 
            if (obconexion.insertar(sql)) { MessageBox.Show("Empleado Registrado"); }
            else { MessageBox.Show("Error al insertar"); }
           
        }
    }
}
