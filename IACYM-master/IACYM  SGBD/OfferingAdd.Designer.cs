namespace IACYM__SGBD
{
    partial class OfferingAdd
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
            this.ButtonAgregar = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.MonthCalendarEmision = new System.Windows.Forms.MonthCalendar();
            this.DataGridViewCultos = new System.Windows.Forms.DataGridView();
            this.Cultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCulto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCultos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAgregar
            // 
            this.ButtonAgregar.Location = new System.Drawing.Point(105, 264);
            this.ButtonAgregar.Name = "ButtonAgregar";
            this.ButtonAgregar.Size = new System.Drawing.Size(75, 23);
            this.ButtonAgregar.TabIndex = 0;
            this.ButtonAgregar.Text = "Agregar";
            this.ButtonAgregar.UseVisualStyleBackColor = true;
            this.ButtonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Location = new System.Drawing.Point(76, 276);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancelar.TabIndex = 1;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // MonthCalendarEmision
            // 
            this.MonthCalendarEmision.Location = new System.Drawing.Point(16, 90);
            this.MonthCalendarEmision.MaxSelectionCount = 1;
            this.MonthCalendarEmision.Name = "MonthCalendarEmision";
            this.MonthCalendarEmision.TabIndex = 3;
            // 
            // DataGridViewCultos
            // 
            this.DataGridViewCultos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCultos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cultos});
            this.DataGridViewCultos.Location = new System.Drawing.Point(12, 12);
            this.DataGridViewCultos.Name = "DataGridViewCultos";
            this.DataGridViewCultos.ReadOnly = true;
            this.DataGridViewCultos.Size = new System.Drawing.Size(203, 252);
            this.DataGridViewCultos.TabIndex = 2;
            // 
            // Cultos
            // 
            this.Cultos.HeaderText = "Cultos Encontrados";
            this.Cultos.Name = "Cultos";
            this.Cultos.ReadOnly = true;
            this.Cultos.Width = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Culto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Emision:";
            // 
            // TextBoxCulto
            // 
            this.TextBoxCulto.Location = new System.Drawing.Point(25, 42);
            this.TextBoxCulto.Name = "TextBoxCulto";
            this.TextBoxCulto.Size = new System.Drawing.Size(72, 20);
            this.TextBoxCulto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto:";
            // 
            // TextBoxMonto
            // 
            this.TextBoxMonto.Location = new System.Drawing.Point(171, 42);
            this.TextBoxMonto.Name = "TextBoxMonto";
            this.TextBoxMonto.Size = new System.Drawing.Size(75, 20);
            this.TextBoxMonto.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "S/.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ButtonAgregar);
            this.groupBox1.Controls.Add(this.TextBoxMonto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBoxCulto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MonthCalendarEmision);
            this.groupBox1.Location = new System.Drawing.Point(230, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Datos";
            // 
            // OfferingAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 320);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGridViewCultos);
            this.Name = "OfferingAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Ofrenda";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCultos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAgregar;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.MonthCalendar MonthCalendarEmision;
        private System.Windows.Forms.DataGridView DataGridViewCultos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCulto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cultos;
    }
}