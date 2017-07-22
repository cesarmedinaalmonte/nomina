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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            conexion obconexion = new conexion();
            obconexion.conectar();
            obconexion.consultar("select * from empleado;", "empleado");
            this.Datagv1.DataSource = obconexion.ds.Tables["empleado"];
            this.Datagv1.Refresh();
             
    }

       

        public void button1_Click(object sender, EventArgs e)
        {
           
           
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Insertardatos lanzar = new Insertardatos();
            lanzar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmActualizar lanzar = new FrmActualizar();
            lanzar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion obconexion = new conexion();
            obconexion.conectar();

            /*
            if (obconexion.eliminar("empleado", "idempleado='" "'")
            { MessageBox.Show("registro eliminado"); }
            else { MessageBox.Show("error"); }
        */
        }
    }
    }

