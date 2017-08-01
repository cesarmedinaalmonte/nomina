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
            TboxBuscar.Text = dgv.Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD obCRUD = new CRUD();

            if (obCRUD.consultarSinResultado("INSERT INTO cargo (nombre_cargo) VALUES('" + TboxBuscar.Text + "')"))
            { MessageBox.Show("Registro Existoso"); MostrarDatos(); }
            else { MessageBox.Show("Error al registgrar"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD obCRUD = new CRUD();
            if(obCRUD.consultarSinResultado("UPDATE cargo SET nombre_cargo='" + TboxBuscar.Text + "'WHERE idcargo='" + TboxID.Text + "'"))
            { MessageBox.Show("Registro Actualizado"); MostrarDatos(); }
            else { MessageBox.Show("Error al Actualizar"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CRUD obCRUD = new CRUD();
            try
            {
                if (TboxBuscar.Text.Length == 0 && TboxID.Text.Length == 0)
                {

                    DataTable datatable = obCRUD.consultar2(" SELECT  * FROM cargo ");
                    Datagv3.DataSource = datatable;
                    return;

                }

                if (TboxBuscar.Text.Length == 0 && TboxID.Text.Length != 0)
                {

                    DataTable dt1 = obCRUD.consultar2(" SELECT  * FROM cargo WHERE idcargo='" + TboxID.Text.Trim() + "' ");
                    Datagv3.DataSource = dt1;
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Error en la busqueda, paremetros incorrectos");
            }

            DataTable dt = obCRUD.consultar2(" SELECT  * FROM cargo WHERE nombre_cargo='" + TboxBuscar.Text.Trim() + "' ");
            Datagv3.DataSource = dt;
            return;
            
        }
    }
}
