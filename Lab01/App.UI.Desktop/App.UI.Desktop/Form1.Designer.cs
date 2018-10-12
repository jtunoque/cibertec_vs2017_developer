namespace App.UI.Desktop
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.btnEnviarFactura = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Obtener IGV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IGV";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Location = new System.Drawing.Point(101, 118);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(35, 13);
            this.lblIGV.TabIndex = 2;
            this.lblIGV.Text = "label2";
            // 
            // btnEnviarFactura
            // 
            this.btnEnviarFactura.Location = new System.Drawing.Point(40, 206);
            this.btnEnviarFactura.Name = "btnEnviarFactura";
            this.btnEnviarFactura.Size = new System.Drawing.Size(148, 71);
            this.btnEnviarFactura.TabIndex = 3;
            this.btnEnviarFactura.Text = "Enviar Factura";
            this.btnEnviarFactura.UseVisualStyleBackColor = true;
            this.btnEnviarFactura.Click += new System.EventHandler(this.btnEnviarFactura_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 73);
            this.button2.TabIndex = 4;
            this.button2.Text = "Elvis operator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEnviarFactura);
            this.Controls.Add(this.lblIGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Button btnEnviarFactura;
        private System.Windows.Forms.Button button2;
    }
}

