using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using IACYM__SGBD.Class;

namespace IACYM__SGBD
{
    public partial class MemberShowAll : Form
    {
        public MemberShowAll()
        {
            InitializeComponent();
            IniciandoTodo();

            TextBoxCodigo.ForeColor = SystemColors.GrayText;
            TextBoxCodigo.Text = "Ingrese Codigo";
            this.TextBoxCodigo.Leave += new System.EventHandler(this.TextBoxCodigo_Leave);
            this.TextBoxCodigo.Enter += new System.EventHandler(this.TextBoxCodigo_Enter);
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBoxVerTodo_Click(object sender, EventArgs e)
        {
            IniciandoTodo();
        }

        private void IniciandoTodo()
        {
            CheckBoxVerTodo.Checked = true;
            CheckBoxVerActivos.Checked = false;
            CheckBoxVerInactivos.Checked = false;


            string str_consult = "SELECT codigo, nombre, ap_paterno, ap_materno FROM miembro";

            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            connection.Open();
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();
            DataGridViewMiembros.Rows.Clear();
            while (record.Read())
            {
                int n = DataGridViewMiembros.Rows.Add();
                DataGridViewMiembros.Rows[n].Cells[0].Value = record["codigo"];
                DataGridViewMiembros.Rows[n].Cells[1].Value = record["nombre"];
                DataGridViewMiembros.Rows[n].Cells[2].Value = record["ap_paterno"];
                DataGridViewMiembros.Rows[n].Cells[3].Value = record["ap_materno"];
            }
            connection.Close();

            LabelNumero.Text = (DataGridViewMiembros.Rows.Count - 1).ToString();
        }

        private void CheckBoxVerActivos_Click(object sender, EventArgs e)
        {
            CheckBoxVerTodo.Checked = false;
            CheckBoxVerActivos.Checked = true;
            CheckBoxVerInactivos.Checked = false;


            string str_consult = "SELECT codigo, nombre, ap_paterno, ap_materno FROM miembro WHERE activo = 'true';";

            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            connection.Open();
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();
            DataGridViewMiembros.Rows.Clear();
            while (record.Read())
            {
                int n = DataGridViewMiembros.Rows.Add();
                DataGridViewMiembros.Rows[n].Cells[0].Value = record["codigo"];
                DataGridViewMiembros.Rows[n].Cells[1].Value = record["nombre"];
                DataGridViewMiembros.Rows[n].Cells[2].Value = record["ap_paterno"];
                DataGridViewMiembros.Rows[n].Cells[3].Value = record["ap_materno"];
            }
            connection.Close();

            LabelNumero.Text = (DataGridViewMiembros.Rows.Count - 1).ToString();
        }

        private void CheckBoxVerInactivos_Click(object sender, EventArgs e)
        {
            CheckBoxVerTodo.Checked = false;
            CheckBoxVerActivos.Checked = false;
            CheckBoxVerInactivos.Checked = true;


            string str_consult = "SELECT codigo, nombre, ap_paterno, ap_materno FROM miembro WHERE activo = 'false'";

            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            connection.Open();
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();
            DataGridViewMiembros.Rows.Clear();
            while (record.Read())
            {
                int n = DataGridViewMiembros.Rows.Add();
                DataGridViewMiembros.Rows[n].Cells[0].Value = record["codigo"];
                DataGridViewMiembros.Rows[n].Cells[1].Value = record["nombre"];
                DataGridViewMiembros.Rows[n].Cells[2].Value = record["ap_paterno"];
                DataGridViewMiembros.Rows[n].Cells[3].Value = record["ap_materno"];
            }
            connection.Close();

            LabelNumero.Text = (DataGridViewMiembros.Rows.Count - 1).ToString();
        }

        private void ButtonVerDatos_Click(object sender, EventArgs e)
        {
            bool check = true;
            string codigo = TextBoxCodigo.Text;
            if (!EvaluateTextBox.EIntPositive(codigo, true, "Codigo"))
                check = false;
            if (!Id.ExistsId("miembro", "codigo", codigo))
                check = false;

            if (check)
            {
                MemberShow M_S = new MemberShow(int.Parse(codigo));
                M_S.ShowDialog();
            }
        }

        // Metodos LEAVE and ENTER
        private void TextBoxCodigo_Leave(object sender, EventArgs e)
        {
            if (TextBoxCodigo.Text.Length == 0)
            {
                TextBoxCodigo.Text = "Ingrese Codigo";
                TextBoxCodigo.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxCodigo_Enter(object sender, EventArgs e)
        {
            if (TextBoxCodigo.Text == "Ingrese Codigo")
            {
                TextBoxCodigo.Text = "";
                TextBoxCodigo.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
