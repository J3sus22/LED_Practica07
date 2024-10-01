namespace LED_Practica07
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
            this.bntEncender = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntEncender
            // 
            this.bntEncender.Location = new System.Drawing.Point(307, 52);
            this.bntEncender.Name = "bntEncender";
            this.bntEncender.Size = new System.Drawing.Size(179, 102);
            this.bntEncender.TabIndex = 0;
            this.bntEncender.Text = "ENCENDER";
            this.bntEncender.UseVisualStyleBackColor = true;
            this.bntEncender.Click += new System.EventHandler(this.bntEncender_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(307, 218);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(179, 102);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.bntEncender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntEncender;
        private System.Windows.Forms.Button btnApagar;
    }
}

