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
    public partial class MemberShowMissionaryOfferingAll : Form
    {
        private int Code;
        public MemberShowMissionaryOfferingAll(int codigo)
        {
            InitializeComponent();
            this.Code = codigo;

            TextBoxBuscarMes.ForeColor = SystemColors.GrayText;
            TextBoxBuscarMes.Text = "Ingrese Mes";
            this.TextBoxBuscarMes.Leave += new System.EventHandler(this.TextBoxBuscarMes_Leave);
            this.TextBoxBuscarMes.Enter += new System.EventHandler(this.TextBoxBuscarMes_Enter);

            TextBoxBuscarAño.ForeColor = SystemColors.GrayText;
            TextBoxBuscarAño.Text = "Ingrese Año";
            this.TextBoxBuscarAño.Leave += new System.EventHandler(this.TextBoxBuscarAño_Leave);
            this.TextBoxBuscarAño.Enter += new System.EventHandler(this.TextBoxBuscarAño_Enter);

            TextBoxIdEliminar.ForeColor = SystemColors.GrayText;
            TextBoxIdEliminar.Text = "Ingrese Id";
            this.TextBoxIdEliminar.Leave += new System.EventHandler(this.TextBoxIdEliminar_Leave);
            this.TextBoxIdEliminar.Enter += new System.EventHandler(this.TextBoxIdEliminar_Enter);


            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            string str_consult = "SELECT codigo, nombre, ap_paterno, ap_materno FROM miembro WHERE codigo = " + this.Code + ";";

            connection.Open();
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();

            if (record.Read())
            {
                LabelNombreMiembro.Text = record["nombre"].ToString() + " " + record["ap_paterno"].ToString() + " " + record["ap_materno"].ToString();
                LabelCodigo.Text = record["codigo"].ToString();
            }
            connection.Close();
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonTodoDiezmos_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            string str_consult = "SELECT * FROM ofrenda_misionera WHERE cod_miembro = " + this.Code + ";";

            connection.Open();
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();

            decimal total = 0;
            DataGridViewDiezmos.Rows.Clear();

            while (record.Read())
            {
                int n = DataGridViewDiezmos.Rows.Add();
                DataGridViewDiezmos.Rows[n].Cells[0].Value = record["id"];
                DataGridViewDiezmos.Rows[n].Cells[1].Value = record["año"];
                DataGridViewDiezmos.Rows[n].Cells[2].Value = record["mes"];

                total += decimal.Parse(record["monto"].ToString());
                DataGridViewDiezmos.Rows[n].Cells[3].Value = record["monto"];

                DateTime temp = DateTime.Parse(record["fch_emision"].ToString());
                DataGridViewDiezmos.Rows[n].Cells[4].Value = temp.Day.ToString() + "/" + temp.Month.ToString() + "/" + temp.Year.ToString();
            }
            LabelTotal.Text = total.ToString();
            LabelCantidad.Text = (DataGridViewDiezmos.Rows.Count - 1).ToString();

            if ((DataGridViewDiezmos.Rows.Count - 1) == 0)
                MessageBox.Show("No hay Datos registrados");

            connection.Close();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            bool check = true;
            // Buscar solo por Mes
            if (TextBoxBuscarMes.Text != "Ingrese Mes" && TextBoxBuscarAño.Text == "Ingrese Año")
            {
                string mes = TextBoxBuscarMes.Text;
                if (!EvaluateTextBox.EMounth(mes, true, "Mes"))
                    check = false;
                if (check)
                {
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT * FROM ofrenda_misionera WHERE mes = '" + mes + "' AND cod_miembro = " + this.Code + ";";
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();

                    decimal total = 0;
                    DataGridViewDiezmos.Rows.Clear();
                    while (record.Read())
                    {
                        int n = DataGridViewDiezmos.Rows.Add();
                        DataGridViewDiezmos.Rows[n].Cells[0].Value = record["id"];
                        DataGridViewDiezmos.Rows[n].Cells[1].Value = record["año"];
                        DataGridViewDiezmos.Rows[n].Cells[2].Value = record["mes"];

                        total += decimal.Parse(record["monto"].ToString());
                        DataGridViewDiezmos.Rows[n].Cells[3].Value = record["monto"];

                        DateTime temp = DateTime.Parse(record["fch_emision"].ToString());
                        DataGridViewDiezmos.Rows[n].Cells[4].Value = temp.Day.ToString() + "/" + temp.Month.ToString() + "/" + temp.Year.ToString();
                    }

                    LabelTotal.Text = total.ToString();
                    LabelCantidad.Text = (DataGridViewDiezmos.Rows.Count - 1).ToString();

                    if ((DataGridViewDiezmos.Rows.Count - 1) == 0)
                        MessageBox.Show("No hay Datos registrados");

                    connection.Close();
                }
            }
            // Buscar solo por Año
            else if (TextBoxBuscarMes.Text == "Ingrese Mes" && TextBoxBuscarAño.Text != "Ingrese Año")
            {
                string año = TextBoxBuscarAño.Text;
                if (!EvaluateTextBox.EYear(año, true, "Año"))
                    check = false;
                if (check)
                {
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT * FROM ofrenda_misionera WHERE año = '" + año + "' AND cod_miembro = " + this.Code + ";";

                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();
                    decimal total = 0;
                    DataGridViewDiezmos.Rows.Clear();

                    while (record.Read())
                    {
                        int n = DataGridViewDiezmos.Rows.Add();
                        DataGridViewDiezmos.Rows[n].Cells[0].Value = record["id"];
                        DataGridViewDiezmos.Rows[n].Cells[1].Value = record["año"];
                        DataGridViewDiezmos.Rows[n].Cells[2].Value = record["mes"];

                        total += decimal.Parse(record["monto"].ToString());
                        DataGridViewDiezmos.Rows[n].Cells[3].Value = record["monto"];

                        DateTime temp = DateTime.Parse(record["fch_emision"].ToString());
                        DataGridViewDiezmos.Rows[n].Cells[4].Value = temp.Day.ToString() + "/" + temp.Month.ToString() + "/" + temp.Year.ToString();
                    }

                    LabelTotal.Text = total.ToString();
                    LabelCantidad.Text = (DataGridViewDiezmos.Rows.Count - 1).ToString();

                    if ((DataGridViewDiezmos.Rows.Count - 1) == 0)
                        MessageBox.Show("No hay Datos registrados");

                    connection.Close();
                }
            }
            // Buscar por Mes y Año
            else if (TextBoxBuscarMes.Text != "Ingrese Mes" && TextBoxBuscarAño.Text != "Ingrese Año")
            {
                string mes = TextBoxBuscarMes.Text;
                if (!EvaluateTextBox.EMounth(mes, true, "Mes"))
                    check = false;
                string año = TextBoxBuscarAño.Text;
                if (!EvaluateTextBox.EYear(año, true, "Año"))
                    check = false;
                if (check)
                {
                    SqlConnection connection = new SqlConnection(General_Values.str_connection);
                    connection.Open();
                    string str_consult = "SELECT * FROM ofrenda_misionera WHERE mes = '" + mes + "' AND cod_miembro = " + this.Code + ";";
                    SqlCommand consult = new SqlCommand(str_consult, connection);
                    SqlDataReader record = consult.ExecuteReader();

                    decimal total = 0;
                    DataGridViewDiezmos.Rows.Clear();
                    
                    while (record.Read())
                    {
                        int n = DataGridViewDiezmos.Rows.Add();
                        DataGridViewDiezmos.Rows[n].Cells[0].Value = record["id"];
                        DataGridViewDiezmos.Rows[n].Cells[1].Value = record["año"];
                        DataGridViewDiezmos.Rows[n].Cells[2].Value = record["mes"];

                        total += decimal.Parse(record["monto"].ToString());
                        DataGridViewDiezmos.Rows[n].Cells[3].Value = record["monto"];

                        DateTime temp = DateTime.Parse(record["fch_emision"].ToString());
                        DataGridViewDiezmos.Rows[n].Cells[4].Value = temp.Day.ToString() + "/" + temp.Month.ToString() + "/" + temp.Year.ToString();
                    }

                    LabelTotal.Text = total.ToString();
                    LabelCantidad.Text = (DataGridViewDiezmos.Rows.Count - 1).ToString();

                    if ((DataGridViewDiezmos.Rows.Count - 1) == 0)
                        MessageBox.Show("No hay Datos registrados");

                    connection.Close();
                }
            }
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            bool check = true;

            string id = TextBoxIdEliminar.Text;
            if (!EvaluateTextBox.EIntPositive(id, true, "ID"))
                check = false;

            else if (!Id.ExistsId("ofrenda_misionera", "id", id))
                check = false;

            if (check)
            {
                Id.DeleteId("ofrenda_misionera", "id", int.Parse(id));
                MessageBox.Show("Borrado Completo");
                DataGridViewDiezmos.Rows.Clear();
            }
        }

        // MEtodos LEAVE and ENTER
        private void TextBoxBuscarMes_Leave(object sender, EventArgs e)
        {
            if (TextBoxBuscarMes.Text.Length == 0)
            {
                TextBoxBuscarMes.Text = "Ingrese Mes";
                TextBoxBuscarMes.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxBuscarMes_Enter(object sender, EventArgs e)
        {
            if (TextBoxBuscarMes.Text == "Ingrese Mes")
            {
                TextBoxBuscarMes.Text = "";
                TextBoxBuscarMes.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBoxBuscarAño_Leave(object sender, EventArgs e)
        {
            if (TextBoxBuscarAño.Text.Length == 0)
            {
                TextBoxBuscarAño.Text = "Ingrese Año";
                TextBoxBuscarAño.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxBuscarAño_Enter(object sender, EventArgs e)
        {
            if (TextBoxBuscarAño.Text == "Ingrese Año")
            {
                TextBoxBuscarAño.Text = "";
                TextBoxBuscarAño.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBoxIdEliminar_Leave(object sender, EventArgs e)
        {
            if (TextBoxIdEliminar.Text.Length == 0)
            {
                TextBoxIdEliminar.Text = "Ingrese Id";
                TextBoxIdEliminar.ForeColor = SystemColors.GrayText;
            }
        }

        private void TextBoxIdEliminar_Enter(object sender, EventArgs e)
        {
            if (TextBoxIdEliminar.Text == "Ingrese Id")
            {
                TextBoxIdEliminar.Text = "";
                TextBoxIdEliminar.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
