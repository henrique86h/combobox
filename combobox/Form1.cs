using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) => Close();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbEscolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         
                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;

            switch (Convert.ToInt32(cmbEscolha.SelectedItem))
            {
                case 1:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Janeiro";
                    break;

                case 2:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Fevereiro";
                    break;

                case 3:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Março";
                    break;

                case 4:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Abril";
                    break;

                case 5:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Maio";
                    break;

                case 6:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Junho";
                    break;

                case 7:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Julho";
                    break;

                case 8:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Agosto";
                    break;

                case 9:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Setembro";
                    break;

                case 10:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Outubro";
                    break;

                case 11:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Novembro";
                    break;

                case 12:
                    lblMensagem.Text = "Olá " + textBoxNome.Text + " você Nasceu em Dezembro";
                    break;

                default:
                    lblMensagem.Text = "Por favor escolha uma opção de números; MÊS Não encontrado";
                    break;
                }
            }
    }
}
