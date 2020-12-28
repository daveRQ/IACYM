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
    public partial class MemberFindPaternal : Form
    {
        private string Apellido;
        public MemberFindPaternal(string ap)
        {
            InitializeComponent();
            this.Apellido = ap;

            TextBoxCodigo.ForeColor = SystemColors.GrayText;
            TextBoxCodigo.Text = "Ingrese Código";
            this.TextBoxCodigo.Leave += new System.EventHandler(this.TextBoxCodigo_Leave);
            this.TextBoxCodigo.Enter += new System.EventHandler(this.TextBoxCodigo_Enter);


            string str_consult = "SELECT codigo, nombre, ap_paterno, ap_materno FROM miembro WHERE ap_paterno = '" + this.Apellido + "';";

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

            LabelTotal.Text = (DataGridViewMiembros.Rows.Count - 1).ToString();

        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonVerDatos_Click(object sender, EventArgs e)
        {
            bool check = true;
            string codigo = TextBoxCodigo.Text;
            if (!EvaluateTextBox.EIntPositive(codigo, true, "Codigo"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", codigo))
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
                TextBoxCodigo.Text = "Ingrese Código";
                TextBoxCodigo.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxCodigo_Enter(object sender, EventArgs e)
        {
            if (TextBoxCodigo.Text == "Ingrese Código")
            {
                TextBoxCodigo.Text = "";
                TextBoxCodigo.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
