namespace IACYM__SGBD
{
    partial class MemberFindMonth
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
            this.TextBoxCodigo = new System.Windows.Forms.TextBox();
            this.ButtonVerDatos = new System.Windows.Forms.Button();
            this.ButtonAtras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewMiembros = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name_father = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name_mother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMiembros)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxCodigo
            // 
            this.TextBoxCodigo.Location = new System.Drawing.Point(294, 389);
            this.TextBoxCodigo.Name = "TextBoxCodigo";
            this.TextBoxCodigo.Size = new System.Drawing.Size(80, 20);
            this.TextBoxCodigo.TabIndex = 0;
            this.TextBoxCodigo.Enter += new System.EventHandler(this.TextBoxCodigo_Enter);
            this.TextBoxCodigo.Leave += new System.EventHandler(this.TextBoxCodigo_Leave);
            // 
            // ButtonVerDatos
            // 
            this.ButtonVerDatos.Location = new System.Drawing.Point(296, 412);
            this.ButtonVerDatos.Name = "ButtonVerDatos";
            this.ButtonVerDatos.Size = new System.Drawing.Size(75, 23);
            this.ButtonVerDatos.TabIndex = 1;
            this.ButtonVerDatos.Text = "Ver datos";
            this.ButtonVerDatos.UseVisualStyleBackColor = true;
            this.ButtonVerDatos.Click += new System.EventHandler(this.ButtonVerDatos_Click);
            // 
            // ButtonAtras
            // 
            this.ButtonAtras.Location = new System.Drawing.Point(94, 400);
            this.ButtonAtras.Name = "ButtonAtras";
            this.ButtonAtras.Size = new System.Drawing.Size(75, 23);
            this.ButtonAtras.TabIndex = 2;
            this.ButtonAtras.Text = "Atras";
            this.ButtonAtras.UseVisualStyleBackColor = true;
            this.ButtonAtras.Click += new System.EventHandler(this.ButtonAtras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DataGridViewMiembros);
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 358);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miembros encontrados";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.ForeColor = System.Drawing.Color.Blue;
            this.LabelTotal.Location = new System.Drawing.Point(379, 0);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(13, 13);
            this.LabelTotal.TabIndex = 3;
            this.LabelTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total:";
            // 
            // DataGridViewMiembros
            // 
            this.DataGridViewMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMiembros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.Nombre,
            this.last_name_father,
            this.last_name_mother});
            this.DataGridViewMiembros.Location = new System.Drawing.Point(9, 19);
            this.DataGridViewMiembros.Name = "DataGridViewMiembros";
            this.DataGridViewMiembros.ReadOnly = true;
            this.DataGridViewMiembros.Size = new System.Drawing.Size(436, 330);
            this.DataGridViewMiembros.TabIndex = 1;
            // 
            // code
            // 
            this.code.HeaderText = "Código";
            this.code.MaxInputLength = 4;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Width = 45;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 130;
            // 
            // last_name_father
            // 
            this.last_name_father.HeaderText = "Apellido Paterno";
            this.last_name_father.MaxInputLength = 10;
            this.last_name_father.Name = "last_name_father";
            this.last_name_father.ReadOnly = true;
            this.last_name_father.Width = 109;
            // 
            // last_name_mother
            // 
            this.last_name_mother.HeaderText = "Apellido Materno";
            this.last_name_mother.MaxInputLength = 10;
            this.last_name_mother.Name = "last_name_mother";
            this.last_name_mother.ReadOnly = true;
            this.last_name_mother.Width = 109;
            // 
            // MemberFindMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.TextBoxCodigo);
            this.Controls.Add(this.ButtonVerDatos);
            this.Controls.Add(this.ButtonAtras);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemberFindMonth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda por Mes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMiembros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxCodigo;
        private System.Windows.Forms.Button ButtonVerDatos;
        private System.Windows.Forms.Button ButtonAtras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewMiembros;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_father;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_mother;
    }
}