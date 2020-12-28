namespace IACYM__SGBD
{
    partial class MemberShowAll
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name_father = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name_mother = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridViewMiembros = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelNumero = new System.Windows.Forms.Label();
            this.CheckBoxVerInactivos = new System.Windows.Forms.CheckBox();
            this.CheckBoxVerActivos = new System.Windows.Forms.CheckBox();
            this.CheckBoxVerTodo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMiembros)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxCodigo
            // 
            this.TextBoxCodigo.Location = new System.Drawing.Point(345, 419);
            this.TextBoxCodigo.Name = "TextBoxCodigo";
            this.TextBoxCodigo.Size = new System.Drawing.Size(80, 20);
            this.TextBoxCodigo.TabIndex = 3;
            this.TextBoxCodigo.Enter += new System.EventHandler(this.TextBoxCodigo_Enter);
            this.TextBoxCodigo.Leave += new System.EventHandler(this.TextBoxCodigo_Leave);
            // 
            // ButtonVerDatos
            // 
            this.ButtonVerDatos.Location = new System.Drawing.Point(347, 444);
            this.ButtonVerDatos.Name = "ButtonVerDatos";
            this.ButtonVerDatos.Size = new System.Drawing.Size(75, 23);
            this.ButtonVerDatos.TabIndex = 4;
            this.ButtonVerDatos.Text = "Ver datos";
            this.ButtonVerDatos.UseVisualStyleBackColor = true;
            this.ButtonVerDatos.Click += new System.EventHandler(this.ButtonVerDatos_Click);
            // 
            // ButtonAtras
            // 
            this.ButtonAtras.Location = new System.Drawing.Point(45, 429);
            this.ButtonAtras.Name = "ButtonAtras";
            this.ButtonAtras.Size = new System.Drawing.Size(75, 23);
            this.ButtonAtras.TabIndex = 5;
            this.ButtonAtras.Text = "Atras";
            this.ButtonAtras.UseVisualStyleBackColor = true;
            this.ButtonAtras.Click += new System.EventHandler(this.ButtonAtras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 358);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miembros encontrados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione el número para ver ls Datos del Miembro";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.name,
            this.last_name_father,
            this.last_name_mother});
            this.dataGridView1.Location = new System.Drawing.Point(9, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 304);
            this.dataGridView1.TabIndex = 1;
            // 
            // code
            // 
            this.code.HeaderText = "Código";
            this.code.MaxInputLength = 4;
            this.code.Name = "code";
            this.code.Width = 45;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.MaxInputLength = 20;
            this.name.Name = "name";
            this.name.Width = 130;
            // 
            // last_name_father
            // 
            this.last_name_father.HeaderText = "Apellido Paterno";
            this.last_name_father.MaxInputLength = 10;
            this.last_name_father.Name = "last_name_father";
            this.last_name_father.Width = 109;
            // 
            // last_name_mother
            // 
            this.last_name_mother.HeaderText = "Apellido Materno";
            this.last_name_mother.MaxInputLength = 10;
            this.last_name_mother.Name = "last_name_mother";
            this.last_name_mother.Width = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad de Miembros:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataGridViewMiembros);
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 373);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Miembros encontrados";
            // 
            // DataGridViewMiembros
            // 
            this.DataGridViewMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMiembros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DataGridViewMiembros.Location = new System.Drawing.Point(9, 19);
            this.DataGridViewMiembros.Name = "DataGridViewMiembros";
            this.DataGridViewMiembros.ReadOnly = true;
            this.DataGridViewMiembros.Size = new System.Drawing.Size(436, 343);
            this.DataGridViewMiembros.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 20;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido Paterno";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 109;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellido Materno";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 109;
            // 
            // LabelNumero
            // 
            this.LabelNumero.AutoSize = true;
            this.LabelNumero.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelNumero.Location = new System.Drawing.Point(175, 439);
            this.LabelNumero.Name = "LabelNumero";
            this.LabelNumero.Size = new System.Drawing.Size(44, 13);
            this.LabelNumero.TabIndex = 9;
            this.LabelNumero.Text = "Numero";
            // 
            // CheckBoxVerInactivos
            // 
            this.CheckBoxVerInactivos.AutoSize = true;
            this.CheckBoxVerInactivos.Location = new System.Drawing.Point(317, 15);
            this.CheckBoxVerInactivos.Name = "CheckBoxVerInactivos";
            this.CheckBoxVerInactivos.Size = new System.Drawing.Size(88, 17);
            this.CheckBoxVerInactivos.TabIndex = 2;
            this.CheckBoxVerInactivos.Text = "Ver Inactivos";
            this.CheckBoxVerInactivos.UseVisualStyleBackColor = true;
            this.CheckBoxVerInactivos.Click += new System.EventHandler(this.CheckBoxVerInactivos_Click);
            // 
            // CheckBoxVerActivos
            // 
            this.CheckBoxVerActivos.AutoSize = true;
            this.CheckBoxVerActivos.Location = new System.Drawing.Point(191, 14);
            this.CheckBoxVerActivos.Name = "CheckBoxVerActivos";
            this.CheckBoxVerActivos.Size = new System.Drawing.Size(80, 17);
            this.CheckBoxVerActivos.TabIndex = 1;
            this.CheckBoxVerActivos.Text = "Ver Activos";
            this.CheckBoxVerActivos.UseVisualStyleBackColor = true;
            this.CheckBoxVerActivos.Click += new System.EventHandler(this.CheckBoxVerActivos_Click);
            // 
            // CheckBoxVerTodo
            // 
            this.CheckBoxVerTodo.AutoSize = true;
            this.CheckBoxVerTodo.Checked = true;
            this.CheckBoxVerTodo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxVerTodo.Location = new System.Drawing.Point(70, 15);
            this.CheckBoxVerTodo.Name = "CheckBoxVerTodo";
            this.CheckBoxVerTodo.Size = new System.Drawing.Size(70, 17);
            this.CheckBoxVerTodo.TabIndex = 0;
            this.CheckBoxVerTodo.Text = "Ver Todo";
            this.CheckBoxVerTodo.UseVisualStyleBackColor = true;
            this.CheckBoxVerTodo.Click += new System.EventHandler(this.CheckBoxVerTodo_Click);
            // 
            // MemberShowAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 479);
            this.Controls.Add(this.CheckBoxVerInactivos);
            this.Controls.Add(this.CheckBoxVerActivos);
            this.Controls.Add(this.CheckBoxVerTodo);
            this.Controls.Add(this.LabelNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxCodigo);
            this.Controls.Add(this.ButtonVerDatos);
            this.Controls.Add(this.ButtonAtras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemberShowAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Todos los Miembros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMiembros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxCodigo;
        private System.Windows.Forms.Button ButtonVerDatos;
        private System.Windows.Forms.Button ButtonAtras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_father;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name_mother;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridViewMiembros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label LabelNumero;
        private System.Windows.Forms.CheckBox CheckBoxVerInactivos;
        private System.Windows.Forms.CheckBox CheckBoxVerActivos;
        private System.Windows.Forms.CheckBox CheckBoxVerTodo;
    }
}