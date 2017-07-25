namespace nomina
{
    partial class Insertardatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TboxNombre = new System.Windows.Forms.TextBox();
            this.TboxApellido = new System.Windows.Forms.TextBox();
            this.CombSexo = new System.Windows.Forms.ComboBox();
            this.Tboxid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Buscarid = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Tboxsalario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nuevo Empleado";
            // 
            // TboxNombre
            // 
            this.TboxNombre.Location = new System.Drawing.Point(94, 57);
            this.TboxNombre.Name = "TboxNombre";
            this.TboxNombre.Size = new System.Drawing.Size(295, 20);
            this.TboxNombre.TabIndex = 5;
            // 
            // TboxApellido
            // 
            this.TboxApellido.Location = new System.Drawing.Point(94, 90);
            this.TboxApellido.Name = "TboxApellido";
            this.TboxApellido.Size = new System.Drawing.Size(295, 20);
            this.TboxApellido.TabIndex = 6;
            // 
            // CombSexo
            // 
            this.CombSexo.FormattingEnabled = true;
            this.CombSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CombSexo.Location = new System.Drawing.Point(94, 123);
            this.CombSexo.Name = "CombSexo";
            this.CombSexo.Size = new System.Drawing.Size(36, 21);
            this.CombSexo.TabIndex = 7;
            // 
            // Tboxid
            // 
            this.Tboxid.Location = new System.Drawing.Point(75, 202);
            this.Tboxid.Name = "Tboxid";
            this.Tboxid.Size = new System.Drawing.Size(31, 20);
            this.Tboxid.TabIndex = 8;
            this.Tboxid.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Buscarid
            // 
            this.Buscarid.Location = new System.Drawing.Point(128, 198);
            this.Buscarid.Name = "Buscarid";
            this.Buscarid.Size = new System.Drawing.Size(47, 27);
            this.Buscarid.TabIndex = 11;
            this.Buscarid.Text = "Buscar";
            this.Buscarid.UseVisualStyleBackColor = true;
            this.Buscarid.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id";
            // 
            // Tboxsalario
            // 
            this.Tboxsalario.Location = new System.Drawing.Point(94, 162);
            this.Tboxsalario.Name = "Tboxsalario";
            this.Tboxsalario.Size = new System.Drawing.Size(91, 20);
            this.Tboxsalario.TabIndex = 13;
            // 
            // Insertardatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 319);
            this.Controls.Add(this.Tboxsalario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Buscarid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tboxid);
            this.Controls.Add(this.CombSexo);
            this.Controls.Add(this.TboxApellido);
            this.Controls.Add(this.TboxNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Insertardatos";
            this.Text = "Insertardatos";
            this.Load += new System.EventHandler(this.Insertardatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TboxNombre;
        private System.Windows.Forms.TextBox TboxApellido;
        private System.Windows.Forms.ComboBox CombSexo;
        private System.Windows.Forms.TextBox Tboxid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Buscarid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tboxsalario;
    }
}