namespace IACYM__SGBD
{
    partial class OfferingFind
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
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonBuscarOfrenda = new System.Windows.Forms.Button();
            this.TextBoxAño = new System.Windows.Forms.TextBox();
            this.ButtonAtras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DdataGridViewOfrendas = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxCulto = new System.Windows.Forms.TextBox();
            this.TextBoxMes = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckBoxAño = new System.Windows.Forms.CheckBox();
            this.CheckBoxMes = new System.Windows.Forms.CheckBox();
            this.CheckBoxCulto = new System.Windows.Forms.CheckBox();
            this.DataGridViewCultos = new System.Windows.Forms.DataGridView();
            this.Cultos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxIdEliminarOfrenda = new System.Windows.Forms.TextBox();
            this.ButtonEliminarOfrenda = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxIdEliminarCulto = new System.Windows.Forms.TextBox();
            this.ButtonEliminarCulto = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DdataGridViewOfrendas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCultos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.ForeColor = System.Drawing.Color.Blue;
            this.LabelTotal.Location = new System.Drawing.Point(299, 0);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(13, 13);
            this.LabelTotal.TabIndex = 61;
            this.LabelTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Monto Total:";
            // 
            // ButtonBuscarOfrenda
            // 
            this.ButtonBuscarOfrenda.Location = new System.Drawing.Point(77, 357);
            this.ButtonBuscarOfrenda.Name = "ButtonBuscarOfrenda";
            this.ButtonBuscarOfrenda.Size = new System.Drawing.Size(75, 23);
            this.ButtonBuscarOfrenda.TabIndex = 6;
            this.ButtonBuscarOfrenda.Text = "Buscar";
            this.ButtonBuscarOfrenda.UseVisualStyleBackColor = true;
            this.ButtonBuscarOfrenda.Click += new System.EventHandler(this.ButtonBuscarOfrenda_Click);
            // 
            // TextBoxAño
            // 
            this.TextBoxAño.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxAño.Location = new System.Drawing.Point(90, 311);
            this.TextBoxAño.Name = "TextBoxAño";
            this.TextBoxAño.Size = new System.Drawing.Size(80, 20);
            this.TextBoxAño.TabIndex = 5;
            // 
            // ButtonAtras
            // 
            this.ButtonAtras.Location = new System.Drawing.Point(342, 431);
            this.ButtonAtras.Name = "ButtonAtras";
            this.ButtonAtras.Size = new System.Drawing.Size(75, 23);
            this.ButtonAtras.TabIndex = 3;
            this.ButtonAtras.Text = "Atras";
            this.ButtonAtras.UseVisualStyleBackColor = true;
            this.ButtonAtras.Click += new System.EventHandler(this.ButtonAtras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DdataGridViewOfrendas);
            this.groupBox1.Controls.Add(this.LabelTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(215, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 380);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ofrendas encontradas";
            // 
            // DdataGridViewOfrendas
            // 
            this.DdataGridViewOfrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DdataGridViewOfrendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.worship,
            this.amount,
            this.date});
            this.DdataGridViewOfrendas.Location = new System.Drawing.Point(9, 19);
            this.DdataGridViewOfrendas.Name = "DdataGridViewOfrendas";
            this.DdataGridViewOfrendas.Size = new System.Drawing.Size(359, 352);
            this.DdataGridViewOfrendas.TabIndex = 1;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 40;
            // 
            // worship
            // 
            this.worship.HeaderText = "Culto";
            this.worship.Name = "worship";
            this.worship.Width = 125;
            // 
            // amount
            // 
            this.amount.HeaderText = "Monto S/.";
            this.amount.Name = "amount";
            this.amount.Width = 80;
            // 
            // date
            // 
            this.date.HeaderText = "Fecha";
            this.date.Name = "date";
            this.date.Width = 70;
            // 
            // TextBoxCulto
            // 
            this.TextBoxCulto.Location = new System.Drawing.Point(90, 233);
            this.TextBoxCulto.Name = "TextBoxCulto";
            this.TextBoxCulto.Size = new System.Drawing.Size(80, 20);
            this.TextBoxCulto.TabIndex = 1;
            // 
            // TextBoxMes
            // 
            this.TextBoxMes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxMes.FormattingEnabled = true;
            this.TextBoxMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.TextBoxMes.Location = new System.Drawing.Point(90, 270);
            this.TextBoxMes.Name = "TextBoxMes";
            this.TextBoxMes.Size = new System.Drawing.Size(80, 21);
            this.TextBoxMes.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckBoxAño);
            this.groupBox2.Controls.Add(this.CheckBoxMes);
            this.groupBox2.Controls.Add(this.CheckBoxCulto);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.DataGridViewCultos);
            this.groupBox2.Controls.Add(this.TextBoxMes);
            this.groupBox2.Controls.Add(this.TextBoxAño);
            this.groupBox2.Controls.Add(this.ButtonBuscarOfrenda);
            this.groupBox2.Controls.Add(this.TextBoxCulto);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 407);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Ofrendas";
            // 
            // CheckBoxAño
            // 
            this.CheckBoxAño.AutoSize = true;
            this.CheckBoxAño.Location = new System.Drawing.Point(34, 314);
            this.CheckBoxAño.Name = "CheckBoxAño";
            this.CheckBoxAño.Size = new System.Drawing.Size(45, 17);
            this.CheckBoxAño.TabIndex = 4;
            this.CheckBoxAño.Text = "Año";
            this.CheckBoxAño.UseVisualStyleBackColor = true;
            // 
            // CheckBoxMes
            // 
            this.CheckBoxMes.AutoSize = true;
            this.CheckBoxMes.Location = new System.Drawing.Point(34, 273);
            this.CheckBoxMes.Name = "CheckBoxMes";
            this.CheckBoxMes.Size = new System.Drawing.Size(49, 17);
            this.CheckBoxMes.TabIndex = 2;
            this.CheckBoxMes.Text = "Mes:";
            this.CheckBoxMes.UseVisualStyleBackColor = true;
            // 
            // CheckBoxCulto
            // 
            this.CheckBoxCulto.AutoSize = true;
            this.CheckBoxCulto.Location = new System.Drawing.Point(34, 236);
            this.CheckBoxCulto.Name = "CheckBoxCulto";
            this.CheckBoxCulto.Size = new System.Drawing.Size(53, 17);
            this.CheckBoxCulto.TabIndex = 0;
            this.CheckBoxCulto.Text = "Culto:";
            this.CheckBoxCulto.UseVisualStyleBackColor = true;
            // 
            // DataGridViewCultos
            // 
            this.DataGridViewCultos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCultos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cultos});
            this.DataGridViewCultos.Location = new System.Drawing.Point(6, 19);
            this.DataGridViewCultos.Name = "DataGridViewCultos";
            this.DataGridViewCultos.ReadOnly = true;
            this.DataGridViewCultos.Size = new System.Drawing.Size(203, 195);
            this.DataGridViewCultos.TabIndex = 14;
            // 
            // Cultos
            // 
            this.Cultos.HeaderText = "Cultos Encontrados";
            this.Cultos.Name = "Cultos";
            this.Cultos.ReadOnly = true;
            this.Cultos.Width = 160;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.TextBoxIdEliminarOfrenda);
            this.groupBox4.Controls.Add(this.ButtonEliminarOfrenda);
            this.groupBox4.Location = new System.Drawing.Point(624, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 166);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Eliminar Ofrenda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ingrese ID de la \r\nOfrenda:\r\n";
            // 
            // TextBoxIdEliminarOfrenda
            // 
            this.TextBoxIdEliminarOfrenda.Location = new System.Drawing.Point(44, 74);
            this.TextBoxIdEliminarOfrenda.Name = "TextBoxIdEliminarOfrenda";
            this.TextBoxIdEliminarOfrenda.Size = new System.Drawing.Size(45, 20);
            this.TextBoxIdEliminarOfrenda.TabIndex = 0;
            // 
            // ButtonEliminarOfrenda
            // 
            this.ButtonEliminarOfrenda.Location = new System.Drawing.Point(37, 103);
            this.ButtonEliminarOfrenda.Name = "ButtonEliminarOfrenda";
            this.ButtonEliminarOfrenda.Size = new System.Drawing.Size(62, 38);
            this.ButtonEliminarOfrenda.TabIndex = 1;
            this.ButtonEliminarOfrenda.Text = "Eliminar Ofrenda";
            this.ButtonEliminarOfrenda.UseVisualStyleBackColor = true;
            this.ButtonEliminarOfrenda.Click += new System.EventHandler(this.ButtonEliminarOfrenda_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TextBoxIdEliminarCulto);
            this.groupBox3.Controls.Add(this.ButtonEliminarCulto);
            this.groupBox3.Location = new System.Drawing.Point(624, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 159);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar Culto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ingrese Nombre del \r\nCulto:\r\n";
            // 
            // TextBoxIdEliminarCulto
            // 
            this.TextBoxIdEliminarCulto.Location = new System.Drawing.Point(27, 61);
            this.TextBoxIdEliminarCulto.Name = "TextBoxIdEliminarCulto";
            this.TextBoxIdEliminarCulto.Size = new System.Drawing.Size(82, 20);
            this.TextBoxIdEliminarCulto.TabIndex = 0;
            // 
            // ButtonEliminarCulto
            // 
            this.ButtonEliminarCulto.Location = new System.Drawing.Point(37, 96);
            this.ButtonEliminarCulto.Name = "ButtonEliminarCulto";
            this.ButtonEliminarCulto.Size = new System.Drawing.Size(62, 38);
            this.ButtonEliminarCulto.TabIndex = 1;
            this.ButtonEliminarCulto.Text = "Eliminar Culto";
            this.ButtonEliminarCulto.UseVisualStyleBackColor = true;
            this.ButtonEliminarCulto.Click += new System.EventHandler(this.ButtonEliminarCulto_Click);
            // 
            // OfferingFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 466);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ButtonAtras);
            this.Name = "OfferingFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Ofrendas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DdataGridViewOfrendas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCultos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonBuscarOfrenda;
        private System.Windows.Forms.TextBox TextBoxAño;
        private System.Windows.Forms.Button ButtonAtras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DdataGridViewOfrendas;
        private System.Windows.Forms.TextBox TextBoxCulto;
        private System.Windows.Forms.ComboBox TextBoxMes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DataGridViewCultos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxIdEliminarOfrenda;
        private System.Windows.Forms.Button ButtonEliminarOfrenda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxIdEliminarCulto;
        private System.Windows.Forms.Button ButtonEliminarCulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cultos;
        private System.Windows.Forms.CheckBox CheckBoxAño;
        private System.Windows.Forms.CheckBox CheckBoxMes;
        private System.Windows.Forms.CheckBox CheckBoxCulto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn worship;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}