using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using IACYM__SGBD.Class;

namespace IACYM__SGBD
{
    public partial class MemberShow : Form
    {
        private int code;

        public MemberShow(int codigo)
        {
            InitializeComponent();
            this.code = codigo;
            RefreshPersonal();
        }

        private void RefreshPersonal()
        {
            SqlConnection connection = new SqlConnection(General_Values.str_connection);

            connection.Open();
            string str_consult = "SELECT * FROM miembro WHERE codigo = " + code + ";";
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();
            if (record.Read())
            {
                TextLabelCodigo.Text = record["codigo"].ToString();
                TextLabelNombres.Text = record["nombre"].ToString();
                TextLabelApellidos.Text = record["ap_paterno"].ToString() + " " + record["ap_materno"].ToString();
                TextLabelDni.Text = record["dni"].ToString();

                //  0 = soltero    1 = casado    2 = viudo    3 = divorciado
                int e_civil = int.Parse(record["estado_civil"].ToString());
                if (e_civil == 0)
                    TextLabelEstadoCivil.Text = "Soltero";
                else if (e_civil == 1)
                    TextLabelEstadoCivil.Text = "Casado";
                else if (e_civil == 2)
                    TextLabelEstadoCivil.Text = "Viudo";
                else if (e_civil == 3)
                    TextLabelEstadoCivil.Text = "Divorciado";

                TextLabelProvincia.Text = record["provincia"].ToString();
                TextLabelDistrito.Text = record["distrito"].ToString();
                TextLabelDireccion.Text = record["direccion"].ToString();
                TextLabelReferencia.Text = record["referencia"].ToString();

                // 0 = hombre    1 = mujer
                bool sexo = bool.Parse(record["sexo"].ToString());
                if (sexo == false)
                    TextLabelSexo.Text = "Hombre";
                else if (sexo == true)
                    TextLabelSexo.Text = "Mujer";

                TextLabelCelular.Text = record["celular"].ToString();
                TextLabelTelefono.Text = record["telefono"].ToString();
                TextLabelEmail.Text = record["email"].ToString();
                TextLabelEstudios.Text = record["estudios"].ToString();

                DateTimeNacimiento.Text = record["fch_nacimiento"].ToString();

                DateTimeBautismo.Text = record["fch_bautismo"].ToString();

                bool estado = bool.Parse(record["activo"].ToString());
                if (estado == false)
                    LabelEstado.Text = "No Activo";
                else if (estado == true)
                    LabelEstado.Text = "Activo";

                try
                {
                    byte[] datos = (byte[])record["foto"];
                    PictureBoxFoto.Image = Photo.Bytes_To_Image(datos);
                }
                catch
                {

                }

            }
            connection.Close();


            connection.Open();
            string str_consult2 = "SELECT V.vinculo, V.cod_vinculo, M.nombre, M.ap_paterno, M.ap_materno FROM vinculo V " +
                "JOIN miembro M ON M.codigo = V.cod_vinculo WHERE V.cod_miembro = " + this.code + ";";
            //string str_consult2 = "SELECT vinculo, cod_vinculo FROM vinculo WHERE cod_miembro = " + this.code + ";";
            SqlCommand consult2 = new SqlCommand(str_consult2, connection);
            SqlDataReader record2 = consult2.ExecuteReader();
            DataGridViewFamilia.Rows.Clear();
            while (record2.Read())
            {
                int n = DataGridViewFamilia.Rows.Add();
                DataGridViewFamilia.Rows[n].Cells[0].Value = record2["cod_vinculo"];
                int int_vin = int.Parse(record2["vinculo"].ToString());
                string str_vin = "";
                switch (int_vin)
                {
                    case 0:
                        str_vin = "Conyuge";
                        break;
                    case 1:
                        str_vin = "Padre";
                        break;
                    case 2:
                        str_vin = "Madre";
                        break;
                    case 3:
                        str_vin = "Hijo";
                        break;
                    case 4:
                        str_vin = "Hija";
                        break;
                    case 5:
                        str_vin = "Hermano";
                        break;
                    case 6:
                        str_vin = "Hermana";
                        break;
                    case 7:
                        str_vin = "Abuelo";
                        break;
                    case 8:
                        str_vin = "Abuela";
                        break;
                    case 9:
                        str_vin = "Nieto";
                        break;
                    case 10:
                        str_vin = "Nieta";
                        break;
                    case 11:
                        str_vin = "Tío";
                        break;
                    case 12:
                        str_vin = "Tía";
                        break;
                    case 13:
                        str_vin = "Sobrino";
                        break;
                    case 14:
                        str_vin = "Sobrina";
                        break;
                    case 15:
                        str_vin = "Primo";
                        break;
                    case 16:
                        str_vin = "Prima";
                        break;
                    case 17:
                        str_vin = "Padrastro";
                        break;
                    case 18:
                        str_vin = "Madrastra";
                        break;
                    case 19:
                        str_vin = "Hijastro";
                        break;
                    case 20:
                        str_vin = "Hijastra";
                        break;
                    case 21:
                        str_vin = "Hermanastro";
                        break;
                    case 22:
                        str_vin = "Hermanastra";
                        break;
                }
                DataGridViewFamilia.Rows[n].Cells[1].Value = str_vin;
                DataGridViewFamilia.Rows[n].Cells[2].Value = record2["nombre"].ToString() + " " + record2["ap_paterno"].ToString() + " " + record2["ap_materno"].ToString();
            }

            connection.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonModificar_Click(object sender, EventArgs e)
        {
            MemberUpdate M_U = new MemberUpdate(this.code);
            M_U.ShowDialog();
            this.RefreshPersonal();
        }

        private void ButtonComentarios_Click(object sender, EventArgs e)
        {
            CheckToComments C_T_C = new CheckToComments(this.code);
            C_T_C.ShowDialog();
        }

        private void ButtonOfrendaMisionera_Click(object sender, EventArgs e)
        {
            MemberShowMissionaryOfferingAll M_S_M_O_A = new MemberShowMissionaryOfferingAll(this.code);
            M_S_M_O_A.ShowDialog();
        }

        private void ButtonOfrendaProTemplo_Click(object sender, EventArgs e)
        {
            MemberShowProTempleOfferingAll M_S_P_T_O_A = new MemberShowProTempleOfferingAll(this.code);
            M_S_P_T_O_A.ShowDialog();
        }

        private void ButtonDiezmos_Click(object sender, EventArgs e)
        {
            MemberShowTitheAll M_S_T_A = new MemberShowTitheAll(this.code);
            M_S_T_A.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MemberAddLink M_A_L = new MemberAddLink(this.code);
            M_A_L.ShowDialog();

            RefreshPersonal();
        }
    }
}
