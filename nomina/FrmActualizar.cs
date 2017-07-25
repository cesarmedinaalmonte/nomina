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
    public partial class FrmActualizar : Form
    {
        public FrmActualizar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TboxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmActualizar_Load(object sender, EventArgs e)
        {
            CRUD obconexion = new CRUD();
            this.listBox1.DataSource = obconexion.consultar2("select * from empleado");
            this.listBox1.DisplayMember = "nombre_empleado";
            this.listBox1.ValueMember = "idempleado";
            this.listBox1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CRUD obconexion = new CRUD();
            obconexion.conectar();
            if (obconexion.consultarSinResultado("DELETE FROM empleado where idempleado='" + listBox1.SelectedValue.ToString() + "'"))
            {
                MessageBox.Show("Registro Eliminado");
            }
            else { MessageBox.Show("Error al Eliminar"); }

            listBox1.Refresh();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD  obconexion = new CRUD();
            obconexion.conectar();
            if (obconexion.consultarSinResultado("UPDATE empleado SET nombre_empleado = '" + this.TboxNombre.Text + "',apellido_empleado ='" + this.TboxApellido.Text + "'," +
             "sexo_empleado ='" + this.CombSexo.Text + "', salario_empleado = '" + this.TboxSalario.Text + "' WHERE idempleado='" + listBox1.SelectedValue.ToString() + "'"))
            {
                MessageBox.Show("Registro Actualizado");
            }
            else { MessageBox.Show("Error al Actualizar"); }
           

             
         
        }

    }
}
