namespace IACYM__SGBD
{
    partial class CheckToComments
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
            this.TextBoxContraseña = new System.Windows.Forms.TextBox();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.ButtonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Contraseña:";
            // 
            // TextBoxContraseña
            // 
            this.TextBoxContraseña.Location = new System.Drawing.Point(42, 40);
            this.TextBoxContraseña.Name = "TextBoxContraseña";
            this.TextBoxContraseña.Size = new System.Drawing.Size(176, 20);
            this.TextBoxContraseña.TabIndex = 1;
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Location = new System.Drawing.Point(42, 76);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelar.TabIndex = 2;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // ButtonAceptar
            // 
            this.ButtonAceptar.Location = new System.Drawing.Point(143, 76);
            this.ButtonAceptar.Name = "ButtonAceptar";
            this.ButtonAceptar.Size = new System.Drawing.Size(75, 23);
            this.ButtonAceptar.TabIndex = 3;
            this.ButtonAceptar.Text = "Aceptar";
            this.ButtonAceptar.UseVisualStyleBackColor = true;
            this.ButtonAceptar.Click += new System.EventHandler(this.ButtonAceptar_Click);
            // 
            // CheckToComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 126);
            this.Controls.Add(this.ButtonAceptar);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.TextBoxContraseña);
            this.Controls.Add(this.label1);
            this.Name = "CheckToComments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxContraseña;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.Button ButtonAceptar;
    }
}