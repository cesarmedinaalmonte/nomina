namespace nomina
{
    partial class Mantenimientocargo
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
            this.button3 = new System.Windows.Forms.Button();
            this.TboxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TboxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Datagv3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Datagv3)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 29);
            this.button3.TabIndex = 46;
            this.button3.Text = "Ingresar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TboxID
            // 
            this.TboxID.Location = new System.Drawing.Point(124, 49);
            this.TboxID.Name = "TboxID";
            this.TboxID.Size = new System.Drawing.Size(36, 20);
            this.TboxID.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 28);
            this.button2.TabIndex = 38;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TboxNombre
            // 
            this.TboxNombre.Location = new System.Drawing.Point(124, 89);
            this.TboxNombre.Name = "TboxNombre";
            this.TboxNombre.Size = new System.Drawing.Size(171, 20);
            this.TboxNombre.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre del Cargo:";
            // 
            // Datagv3
            // 
            this.Datagv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagv3.Location = new System.Drawing.Point(12, 125);
            this.Datagv3.Name = "Datagv3";
            this.Datagv3.Size = new System.Drawing.Size(304, 150);
            this.Datagv3.TabIndex = 47;
            this.Datagv3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagv3_CellContentClick);
            // 
            // Mantenimientocargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 284);
            this.Controls.Add(this.Datagv3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TboxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TboxNombre);
            this.Controls.Add(this.label2);
            this.Name = "Mantenimientocargo";
            this.Text = "Mantenimientocargo";
            this.Load += new System.EventHandler(this.Mantenimientocargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TboxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TboxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Datagv3;
    }
}