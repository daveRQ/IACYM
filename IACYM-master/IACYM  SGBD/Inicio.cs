using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IACYM__SGBD.Class;

namespace IACYM__SGBD
{
    public partial class MainManage : Form
    {
        public MainManage()
        {
            InitializeComponent();
            TextBoxCodigo.ForeColor = SystemColors.GrayText;
            TextBoxCodigo.Text = "Ingrese Código";

            TextBoxName.ForeColor = SystemColors.GrayText;
            TextBoxName.Text = "Ingrese Nombre";

            TextBoxApellidoPaterno.ForeColor = SystemColors.GrayText;
            TextBoxApellidoPaterno.Text = "Ingrese Apellido";

            TextBoxMes.ForeColor = SystemColors.GrayText;
            TextBoxMes.Text = "Ingrese Mes";
        }

        private void DatosIglesiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChurchData C_D = new ChurchData();
            C_D.ShowDialog();
        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberAdd M_A = new MemberAdd();
            M_A.ShowDialog();
        }

        private void ButtonCode_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (TextBoxCodigo.Text == "Ingrese Código")
            {
                MessageBox.Show("Ingrese Codigo");
                check = false;
            }

            else if (!EvaluateTextBox.EIntPositive(TextBoxCodigo.Text, true, "Codigo"))
                check = false;
            else if (!Id.ExistsId("miembro", "codigo", TextBoxCodigo.Text))
            {
                MessageBox.Show("El Codigo ingresado No Existe");
                check = false;
            }
                
            if (check)
            {
                MemberShow M_S = new MemberShow(int.Parse(TextBoxCodigo.Text));
                M_S.ShowDialog();
            }
        }

        private void ButtonName_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (TextBoxName.Text == "Ingrese Nombre")
            {
                MessageBox.Show("Ingrese Nombre");
                check = false;
            }
            else if (!EvaluateTextBox.EString(TextBoxName.Text, 10, true, "Nombre"))
                check = false;

            if (check)
            {
                MemberFindName M_F_N = new MemberFindName(TextBoxName.Text);
                M_F_N.ShowDialog();
            }
        }

        private void ButtonLast_name_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (TextBoxApellidoPaterno.Text == "Ingrese Apellido")
            {
                MessageBox.Show("Ingrese Apellido");
                check = false;
            }
            else if (!EvaluateTextBox.EString(TextBoxApellidoPaterno.Text, 10, true, "Apellido"))
                check = false;

            if (check)
            {
                MemberFindPaternal M_F_P = new MemberFindPaternal(TextBoxApellidoPaterno.Text);
                M_F_P.ShowDialog();
            }
        }

        private void BuscarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (TextBoxMes.Text == "Ingrese Mes")
            {
                MessageBox.Show("Ingrese Mes");
                check = false;
            }
            else if (!EvaluateTextBox.EMounth(TextBoxMes.Text, true, "Mes"))
                check = false;

            if (check)
            {
                MemberFindMonth M_F_M = new MemberFindMonth(TextBoxMes.Text);
                M_F_M.ShowDialog();
            }
        }

        private void AgregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TitheAdd T_A = new TitheAdd();
            T_A.ShowDialog();
        }

        private void AgregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MissionaryOfferingAdd M_O_A = new MissionaryOfferingAdd();
            M_O_A.ShowDialog();
        }

        private void AgregarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ProTempleOfferingAdd P_T_O_A = new ProTempleOfferingAdd();
            P_T_O_A.ShowDialog();
        }

        private void AgregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OfferingAdd O_A = new OfferingAdd();
            O_A.ShowDialog();
        }

        private void BuscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OfferingFind O_F = new OfferingFind();
            O_F.ShowDialog();
        }

        private void BuscarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ProTempleOfferingFind P_T_O_F = new ProTempleOfferingFind();
            P_T_O_F.ShowDialog();
        }

        private void BuscarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MissionaryOfferingFind M_O_F = new MissionaryOfferingFind();
            M_O_F.ShowDialog();
        }

        private void BuscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TitheFind T_F = new TitheFind();
            T_F.ShowDialog();
        }

        private void TotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberShowAll M_S_A = new MemberShowAll();
            M_S_A.ShowDialog();
        }

        // Metodos PARA borrar al hacer click en un textbox
        private void TextBoxCodigo_Click(object sender, EventArgs e)
        {
            if (TextBoxCodigo.Text == "Ingrese Código")
            {
                TextBoxCodigo.Text = "";
                TextBoxCodigo.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBoxName_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "Ingrese Nombre")
            {
                TextBoxName.Text = "";
                TextBoxName.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBoxApellidoPaterno_Click(object sender, EventArgs e)
        {
            if (TextBoxApellidoPaterno.Text == "Ingrese Apellido")
            {
                TextBoxApellidoPaterno.Text = "";
                TextBoxApellidoPaterno.ForeColor = SystemColors.WindowText;
            }
        }

        private void TextBoxMes_Click(object sender, EventArgs e)
        {
            if (TextBoxMes.Text == "Ingrese Mes")
            {
                TextBoxMes.Text = "";
                TextBoxMes.ForeColor = SystemColors.WindowText;
            }
        }

    }
}
