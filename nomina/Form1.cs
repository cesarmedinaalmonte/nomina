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
            CRUD obconexion = new CRUD();
            obconexion.conectar();
            DataTable dt = obconexion.consultar2("select * from empleado empleado;");
            this.Datagv1.DataSource = dt;
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
            CRUD obCRUD = new CRUD();

            if (Tboxbuscar.Text.Length == 0)
            {

                DataTable dt = obCRUD.consultar2(" SELECT  * FROM empleado ");
                Datagv1.DataSource = dt;
                return;
            }

            if (RadioId.Checked == true)
            {
                DataTable dt = obCRUD.consultar2(" SELECT  * FROM empleado WHERE idempleado='" + Tboxbuscar.Text.Trim() + "' ");
                Datagv1.DataSource = dt;
                return;
            }

            if (RadioNombre.Checked == true)
            {
                DataTable dt = obCRUD.consultar2(" SELECT  * FROM empleado WHERE nombre_empleado like '%" + Tboxbuscar.Text.Trim() + "%' ");
                Datagv1.DataSource = dt;
                return;
            }

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
            CRUD obconexion = new CRUD();
            obconexion.conectar();

            /*
            if (obconexion.eliminar("empleado", "idempleado='" "'")
            { MessageBox.Show("registro eliminado"); }
            else { MessageBox.Show("error"); }
        */
        }

        private void Tboxbuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

