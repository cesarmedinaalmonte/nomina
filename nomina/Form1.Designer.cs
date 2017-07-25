namespace nomina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Datagv1 = new System.Windows.Forms.DataGridView();
            this.Tboxbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.RadioNombre = new System.Windows.Forms.RadioButton();
            this.RadioApellido = new System.Windows.Forms.RadioButton();
            this.RadioId = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Datagv1)).BeginInit();
            this.SuspendLayout();
            // 
            // Datagv1
            // 
            this.Datagv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagv1.Location = new System.Drawing.Point(12, 79);
            this.Datagv1.Name = "Datagv1";
            this.Datagv1.Size = new System.Drawing.Size(548, 122);
            this.Datagv1.TabIndex = 0;
            this.Datagv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Tboxbuscar
            // 
            this.Tboxbuscar.Location = new System.Drawing.Point(90, 53);
            this.Tboxbuscar.Name = "Tboxbuscar";
            this.Tboxbuscar.Size = new System.Drawing.Size(292, 20);
            this.Tboxbuscar.TabIndex = 1;
            this.Tboxbuscar.TextChanged += new System.EventHandler(this.Tboxbuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bt
            // 
            this.Bt.Location = new System.Drawing.Point(398, 49);
            this.Bt.Name = "Bt";
            this.Bt.Size = new System.Drawing.Size(80, 27);
            this.Bt.TabIndex = 3;
            this.Bt.Text = "Buscar";
            this.Bt.UseVisualStyleBackColor = true;
            this.Bt.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nuevo Empleado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Editar Empleado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(386, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 43);
            this.button3.TabIndex = 6;
            this.button3.Text = "Eliminar Empleado";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RadioNombre
            // 
            this.RadioNombre.AutoSize = true;
            this.RadioNombre.Location = new System.Drawing.Point(132, 26);
            this.RadioNombre.Name = "RadioNombre";
            this.RadioNombre.Size = new System.Drawing.Size(62, 17);
            this.RadioNombre.TabIndex = 7;
            this.RadioNombre.TabStop = true;
            this.RadioNombre.Text = "Nombre";
            this.RadioNombre.UseVisualStyleBackColor = true;
            // 
            // RadioApellido
            // 
            this.RadioApellido.AutoSize = true;
            this.RadioApellido.Location = new System.Drawing.Point(200, 26);
            this.RadioApellido.Name = "RadioApellido";
            this.RadioApellido.Size = new System.Drawing.Size(62, 17);
            this.RadioApellido.TabIndex = 8;
            this.RadioApellido.TabStop = true;
            this.RadioApellido.Text = "Apellido";
            this.RadioApellido.UseVisualStyleBackColor = true;
            // 
            // RadioId
            // 
            this.RadioId.AutoSize = true;
            this.RadioId.Location = new System.Drawing.Point(90, 26);
            this.RadioId.Name = "RadioId";
            this.RadioId.Size = new System.Drawing.Size(36, 17);
            this.RadioId.TabIndex = 9;
            this.RadioId.TabStop = true;
            this.RadioId.Text = "ID";
            this.RadioId.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 379);
            this.Controls.Add(this.RadioId);
            this.Controls.Add(this.RadioApellido);
            this.Controls.Add(this.RadioNombre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tboxbuscar);
            this.Controls.Add(this.Datagv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datagv1;
        private System.Windows.Forms.TextBox Tboxbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton RadioNombre;
        private System.Windows.Forms.RadioButton RadioApellido;
        private System.Windows.Forms.RadioButton RadioId;
    }
}

