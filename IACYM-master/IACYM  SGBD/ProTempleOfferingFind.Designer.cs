namespace IACYM__SGBD
{
    partial class ProTempleOfferingFind
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
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.TextBoxAño = new System.Windows.Forms.TextBox();
            this.TextBoxMes = new System.Windows.Forms.ComboBox();
            this.DataGridViewOfrendasProTemplo = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonAtras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOfrendasProTemplo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.Location = new System.Drawing.Point(223, 19);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.ButtonBuscar.TabIndex = 2;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.UseVisualStyleBackColor = true;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // TextBoxAño
            // 
            this.TextBoxAño.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxAño.Location = new System.Drawing.Point(114, 20);
            this.TextBoxAño.Name = "TextBoxAño";
            this.TextBoxAño.Size = new System.Drawing.Size(80, 20);
            this.TextBoxAño.TabIndex = 1;
            this.TextBoxAño.Enter += new System.EventHandler(this.TextBoxAño_Enter);
            this.TextBoxAño.Leave += new System.EventHandler(this.TextBoxAño_Leave);
            // 
            // TextBoxMes
            // 
            this.TextBoxMes.ForeColor = System.Drawing.SystemColors.WindowFrame;
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
            this.TextBoxMes.Location = new System.Drawing.Point(13, 19);
            this.TextBoxMes.Name = "TextBoxMes";
            this.TextBoxMes.Size = new System.Drawing.Size(80, 21);
            this.TextBoxMes.TabIndex = 0;
            this.TextBoxMes.Enter += new System.EventHandler(this.TextBoxMes_Enter);
            this.TextBoxMes.Leave += new System.EventHandler(this.TextBoxMes_Leave);
            // 
            // DataGridViewOfrendasProTemplo
            // 
            this.DataGridViewOfrendasProTemplo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOfrendasProTemplo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.name,
            this.last_name,
            this.age,
            this.month,
            this.amount,
            this.date_emision});
            this.DataGridViewOfrendasProTemplo.Location = new System.Drawing.Point(9, 19);
            this.DataGridViewOfrendasProTemplo.Name = "DataGridViewOfrendasProTemplo";
            this.DataGridViewOfrendasProTemplo.Size = new System.Drawing.Size(668, 324);
            this.DataGridViewOfrendasProTemplo.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.HeaderText = "Código";
            this.Code.Name = "Code";
            this.Code.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Nombres";
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Apellidos";
            this.last_name.Name = "last_name";
            this.last_name.Width = 125;
            // 
            // age
            // 
            this.age.HeaderText = "Año";
            this.age.MaxInputLength = 4;
            this.age.Name = "age";
            this.age.Width = 50;
            // 
            // month
            // 
            this.month.HeaderText = "Mes";
            this.month.MaxInputLength = 10;
            this.month.Name = "month";
            this.month.Width = 80;
            // 
            // amount
            // 
            this.amount.HeaderText = "Monto S/.";
            this.amount.MaxInputLength = 10;
            this.amount.Name = "amount";
            this.amount.Width = 80;
            // 
            // date_emision
            // 
            this.date_emision.HeaderText = "Fecha de Emision";
            this.date_emision.Name = "date_emision";
            this.date_emision.Width = 115;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.ForeColor = System.Drawing.Color.Blue;
            this.LabelTotal.Location = new System.Drawing.Point(493, 418);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(13, 13);
            this.LabelTotal.TabIndex = 61;
            this.LabelTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Monto Total:";
            // 
            // ButtonAtras
            // 
            this.ButtonAtras.Location = new System.Drawing.Point(189, 413);
            this.ButtonAtras.Name = "ButtonAtras";
            this.ButtonAtras.Size = new System.Drawing.Size(75, 23);
            this.ButtonAtras.TabIndex = 5;
            this.ButtonAtras.Text = "Atras";
            this.ButtonAtras.UseVisualStyleBackColor = true;
            this.ButtonAtras.Click += new System.EventHandler(this.ButtonAtras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataGridViewOfrendasProTemplo);
            this.groupBox1.Location = new System.Drawing.Point(13, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 353);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ofrendas Pro-Templo encontradas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ProTempleOfferingFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonBuscar);
            this.Controls.Add(this.TextBoxAño);
            this.Controls.Add(this.TextBoxMes);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonAtras);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProTempleOfferingFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Ofrendas Pro-Temple";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOfrendasProTemplo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.TextBox TextBoxAño;
        private System.Windows.Forms.ComboBox TextBoxMes;
        private System.Windows.Forms.DataGridView DataGridViewOfrendasProTemplo;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButtonAtras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_emision;
        private System.Windows.Forms.Button button1;
    }
}