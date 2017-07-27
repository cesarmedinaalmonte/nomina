namespace nomina
{
    partial class FrmMantenimiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CombSexo = new System.Windows.Forms.ComboBox();
            this.TboxSalario = new System.Windows.Forms.TextBox();
            this.TboxApellido = new System.Windows.Forms.TextBox();
            this.TboxNombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Datagv2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TboxCedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TboxID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TboxFechaNacimiento = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.RadioId = new System.Windows.Forms.RadioButton();
            this.RadioApellido = new System.Windows.Forms.RadioButton();
            this.RadioNombre = new System.Windows.Forms.RadioButton();
            this.Bt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Tboxbuscar = new System.Windows.Forms.TextBox();
            this.CombCargo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datagv2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salario";
            // 
            // CombSexo
            // 
            this.CombSexo.FormattingEnabled = true;
            this.CombSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CombSexo.Location = new System.Drawing.Point(62, 127);
            this.CombSexo.Name = "CombSexo";
            this.CombSexo.Size = new System.Drawing.Size(36, 21);
            this.CombSexo.TabIndex = 8;
            // 
            // TboxSalario
            // 
            this.TboxSalario.Location = new System.Drawing.Point(62, 241);
            this.TboxSalario.Name = "TboxSalario";
            this.TboxSalario.Size = new System.Drawing.Size(140, 20);
            this.TboxSalario.TabIndex = 11;
            // 
            // TboxApellido
            // 
            this.TboxApellido.Location = new System.Drawing.Point(62, 92);
            this.TboxApellido.Name = "TboxApellido";
            this.TboxApellido.Size = new System.Drawing.Size(295, 20);
            this.TboxApellido.TabIndex = 10;
            // 
            // TboxNombre
            // 
            this.TboxNombre.Location = new System.Drawing.Point(62, 52);
            this.TboxNombre.Name = "TboxNombre";
            this.TboxNombre.Size = new System.Drawing.Size(295, 20);
            this.TboxNombre.TabIndex = 9;
            this.TboxNombre.TextChanged += new System.EventHandler(this.TboxNombre_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Datagv2
            // 
            this.Datagv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagv2.Location = new System.Drawing.Point(374, 61);
            this.Datagv2.MultiSelect = false;
            this.Datagv2.Name = "Datagv2";
            this.Datagv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagv2.Size = new System.Drawing.Size(718, 318);
            this.Datagv2.TabIndex = 14;
            this.Datagv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cedula";
            // 
            // TboxCedula
            // 
            this.TboxCedula.Location = new System.Drawing.Point(62, 203);
            this.TboxCedula.Name = "TboxCedula";
            this.TboxCedula.Size = new System.Drawing.Size(140, 20);
            this.TboxCedula.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            // 
            // TboxID
            // 
            this.TboxID.Enabled = false;
            this.TboxID.Location = new System.Drawing.Point(62, 22);
            this.TboxID.Name = "TboxID";
            this.TboxID.Size = new System.Drawing.Size(36, 20);
            this.TboxID.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // TboxFechaNacimiento
            // 
            this.TboxFechaNacimiento.Location = new System.Drawing.Point(126, 165);
            this.TboxFechaNacimiento.Name = "TboxFechaNacimiento";
            this.TboxFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.TboxFechaNacimiento.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 29);
            this.button3.TabIndex = 21;
            this.button3.Text = "Ingresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RadioId
            // 
            this.RadioId.AutoSize = true;
            this.RadioId.Location = new System.Drawing.Point(474, 12);
            this.RadioId.Name = "RadioId";
            this.RadioId.Size = new System.Drawing.Size(36, 17);
            this.RadioId.TabIndex = 27;
            this.RadioId.TabStop = true;
            this.RadioId.Text = "ID";
            this.RadioId.UseVisualStyleBackColor = true;
            // 
            // RadioApellido
            // 
            this.RadioApellido.AutoSize = true;
            this.RadioApellido.Location = new System.Drawing.Point(584, 12);
            this.RadioApellido.Name = "RadioApellido";
            this.RadioApellido.Size = new System.Drawing.Size(62, 17);
            this.RadioApellido.TabIndex = 26;
            this.RadioApellido.TabStop = true;
            this.RadioApellido.Text = "Apellido";
            this.RadioApellido.UseVisualStyleBackColor = true;
            // 
            // RadioNombre
            // 
            this.RadioNombre.AutoSize = true;
            this.RadioNombre.Location = new System.Drawing.Point(516, 12);
            this.RadioNombre.Name = "RadioNombre";
            this.RadioNombre.Size = new System.Drawing.Size(62, 17);
            this.RadioNombre.TabIndex = 25;
            this.RadioNombre.TabStop = true;
            this.RadioNombre.Text = "Nombre";
            this.RadioNombre.UseVisualStyleBackColor = true;
            // 
            // Bt
            // 
            this.Bt.Location = new System.Drawing.Point(778, 35);
            this.Bt.Name = "Bt";
            this.Bt.Size = new System.Drawing.Size(84, 20);
            this.Bt.TabIndex = 24;
            this.Bt.Text = "Buscar";
            this.Bt.UseVisualStyleBackColor = true;
            this.Bt.Click += new System.EventHandler(this.Bt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Buscar por";
            // 
            // Tboxbuscar
            // 
            this.Tboxbuscar.Location = new System.Drawing.Point(458, 35);
            this.Tboxbuscar.Name = "Tboxbuscar";
            this.Tboxbuscar.Size = new System.Drawing.Size(292, 20);
            this.Tboxbuscar.TabIndex = 22;
            // 
            // CombCargo
            // 
            this.CombCargo.FormattingEnabled = true;
            this.CombCargo.Location = new System.Drawing.Point(62, 278);
            this.CombCargo.Name = "CombCargo";
            this.CombCargo.Size = new System.Drawing.Size(121, 21);
            this.CombCargo.TabIndex = 28;
            this.CombCargo.SelectedIndexChanged += new System.EventHandler(this.CombCargo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Cargo";
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 425);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CombCargo);
            this.Controls.Add(this.RadioId);
            this.Controls.Add(this.RadioApellido);
            this.Controls.Add(this.RadioNombre);
            this.Controls.Add(this.Bt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Tboxbuscar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TboxFechaNacimiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TboxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TboxCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datagv2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TboxSalario);
            this.Controls.Add(this.TboxApellido);
            this.Controls.Add(this.TboxNombre);
            this.Controls.Add(this.CombSexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmMantenimiento";
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.FrmActualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CombSexo;
        private System.Windows.Forms.TextBox TboxSalario;
        private System.Windows.Forms.TextBox TboxApellido;
        private System.Windows.Forms.TextBox TboxNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Datagv2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TboxCedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TboxID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TboxFechaNacimiento;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton RadioId;
        private System.Windows.Forms.RadioButton RadioApellido;
        private System.Windows.Forms.RadioButton RadioNombre;
        private System.Windows.Forms.Button Bt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tboxbuscar;
        private System.Windows.Forms.ComboBox CombCargo;
        private System.Windows.Forms.Label label9;
    }
}