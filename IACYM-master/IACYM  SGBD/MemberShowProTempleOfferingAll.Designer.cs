namespace IACYM__SGBD
{
    partial class MemberShowProTempleOfferingAll
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
            this.ButtonTodoDiezmos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBoxIdEliminar = new System.Windows.Forms.TextBox();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.GroupBoxBuscar = new System.Windows.Forms.GroupBox();
            this.TextBoxBuscarAño = new System.Windows.Forms.TextBox();
            this.TextBoxBuscarMes = new System.Windows.Forms.ComboBox();
            this.ButtonBuscar = new System.Windows.Forms.Button();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelNombreMiembro = new System.Windows.Forms.Label();
            this.ButtonAtras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelCantidad = new System.Windows.Forms.Label();
            this.DataGridViewDiezmos = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_emision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.GroupBoxBuscar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDiezmos)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonTodoDiezmos
            // 
            this.ButtonTodoDiezmos.Location = new System.Drawing.Point(451, 50);
            this.ButtonTodoDiezmos.Name = "ButtonTodoDiezmos";
            this.ButtonTodoDiezmos.Size = new System.Drawing.Size(75, 48);
            this.ButtonTodoDiezmos.TabIndex = 0;
            this.ButtonTodoDiezmos.Text = "Ver Todos Los Diezmos";
            this.ButtonTodoDiezmos.UseVisualStyleBackColor = true;
            this.ButtonTodoDiezmos.Click += new System.EventHandler(this.ButtonTodoDiezmos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBoxIdEliminar);
            this.groupBox3.Controls.Add(this.ButtonEliminar);
            this.groupBox3.Location = new System.Drawing.Point(439, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 89);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar";
            // 
            // TextBoxIdEliminar
            // 
            this.TextBoxIdEliminar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxIdEliminar.Location = new System.Drawing.Point(10, 22);
            this.TextBoxIdEliminar.Name = "TextBoxIdEliminar";
            this.TextBoxIdEliminar.Size = new System.Drawing.Size(80, 20);
            this.TextBoxIdEliminar.TabIndex = 0;
            this.TextBoxIdEliminar.Enter += new System.EventHandler(this.TextBoxIdEliminar_Enter);
            this.TextBoxIdEliminar.Leave += new System.EventHandler(this.TextBoxIdEliminar_Leave);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Location = new System.Drawing.Point(13, 53);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(75, 23);
            this.ButtonEliminar.TabIndex = 1;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // GroupBoxBuscar
            // 
            this.GroupBoxBuscar.Controls.Add(this.TextBoxBuscarAño);
            this.GroupBoxBuscar.Controls.Add(this.TextBoxBuscarMes);
            this.GroupBoxBuscar.Controls.Add(this.ButtonBuscar);
            this.GroupBoxBuscar.Location = new System.Drawing.Point(439, 130);
            this.GroupBoxBuscar.Name = "GroupBoxBuscar";
            this.GroupBoxBuscar.Size = new System.Drawing.Size(99, 134);
            this.GroupBoxBuscar.TabIndex = 1;
            this.GroupBoxBuscar.TabStop = false;
            this.GroupBoxBuscar.Text = "Buscar";
            // 
            // TextBoxBuscarAño
            // 
            this.TextBoxBuscarAño.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxBuscarAño.Location = new System.Drawing.Point(10, 59);
            this.TextBoxBuscarAño.Name = "TextBoxBuscarAño";
            this.TextBoxBuscarAño.Size = new System.Drawing.Size(80, 20);
            this.TextBoxBuscarAño.TabIndex = 1;
            this.TextBoxBuscarAño.Enter += new System.EventHandler(this.TextBoxBuscarAño_Enter);
            this.TextBoxBuscarAño.Leave += new System.EventHandler(this.TextBoxBuscarAño_Leave);
            // 
            // TextBoxBuscarMes
            // 
            this.TextBoxBuscarMes.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxBuscarMes.FormattingEnabled = true;
            this.TextBoxBuscarMes.Items.AddRange(new object[] {
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
            this.TextBoxBuscarMes.Location = new System.Drawing.Point(10, 25);
            this.TextBoxBuscarMes.Name = "TextBoxBuscarMes";
            this.TextBoxBuscarMes.Size = new System.Drawing.Size(80, 21);
            this.TextBoxBuscarMes.TabIndex = 0;
            this.TextBoxBuscarMes.Enter += new System.EventHandler(this.TextBoxBuscarMes_Enter);
            this.TextBoxBuscarMes.Leave += new System.EventHandler(this.TextBoxBuscarMes_Leave);
            // 
            // ButtonBuscar
            // 
            this.ButtonBuscar.Location = new System.Drawing.Point(12, 100);
            this.ButtonBuscar.Name = "ButtonBuscar";
            this.ButtonBuscar.Size = new System.Drawing.Size(75, 23);
            this.ButtonBuscar.TabIndex = 2;
            this.ButtonBuscar.Text = "Buscar";
            this.ButtonBuscar.UseVisualStyleBackColor = true;
            this.ButtonBuscar.Click += new System.EventHandler(this.ButtonBuscar_Click);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.ForeColor = System.Drawing.Color.Blue;
            this.LabelTotal.Location = new System.Drawing.Point(399, 422);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(31, 13);
            this.LabelTotal.TabIndex = 82;
            this.LabelTotal.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "Monto Total:";
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.ForeColor = System.Drawing.Color.Blue;
            this.LabelCodigo.Location = new System.Drawing.Point(486, 11);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(40, 13);
            this.LabelCodigo.TabIndex = 79;
            this.LabelCodigo.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Código:";
            // 
            // LabelNombreMiembro
            // 
            this.LabelNombreMiembro.AutoSize = true;
            this.LabelNombreMiembro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreMiembro.Location = new System.Drawing.Point(22, 11);
            this.LabelNombreMiembro.Name = "LabelNombreMiembro";
            this.LabelNombreMiembro.Size = new System.Drawing.Size(139, 17);
            this.LabelNombreMiembro.TabIndex = 77;
            this.LabelNombreMiembro.Text = "Nombre del Miembro";
            // 
            // ButtonAtras
            // 
            this.ButtonAtras.Location = new System.Drawing.Point(110, 417);
            this.ButtonAtras.Name = "ButtonAtras";
            this.ButtonAtras.Size = new System.Drawing.Size(75, 23);
            this.ButtonAtras.TabIndex = 3;
            this.ButtonAtras.Text = "Atras";
            this.ButtonAtras.UseVisualStyleBackColor = true;
            this.ButtonAtras.Click += new System.EventHandler(this.ButtonAtras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelCantidad);
            this.groupBox1.Controls.Add(this.DataGridViewDiezmos);
            this.groupBox1.Location = new System.Drawing.Point(16, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 371);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diezmos encontrados";
            // 
            // LabelCantidad
            // 
            this.LabelCantidad.AutoSize = true;
            this.LabelCantidad.ForeColor = System.Drawing.Color.Blue;
            this.LabelCantidad.Location = new System.Drawing.Point(132, 0);
            this.LabelCantidad.Name = "LabelCantidad";
            this.LabelCantidad.Size = new System.Drawing.Size(13, 13);
            this.LabelCantidad.TabIndex = 86;
            this.LabelCantidad.Text = "0";
            // 
            // DataGridViewDiezmos
            // 
            this.DataGridViewDiezmos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDiezmos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.age,
            this.month,
            this.amount,
            this.date_emision});
            this.DataGridViewDiezmos.Location = new System.Drawing.Point(9, 19);
            this.DataGridViewDiezmos.Name = "DataGridViewDiezmos";
            this.DataGridViewDiezmos.Size = new System.Drawing.Size(384, 342);
            this.DataGridViewDiezmos.TabIndex = 1;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Width = 45;
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
            this.date_emision.Width = 85;
            // 
            // MemberShowProTempleOfferingAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.ButtonTodoDiezmos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBoxBuscar);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelNombreMiembro);
            this.Controls.Add(this.ButtonAtras);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemberShowProTempleOfferingAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Ofrendas Pro-Templo";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GroupBoxBuscar.ResumeLayout(false);
            this.GroupBoxBuscar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDiezmos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonTodoDiezmos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TextBoxIdEliminar;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.GroupBox GroupBoxBuscar;
        private System.Windows.Forms.TextBox TextBoxBuscarAño;
        private System.Windows.Forms.ComboBox TextBoxBuscarMes;
        private System.Windows.Forms.Button ButtonBuscar;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelNombreMiembro;
        private System.Windows.Forms.Button ButtonAtras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridViewDiezmos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_emision;
        private System.Windows.Forms.Label LabelCantidad;
    }
}