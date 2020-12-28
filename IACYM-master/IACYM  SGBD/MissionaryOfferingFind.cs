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
    public partial class MissionaryOfferingFind : Form
    {
        public MissionaryOfferingFind()
        {
            InitializeComponent();
            TextBoxMes.ForeColor = SystemColors.GrayText;
            TextBoxMes.Text = "Ingrese Mes";
            this.TextBoxMes.Leave += new System.EventHandler(this.TextBoxMes_Leave);
            this.TextBoxMes.Enter += new System.EventHandler(this.TextBoxMes_Enter);

            TextBoxAño.ForeColor = SystemColors.GrayText;
            TextBoxAño.Text = "Ingrese Año";
            this.TextBoxAño.Leave += new System.EventHandler(this.TextBoxAño_Leave);
            this.TextBoxAño.Enter += new System.EventHandler(this.TextBoxAño_Enter);
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            bool check = true;
            // Buscar solo por Mes
            if (TextBoxMes.Text != "Ingrese Mes" && TextBoxAño.Text == "Ingrese Año")
            {
                string mes = TextBoxMes.Text;
                if (!EvaluateTextBox.EMounth(mes, true, "Mes"))
                    check = false;
                if (check)
                {
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT P.cod_miembro, M.nombre, M.ap_paterno, M.ap_materno, P.año, P.mes, P.monto, P.fch_emision " +
                                        "FROM ofrenda_misionera P JOIN miembro M ON P.cod_miembro = M.codigo WHERE P.mes = '" + mes + "';";
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();
                    DataGridViewOfrendaMisionera.Rows.Clear();
                    while (record.Read())
                    {
                        int n = DataGridViewOfrendaMisionera.Rows.Add();
                        DataGridViewOfrendaMisionera.Rows[n].Cells[0].Value = record["cod_miembro"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[1].Value = record["nombre"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[2].Value = record["ap_paterno"].ToString() + " " + record["ap_materno"].ToString();
                        DataGridViewOfrendaMisionera.Rows[n].Cells[3].Value = record["año"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[4].Value = record["mes"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[5].Value = record["monto"];

                        DateTime temp = DateTime.Parse(record["fch_emision"].ToString());
                        DataGridViewOfrendaMisionera.Rows[n].Cells[6].Value = temp.Day.ToString() + "/" + temp.Month.ToString() + "/" + temp.Year.ToString();
                    }
                    connection.Close();
                }
            }
            // Buscar solo por Año
            else if (TextBoxMes.Text == "Ingrese Mes" && TextBoxAño.Text != "Ingrese Año")
            {
                string año = TextBoxAño.Text;
                if (!EvaluateTextBox.EYear(año, true, "Año"))
                    check = false;
                if (check)
                {
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT P.cod_miembro, M.nombre, M.ap_paterno, M.ap_materno, P.año, P.mes, P.monto, P.fch_emision " +
                                        "FROM ofrenda_misionera P JOIN miembro M ON P.cod_miembro = M.codigo WHERE P.año = '" + año + "';";
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();
                    DataGridViewOfrendaMisionera.Rows.Clear();
                    while (record.Read())
                    {
                        int n = DataGridViewOfrendaMisionera.Rows.Add();
                        DataGridViewOfrendaMisionera.Rows[n].Cells[0].Value = record["cod_miembro"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[1].Value = record["nombre"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[2].Value = record["ap_paterno"].ToString() + " " + record["ap_materno"].ToString();
                        DataGridViewOfrendaMisionera.Rows[n].Cells[3].Value = record["año"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[4].Value = record["mes"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[5].Value = record["monto"];

                        DateTime temp = DateTime.Parse(record["fch_emision"].ToString());
                        DataGridViewOfrendaMisionera.Rows[n].Cells[6].Value = temp.Day.ToString() + "/" + temp.Month.ToString() + "/" + temp.Year.ToString();
                    }
                    connection.Close();
                }
            }
            // Buscar solo por Mes y Año
            else if (TextBoxMes.Text != "Ingrese Mes" && TextBoxAño.Text != "Ingrese Año")
            {
                string mes = TextBoxMes.Text;
                if (!EvaluateTextBox.EMounth(mes, true, "Mes"))
                    check = false;
                string año = TextBoxAño.Text;
                if (!EvaluateTextBox.EYear(año, true, "Año"))
                    check = false;
                if (check)
                {
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT P.cod_miembro, M.nombre, M.ap_paterno, M.ap_materno, P.año, P.mes, P.monto, P.fch_emision " +
                                        "FROM ofrenda_misionera P JOIN miembro M ON P.cod_miembro = M.codigo WHERE P.año = '" + año + "' AND P.mes = '" + mes + "';";
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();
                    DataGridViewOfrendaMisionera.Rows.Clear();
                    while (record.Read())
                    {
                        int n = DataGridViewOfrendaMisionera.Rows.Add();
                        DataGridViewOfrendaMisionera.Rows[n].Cells[0].Value = record["cod_miembro"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[1].Value = record["nombre"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[2].Value = record["ap_paterno"].ToString() + " " + record["ap_materno"].ToString();
                        DataGridViewOfrendaMisionera.Rows[n].Cells[3].Value = record["año"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[4].Value = record["mes"];
                        DataGridViewOfrendaMisionera.Rows[n].Cells[5].Value = record["monto"];

                        DateTime temp = DateTime.Parse(record["fch_emision"].ToString());
                        DataGridViewOfrendaMisionera.Rows[n].Cells[6].Value = temp.Day.ToString() + "/" + temp.Month.ToString() + "/" + temp.Year.ToString();
                    }
                    connection.Close();
                }
            }

            sumar_ofrendas();
        }

        private void ButtonMostrarTodo_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            connection.Open();
            string str_consult = "SELECT P.cod_miembro, M.nombre, M.ap_paterno, M.ap_materno, P.año, P.mes, P.monto, P.fch_emision " +
                                "FROM ofrenda_misionera P JOIN miembro M ON P.cod_miembro = M.codigo;";
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();
            DataGridViewOfrendaMisionera.Rows.Clear();
            while (record.Read())
            {
                int n = DataGridViewOfrendaMisionera.Rows.Add();
                DataGridViewOfrendaMisionera.Rows[n].Cells[0].Value = record["cod_miembro"];
                DataGridViewOfrendaMisionera.Rows[n].Cells[1].Value = record["nombre"];
                DataGridViewOfrendaMisionera.Rows[n].Cells[2].Value = record["ap_paterno"].ToString() + " " + record["ap_materno"].ToString();
                DataGridViewOfrendaMisionera.Rows[n].Cells[3].Value = record["año"];
                DataGridViewOfrendaMisionera.Rows[n].Cells[4].Value = record["mes"];
                DataGridViewOfrendaMisionera.Rows[n].Cells[5].Value = record["monto"];

                DateTime temp = DateTime.Parse(record["fch_emision"].ToString());
                DataGridViewOfrendaMisionera.Rows[n].Cells[6].Value = temp.Day.ToString() + "/" + temp.Month.ToString() + "/" + temp.Year.ToString();
            }
            connection.Close();

            sumar_ofrendas();
        }

        private void sumar_ofrendas()
        {
            decimal total = 0;
            for (int i = 0; i < DataGridViewOfrendaMisionera.Rows.Count - 1; ++i)
                total += decimal.Parse(DataGridViewOfrendaMisionera.Rows[i].Cells[5].Value.ToString());

            LabelTotal.Text = total.ToString();
        }

        // Metodos LEAVE and ENTER
        private void TextBoxMes_Leave(object sender, EventArgs e)
        {
            if (TextBoxMes.Text.Length == 0)
            {
                TextBoxMes.Text = "Ingrese Mes";
                TextBoxMes.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxMes_Enter(object sender, EventArgs e)
        {
            if (TextBoxMes.Text == "Ingrese Mes")
            {
                TextBoxMes.Text = "";
                TextBoxMes.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBoxAño_Leave(object sender, EventArgs e)
        {
            if (TextBoxAño.Text.Length == 0)
            {
                TextBoxAño.Text = "Ingrese Año";
                TextBoxAño.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxAño_Enter(object sender, EventArgs e)
        {
            if (TextBoxAño.Text == "Ingrese Año")
            {
                TextBoxAño.Text = "";
                TextBoxAño.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
