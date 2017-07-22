namespace nomina
{
    partial class FrmActualizar
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(533, 121);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 274);
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
            this.CombSexo.Location = new System.Drawing.Point(62, 234);
            this.CombSexo.Name = "CombSexo";
            this.CombSexo.Size = new System.Drawing.Size(36, 21);
            this.CombSexo.TabIndex = 8;
            // 
            // TboxSalario
            // 
            this.TboxSalario.Location = new System.Drawing.Point(62, 271);
            this.TboxSalario.Name = "TboxSalario";
            this.TboxSalario.Size = new System.Drawing.Size(100, 20);
            this.TboxSalario.TabIndex = 11;
            // 
            // TboxApellido
            // 
            this.TboxApellido.Location = new System.Drawing.Point(62, 208);
            this.TboxApellido.Name = "TboxApellido";
            this.TboxApellido.Size = new System.Drawing.Size(295, 20);
            this.TboxApellido.TabIndex = 10;
            // 
            // TboxNombre
            // 
            this.TboxNombre.Location = new System.Drawing.Point(62, 175);
            this.TboxNombre.Name = "TboxNombre";
            this.TboxNombre.Size = new System.Drawing.Size(295, 20);
            this.TboxNombre.TabIndex = 9;
            this.TboxNombre.TextChanged += new System.EventHandler(this.TboxNombre_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 349);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "FrmActualizar";
            this.Text = "FrmActualizar";
            this.Load += new System.EventHandler(this.FrmActualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
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
    }
}