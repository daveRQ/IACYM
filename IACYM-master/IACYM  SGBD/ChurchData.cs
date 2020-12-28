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
    public partial class ChurchData : Form
    {
        public ChurchData()
        {
            InitializeComponent();

            SqlConnection connexion = new SqlConnection(General_Values.str_connection);
            connexion.Open();

            string cadena = "SELECT * FROM iglesia WHERE id = 1";
            SqlCommand comando = new SqlCommand(cadena, connexion);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                BoxId.Text = registros["id"].ToString();
                BoxPais.Text = registros["pais"].ToString();
                BoxDepartamento.Text = registros["departamento"].ToString();
                BoxProvincia.Text = registros["provincia"].ToString();
                BoxDistrito.Text = registros["distrito"].ToString();
                BoxDireccion.Text = registros["direccion"].ToString();
                BoxNombre.Text = registros["nombre"].ToString();
                BoxTelefono.Text = registros["telefono"].ToString();
            }

            connexion.Close();
        }

        private void ButtonBehind_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
