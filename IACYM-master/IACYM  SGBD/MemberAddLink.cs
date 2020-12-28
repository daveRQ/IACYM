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

//                  conyuge_f = 0;      padre = 1;          madre = 2;          hijo = 3;           hija = 4; 
// hermano = 5;     hermana = 6;        abuelo = 7;         abuela= 8;          nieto = 9;          nieta = 10;
// tio = 11;        tia = 12;           sobrino = 13;       sobrina = 14;       primo = 15;         prima = 16;
// padrastro = 17;  madrastra = 18;     hijastro = 19;      hijastra = 20;      hermanastro = 21;   hermanastra = 22;

namespace IACYM__SGBD
{
    public partial class MemberAddLink : Form
    {
        private int Code;
        public MemberAddLink(int Codigo)
        {
            this.Code = Codigo;
            InitializeComponent();
            RefreshPersonal();
        }

        private void RefreshPersonal()
        {
            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            connection.Open();


            string str_consult = "SELECT V.vinculo, V.cod_vinculo, M.nombre, M.ap_paterno, M.ap_materno FROM vinculo V " +
                "JOIN miembro M ON M.codigo = V.cod_vinculo WHERE V.cod_miembro = " + this.Code + ";";

            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();

            DataGridViewFamilia.Rows.Clear();

            while (record.Read())
            {
                int n = DataGridViewFamilia.Rows.Add();
                DataGridViewFamilia.Rows[n].Cells[0].Value = record["cod_vinculo"];

                int int_vin = int.Parse(record["vinculo"].ToString());
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
                DataGridViewFamilia.Rows[n].Cells[2].Value = record["nombre"].ToString() + " " + record["ap_paterno"].ToString() + " " + record["ap_materno"].ToString();
            }

            connection.Close();
        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonBuscarMiembro_Click(object sender, EventArgs e)
        {
            bool check = true;
            string cad = TextBoxBuscarMiembro.Text;

            if (!EvaluateTextBox.EString(cad, 10, true, "Apellido"))
                check = false;
            
            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);
                connection.Open();
                string str_consult = "SELECT codigo, nombre, ap_paterno, ap_materno FROM miembro WHERE ap_paterno = '" + cad + "';";

                SqlCommand consult = new SqlCommand(str_consult, connection);

                SqlDataReader record = consult.ExecuteReader();

                while (record.Read())
                {
                    int n = DataGridViewBuscar.Rows.Add();

                    DataGridViewBuscar.Rows[n].Cells[0].Value = record["codigo"];
                    DataGridViewBuscar.Rows[n].Cells[1].Value = record["nombre"].ToString() + " " + record["ap_paterno"].ToString() +
                                                                " " + record["ap_materno"].ToString();
                }

                connection.Close();
            }

        }

        private void ButtonBorrarFamiliar_Click(object sender, EventArgs e)
        {
            bool check = true;

            string id = TextBoxCodigo.Text;

            if (!EvaluateTextBox.EIntPositive(id, true, "id"))
                check = false;
            
            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);

                connection.Open();
                string str_consult = "DELETE FROM vinculo WHERE cod_miembro = " + this.Code + " AND cod_vinculo = " + id + ";";
                SqlCommand consult = new SqlCommand(str_consult, connection);
                consult.ExecuteNonQuery();
                connection.Close();


                connection.Open();
                string str_consult1 = "DELETE FROM vinculo WHERE cod_miembro = " + id + " AND cod_vinculo = " + this.Code + ";";
                SqlCommand consult1 = new SqlCommand(str_consult1, connection);
                consult1.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Se borro Satisfactoriamnte");

                RefreshPersonal();
            }
        }

        private void ButtonAgregarConyuge_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin = 0;

            string cod_vinculo = (TextBoxConyuge.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }

            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);

                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();

                id += 1;
                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }
        }

        private void ButtonAgregarPadre_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin;

            string cod_vinculo = (TextBoxPadre.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }


            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);
                if (IsMale(int.Parse(cod_vinculo)))
                    vin = 1;
                else
                    vin = 2;
                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();


                id += 1;
                if (IsMale(Code))
                    vin = 3;
                else
                    vin = 4;
                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }
        }

        private void ButtonAgregarHijo_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin;

            string cod_vinculo = (TextBoxHijo.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }


            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);

                if (IsMale(int.Parse(cod_vinculo)))
                    vin = 3;
                else
                    vin = 4;

                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();


                id += 1;
                if (IsMale(Code))
                    vin = 1;
                else
                    vin = 2;

                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }
        }

        private void ButtonAgregarHermano_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin;
            string cod_vinculo = (TextBoxHermano.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }


            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);

                if (IsMale(int.Parse(cod_vinculo)))
                    vin = 5;
                else
                    vin = 6;
                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();


                id += 1;
                if (IsMale(Code))
                    vin = 5;
                else
                    vin = 6;
                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }            
        }

        private void ButtonAgregarAbuelo_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin;
            string cod_vinculo = (TextBoxAbuelo.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }


            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);

                if (IsMale(int.Parse(cod_vinculo)))
                    vin = 7;
                else
                    vin = 8;
                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();


                id += 1;
                if (IsMale(Code))
                    vin = 9;
                else
                    vin = 10;
                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }


        }

        private void ButtonAgregarNieto_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin;

            string cod_vinculo = (TextBoxNieto.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }

            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);
                if (IsMale(int.Parse(cod_vinculo)))
                    vin = 9;
                else
                    vin = 10;
                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();


                id += 1;
                if (IsMale(Code))
                    vin = 7;
                else
                    vin = 8;
                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }
        }

        private void ButtonAgregarTio_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin;
            string cod_vinculo = (TextBoxTio.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }

            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);
                if (IsMale(int.Parse(cod_vinculo)))
                    vin = 11;
                else
                    vin = 12;
                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();


                id += 1;
                if (IsMale(Code))
                    vin = 13;
                else
                    vin = 14;
                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }

        }

        private void ButtonAgregarSobrino_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin;
            string cod_vinculo = (TextBoxSobrino.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }


            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);
                if (IsMale(int.Parse(cod_vinculo)))
                    vin = 13;
                else
                    vin = 14;
                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();


                id += 1;
                if (IsMale(Code))
                    vin = 11;
                else
                    vin = 12;
                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }

        }

        private void ButtonAgregarPrimo_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin;
            string cod_vinculo = (TextBoxPrimo.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }

            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);
                if (IsMale(int.Parse(cod_vinculo)))
                    vin = 15;
                else
                    vin = 16;
                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();


                id += 1;
                if (IsMale(Code))
                    vin = 15;
                else
                    vin = 16;
                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }

        }

        private void ButtonAgregarPadrastro_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin;
            string cod_vinculo = (TextBoxPadrastro.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }

            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);
                if (IsMale(int.Parse(cod_vinculo)))
                    vin = 17;
                else
                    vin = 18;
                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();


                id += 1;
                if (IsMale(Code))
                    vin = 19;
                else
                    vin = 20;
                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }

            
        }

        private void ButtonAgregarHijastro_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin;
            string cod_vinculo = (TextBoxHijastro.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }

            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);
                if (IsMale(int.Parse(cod_vinculo)))
                    vin = 19;
                else
                    vin = 20;
                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();


                id += 1;
                if (IsMale(Code))
                    vin = 17;
                else
                    vin = 18;
                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }

        }

        private void ButtonAgregarHermanastro_Click(object sender, EventArgs e)
        {
            bool check = true;

            int id = Value_id();
            int vin;
            string cod_vinculo = (TextBoxHermanastro.Text);
            if (!EvaluateTextBox.EIntPositive(cod_vinculo, true, "Codigo Vinculo Conyuge"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", cod_vinculo))
            {
                MessageBox.Show("No existe ID");
                check = false;
            }

            if (check)
            {
                SqlConnection connection = new SqlConnection(General_Values.str_connection);
                if (IsMale(int.Parse(cod_vinculo)))
                    vin = 21;
                else
                    vin = 22;
                connection.Open();
                string str_consult2 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + cod_vinculo + ", " + this.Code + ")";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                consult2.ExecuteNonQuery();
                connection.Close();


                id += 1;
                if (IsMale(Code))
                    vin = 21;
                else
                    vin = 22;
                connection.Open();
                string str_consult3 = "INSERT INTO vinculo(id, vinculo, cod_vinculo, cod_miembro) VALUES(" +
                                    id + ", " + vin + ", " + this.Code + ", " + cod_vinculo + ")";
                SqlCommand consult3 = new SqlCommand(str_consult3, connection);
                consult3.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("Vinculo Agregado Satisfactoriamente");
                RefreshPersonal();
            }

        }

        // METODOS
        private int Value_id()
        {
            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            connection.Open();
            string str_consult = "SELECT COUNT(id) AS maximo FROM vinculo";
            SqlCommand consult = new SqlCommand(str_consult, connection);

            int id = 1;
            SqlDataReader record = consult.ExecuteReader();
            while (record.Read())
            {
                id = int.Parse(record["maximo"].ToString());
            }
            connection.Close();

            if (id > 0)
            {
                connection.Open();
                string str_consult2 = "SELECT MAX(id) AS maximo FROM vinculo";
                SqlCommand consult2 = new SqlCommand(str_consult2, connection);
                SqlDataReader record2 = consult2.ExecuteReader();

                while (record2.Read())
                {
                    id = int.Parse(record2["maximo"].ToString()) + 1;
                }
                connection.Close();
            }
            else
                id = 1;

            return id;
        }

        private bool IsMale(int codigo)
        {
            bool male = false;
            SqlConnection connection = new SqlConnection(General_Values.str_connection);
            connection.Open();
            string str_consult = "SELECT sexo FROM miembro WHERE codigo = " + codigo + ";";
            SqlCommand consult = new SqlCommand(str_consult, connection);
            SqlDataReader record = consult.ExecuteReader();
            while (record.Read())
            {
                if (bool.Parse(record["sexo"].ToString()) == false)
                    male = true;
            }
            connection.Close();
            return male;
        }
    }
}
