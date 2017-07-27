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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
         
           
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
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMantenimiento lanzar = new FrmMantenimiento();
            lanzar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD obconexion = new CRUD();
            obconexion.conectar();

        
        }

        private void Tboxbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMCargo_Click(object sender, EventArgs e)
        {
            Mantenimientocargo lanzar = new Mantenimientocargo();
            lanzar.Show();
        }
    }
    }

