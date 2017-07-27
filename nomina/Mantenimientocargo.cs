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
    public partial class Mantenimientocargo : Form
    {
        public Mantenimientocargo()
        {
            InitializeComponent();
        }

        private void Mantenimientocargo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        public void MostrarDatos()
        {
            CRUD obconexion = new CRUD();
            obconexion.conectar();
            DataTable dt = obconexion.consultar2("select * from cargo;");
            this.Datagv3.DataSource = dt;
            this.Datagv3.Refresh();

        }

        private void Datagv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = Datagv3.Rows[e.RowIndex];
            TboxID.Text = dgv.Cells[0].Value.ToString();
            TboxNombre.Text = dgv.Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD obCRUD = new CRUD();

            if (obCRUD.consultarSinResultado("INSERT INTO cargo (nombre_cargo) VALUES('" + TboxNombre.Text + "')"))
            { MessageBox.Show("Registro Existoso"); MostrarDatos(); }
            else { MessageBox.Show("Error al registgrar"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD obCRUD = new CRUD();
            if(obCRUD.consultarSinResultado("UPDATE cargo SET nombre_cargo='" + TboxNombre.Text + "'WHERE idcargo='" + TboxID.Text + "'"))
            { MessageBox.Show("Registro Actualizado"); MostrarDatos(); }
            else { MessageBox.Show("Error al Actualizar"); }
        }
    }
}
