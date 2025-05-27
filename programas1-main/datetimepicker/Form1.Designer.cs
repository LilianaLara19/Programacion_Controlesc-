namespace DateTimePicker
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btncalular = new System.Windows.Forms.Button();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(417, 57);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 13);
            this.lblfecha.TabIndex = 1;
            // 
            // btncalular
            // 
            this.btncalular.Location = new System.Drawing.Point(196, 100);
            this.btncalular.Name = "btncalular";
            this.btncalular.Size = new System.Drawing.Size(75, 23);
            this.btncalular.TabIndex = 2;
            this.btncalular.Text = "calcular";
            this.btncalular.UseVisualStyleBackColor = true;
            this.btncalular.Click += new System.EventHandler(this.btncalular_Click);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(296, 100);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(100, 20);
            this.txtDias.TabIndex = 3;
            this.txtDias.Text = "0";
            this.txtDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.btncalular);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btncalular;
        private System.Windows.Forms.TextBox txtDias;
    }
}

