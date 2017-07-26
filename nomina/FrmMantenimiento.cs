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
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void TboxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmActualizar_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            CRUD obCRUD = new CRUD();
            CombCargo.DataSource = obCRUD.consultar2("SELECT * FROM cargo");
            this.CombCargo.DisplayMember = "nombre_cargo";
            this.CombCargo.ValueMember = "idcargo";


            /*CRUD obconexion = new CRUD();
            this.listBox1.DataSource = obconexion.consultar2("select * from empleado");
            this.listBox1.DisplayMember = "nombre_empleado";
            this.listBox1.ValueMember = "idempleado";
            this.listBox1.Refresh();
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CRUD obconexion = new CRUD();
            obconexion.conectar();
            if (obconexion.consultarSinResultado("DELETE FROM empleado where idempleado='" + this.TboxID.Text +"'"))
            {
                MessageBox.Show("Registro Eliminado");
                MostrarDatos();
            }
            else { MessageBox.Show("Error al Eliminar"); }

           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CRUD  obconexion = new CRUD();
            obconexion.conectar();
            if (obconexion.consultarSinResultado("UPDATE empleado SET nombre_empleado = '" + this.TboxNombre.Text + "',apellido_empleado ='" + this.TboxApellido.Text + "'," +
             "sexo_empleado ='" + this.CombSexo.Text + "',cedula_empleado ='"+this.TboxCedula.Text+ "',fk_idcargo ='" + this.CombCargo.SelectedValue.ToString() + "', salario_empleado = '" + this.TboxSalario.Text + "' WHERE idempleado='" +this.TboxID.Text+ "'"))
            {
                MessageBox.Show("Registro Actualizado");
                MostrarDatos();
            }
            else { MessageBox.Show("Error al Actualizar"); }
           

             
         
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgv = Datagv2.Rows[e.RowIndex];
            TboxID.Text = dgv.Cells[0].Value.ToString();
            TboxNombre.Text = dgv.Cells[1].Value.ToString();
            TboxApellido.Text = dgv.Cells[2].Value.ToString();
            TboxCedula.Text = dgv.Cells[3].Value.ToString();
            CombSexo.Text = dgv.Cells[4].Value.ToString();
            TboxSalario.Text = dgv.Cells[5].Value.ToString();
            CombCargo.SelectedValue = dgv.Cells[6].Value.ToString();
        }
        public void MostrarDatos()
        {
            CRUD obconexion = new CRUD();
            obconexion.conectar();
            DataTable dt = obconexion.consultar2("select * from empleado empleado;");
            this.Datagv2.DataSource = dt;
            this.Datagv2.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CRUD obconexion = new CRUD();
            if (obconexion.consultarSinResultado("insert into empleado(nombre_empleado, apellido_empleado, cedula_empleado, sexo_empleado,  salario_empleado, fk_idcargo) values('" + this.TboxNombre.Text + "','" + this.TboxApellido.Text + "','" + this.TboxCedula.Text + "','" + this.CombSexo.Text + "','" + this.TboxSalario.Text + "','" + this.CombCargo.SelectedValue.ToString() + "')"))
            {
                MessageBox.Show("Registro Exitoso");
                MostrarDatos();

            }
            else { MessageBox.Show("Error al Registrar"); }
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            CRUD obCRUD = new CRUD();

            if (Tboxbuscar.Text.Length == 0)
            {

                DataTable dt = obCRUD.consultar2(" SELECT  * FROM empleado ");
                Datagv2.DataSource = dt;
                return;
            }

            if (RadioId.Checked == true)
            {
                DataTable dt = obCRUD.consultar2(" SELECT  * FROM empleado WHERE idempleado='" + Tboxbuscar.Text.Trim() + "' ");
                Datagv2.DataSource = dt;
                return;
            }

            if (RadioNombre.Checked == true)
            {
                DataTable dt = obCRUD.consultar2(" SELECT  * FROM empleado WHERE nombre_empleado like '%" + Tboxbuscar.Text.Trim() + "%' ");
                Datagv2.DataSource = dt;
                return;
            }
            if (RadioApellido.Checked == true)
            {
                DataTable dt = obCRUD.consultar2(" SELECT  * FROM empleado WHERE apellido_empleado like '%" + Tboxbuscar.Text.Trim() + "%' ");
                Datagv2.DataSource = dt;
                return;
            }
        }

        private void CombCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
