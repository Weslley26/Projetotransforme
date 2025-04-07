using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {

        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        public void limparCampos()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResposta.Clear();
            rdbSomar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDividir.Checked = false;
            txtNumero1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //declarando as variáveis
            double num1, num2, resp = 0;

            try
            {
                //inicializar as variáveis
                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);

                if (rdbSomar.Checked == false
                    && rdbSubtrair.Checked == false
                    && rdbMultiplicar.Checked == false
                    && rdbDividir.Checked == false)
                {
                    MessageBox.Show("Selecione um operação",
                            "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
                }
                else
                {
                    //criando a estrutura de decisão
                    if (rdbSomar.Checked)
                    {
                        //somando valores
                        resp = num1 + num2;
                    }
                    if (rdbSubtrair.Checked)
                    {
                        //subtraindo valores
                        resp = num1 - num2;
                    }
                    if (rdbMultiplicar.Checked)
                    {
                        //multiplicando valores
                        resp = num1 * num2;
                    }
                    if (rdbDividir.Checked)
                    {
                        if (num2 == 0)
                        {
                            MessageBox.Show("Impossível dividir por 0",
                                "Mensagem do sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1);
                            limparCampos();

                        }
                        else
                        {
                            //dividindo valores
                            resp = num1 / num2;
                        }
                    }


                    txtResposta.Text = resp.ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir valores válidos",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
            }
        }
    }
}