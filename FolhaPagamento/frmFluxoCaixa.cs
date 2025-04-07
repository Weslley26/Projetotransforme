using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaPagamento
{
    public partial class frmFluxoCaixa : Form
    {
        public frmFluxoCaixa()
        {
            InitializeComponent();
            //executando método desabilitar campos
            desabilitarCampos();
            //executando método carrega combo
            carregaCombo();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        //limpando campos
        public void limparCampos()
        {
            txtImpostoRenda.Clear();
            txtSalarioBruto.Clear();
            txtSalarioFolha.Clear();
            txtSalarioLiquido.Clear();
            ckbPlanoSaude.Checked = false;
            cbbClubeSaude.Text = "";

            txtSalarioBruto.Focus();
        }
        //desabilitando campos por codigo
        public void desabilitarCampos()
        {
            txtSalarioFolha.Enabled = false;
            txtImpostoRenda.Enabled = false;
            txtSalarioLiquido.Enabled = false;
        }
        //carregando combobox pelo código
        public void carregaCombo()
        {
            cbbClubeSaude.Items.Add("Clube A - R$ 100,00");
            cbbClubeSaude.Items.Add("Clube B - R$ 50,00");
            cbbClubeSaude.Items.Add("Clube C - R$ 30,00");
        }

        private void txtSalarioBruto_TextChanged(object sender, EventArgs e)
        {
            txtSalarioFolha.Text = txtSalarioBruto.Text;
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salarioFolha = 0, impostoRenda = 0, salarioLiquido = 0;
            
            try
            {
                salarioFolha = Convert.ToDouble(txtSalarioFolha.Text);

                if (salarioFolha < 2259.20)
                {
                    salarioLiquido = 0;
                    txtSalarioLiquido.Text = txtSalarioFolha.Text;
                }
                else if (salarioFolha >= 2259.21 && salarioFolha <= 2826.65)
                {
                    impostoRenda = salarioFolha * 7.5 / 100;
                    salarioLiquido = (salarioFolha - (impostoRenda));

                }
                else if (salarioFolha >= 2826.66 && salarioFolha <= 3751.05)
                {
                    impostoRenda = salarioFolha * 15 / 100;
                    salarioLiquido = (salarioFolha - (impostoRenda));

                }
                else if (salarioFolha >= 3751.06 && salarioFolha <= 4664.68)
                {
                    impostoRenda = salarioFolha * 22.5 / 100;
                    salarioLiquido = (salarioFolha - (impostoRenda));

                }
                else if (salarioFolha >= 4664.69)
                {
                    impostoRenda = salarioFolha * 27.5 / 100;
                    salarioLiquido = (salarioFolha - (impostoRenda));
                }

                if (ckbPlanoSaude.Checked)
                {
                    salarioLiquido = salarioLiquido - 200;
                }
                if (cbbClubeSaude.SelectedIndex == 0)
                {
                    salarioLiquido = salarioLiquido - 100;
                }
                if (cbbClubeSaude.SelectedIndex == 1)
                {
                    salarioLiquido = salarioLiquido - 50;
                }
                if (cbbClubeSaude.SelectedIndex == 2)
                {
                    salarioLiquido = salarioLiquido - 30;
                }

                txtImpostoRenda.Text = impostoRenda.ToString();
                txtSalarioLiquido.Text = salarioLiquido.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir salário válido",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }

    }
}
