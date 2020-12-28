namespace IACYM__SGBD
{
    partial class MemberComments
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBoxIdBorrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonBorrar = new System.Windows.Forms.Button();
            this.DataGridViewComentarios = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.ButtonVerComentarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxVerComentario = new System.Windows.Forms.TextBox();
            this.ButtonAgregar = new System.Windows.Forms.Button();
            this.labelCode = new System.Windows.Forms.Label();
            this.TextBoxAgregarComentario = new System.Windows.Forms.TextBox();
            this.ButtonAtras = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComentarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBoxIdBorrar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ButtonBorrar);
            this.groupBox3.Controls.Add(this.DataGridViewComentarios);
            this.groupBox3.Location = new System.Drawing.Point(352, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 294);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comentarios Disponibles";
            // 
            // TextBoxIdBorrar
            // 
            this.TextBoxIdBorrar.Location = new System.Drawing.Point(13, 44);
            this.TextBoxIdBorrar.Name = "TextBoxIdBorrar";
            this.TextBoxIdBorrar.Size = new System.Drawing.Size(60, 20);
            this.TextBoxIdBorrar.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ingrese Fecha a Borrar:";
            // 
            // ButtonBorrar
            // 
            this.ButtonBorrar.Location = new System.Drawing.Point(158, 41);
            this.ButtonBorrar.Name = "ButtonBorrar";
            this.ButtonBorrar.Size = new System.Drawing.Size(58, 23);
            this.ButtonBorrar.TabIndex = 1;
            this.ButtonBorrar.Text = "Borrar";
            this.ButtonBorrar.UseVisualStyleBackColor = true;
            this.ButtonBorrar.Click += new System.EventHandler(this.ButtonBorrar_Click);
            // 
            // DataGridViewComentarios
            // 
            this.DataGridViewComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewComentarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnFecha});
            this.DataGridViewComentarios.Location = new System.Drawing.Point(13, 70);
            this.DataGridViewComentarios.Name = "DataGridViewComentarios";
            this.DataGridViewComentarios.Size = new System.Drawing.Size(203, 211);
            this.DataGridViewComentarios.TabIndex = 1;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 45;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.MaxInputLength = 20;
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.Width = 115;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxId);
            this.groupBox1.Controls.Add(this.ButtonVerComentarios);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TextBoxVerComentario);
            this.groupBox1.Controls.Add(this.ButtonAgregar);
            this.groupBox1.Controls.Add(this.labelCode);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.TextBoxAgregarComentario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administracion de Comentarios";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(18, 201);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(60, 20);
            this.TextBoxId.TabIndex = 2;
            // 
            // ButtonVerComentarios
            // 
            this.ButtonVerComentarios.Location = new System.Drawing.Point(237, 198);
            this.ButtonVerComentarios.Name = "ButtonVerComentarios";
            this.ButtonVerComentarios.Size = new System.Drawing.Size(90, 23);
            this.ButtonVerComentarios.TabIndex = 3;
            this.ButtonVerComentarios.Text = "Ver Comentario";
            this.ButtonVerComentarios.UseVisualStyleBackColor = true;
            this.ButtonVerComentarios.Click += new System.EventHandler(this.ButtonVerComentarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Ingrese ID para ver Comentario";
            // 
            // TextBoxVerComentario
            // 
            this.TextBoxVerComentario.Location = new System.Drawing.Point(18, 227);
            this.TextBoxVerComentario.Multiline = true;
            this.TextBoxVerComentario.Name = "TextBoxVerComentario";
            this.TextBoxVerComentario.ReadOnly = true;
            this.TextBoxVerComentario.Size = new System.Drawing.Size(309, 93);
            this.TextBoxVerComentario.TabIndex = 4;
            // 
            // ButtonAgregar
            // 
            this.ButtonAgregar.Location = new System.Drawing.Point(269, 26);
            this.ButtonAgregar.Name = "ButtonAgregar";
            this.ButtonAgregar.Size = new System.Drawing.Size(58, 23);
            this.ButtonAgregar.TabIndex = 1;
            this.ButtonAgregar.Text = "Agregar";
            this.ButtonAgregar.UseVisualStyleBackColor = true;
            this.ButtonAgregar.Click += new System.EventHandler(this.ButtonAgregar_Click);
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(15, 31);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(100, 13);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Agrege Comentario:";
            // 
            // TextBoxAgregarComentario
            // 
            this.TextBoxAgregarComentario.Location = new System.Drawing.Point(18, 51);
            this.TextBoxAgregarComentario.Multiline = true;
            this.TextBoxAgregarComentario.Name = "TextBoxAgregarComentario";
            this.TextBoxAgregarComentario.Size = new System.Drawing.Size(309, 93);
            this.TextBoxAgregarComentario.TabIndex = 0;
            // 
            // ButtonAtras
            // 
            this.ButtonAtras.Location = new System.Drawing.Point(281, 356);
            this.ButtonAtras.Name = "ButtonAtras";
            this.ButtonAtras.Size = new System.Drawing.Size(58, 23);
            this.ButtonAtras.TabIndex = 1;
            this.ButtonAtras.Text = "Atras";
            this.ButtonAtras.UseVisualStyleBackColor = true;
            this.ButtonAtras.Click += new System.EventHandler(this.ButtonAtras_Click);
            // 
            // MemberComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 385);
            this.Controls.Add(this.ButtonAtras);
            this.Controls.Add(this.groupBox1);
            this.Name = "MemberComments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comentarios";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewComentarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonBorrar;
        private System.Windows.Forms.DataGridView DataGridViewComentarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox TextBoxAgregarComentario;
        private System.Windows.Forms.Button ButtonVerComentarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxVerComentario;
        private System.Windows.Forms.Button ButtonAgregar;
        private System.Windows.Forms.Button ButtonAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.TextBox TextBoxIdBorrar;
    }
}