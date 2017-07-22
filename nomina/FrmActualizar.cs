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
            conexion obconexion = new conexion();
            this.listBox1.DataSource = obconexion.consultar2("empleado");
            this.listBox1.DisplayMember = "idempleado";
            this.listBox1.ValueMember = "idempleado";
            this.listBox1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion obconexion = new conexion();
            obconexion.conectar();

            if(obconexion.eliminar("empleado", "idempleado='"+listBox1.SelectedValue.ToString()+"'"))
            { MessageBox.Show("registro eliminado");}
            else { MessageBox.Show("error"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string campo = "nombre_empleado = '"++"'"
        }
    }
}
