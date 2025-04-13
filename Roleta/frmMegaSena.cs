using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roleta
{
    public partial class frmMegaSena : Form
    {
        //06-Guilherme Hemrique de Souza Pereira
        //Inicio da Classe - Criação de objetos, variaveis, tipos que serão privados
        //à classe - que serão visíveis à toda classe
        private Random Mega = new Random();//Mega.Next(1,50);
        private int numeroSorteado;
        private int[,] cartao;
        private char[,] jogoVelha = new char[,] { 
                                                    { 'X', 'O', 'X' },
                                                    { 'X', 'O', 'X' },
                                                    { 'O', 'X', 'O' } };

        public frmMegaSena()
        {
            InitializeComponent();
        }

        private void Megasena_Load(object sender, EventArgs e)
        {

        }
        private void btnSortearNum_Click(object sender, EventArgs e)
        {
            // Consistência de Dados - Verificar Quantidade de Cartões
            if (String.IsNullOrWhiteSpace(txtQntdDeCartões.Text))
            {
                MessageBox.Show("Informe a quantidade a cartões desejados !!",
                    "Mega Sena",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            cartao = new int[Convert.ToInt32(txtQntdDeCartões.Text),6];
            GerarCartoes();
        }

        private void GerarCartoes()
        {
            for (int i = 0; i < Convert.ToInt32(txtQntdDeCartões.Text); i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    numeroSorteado = Mega.Next(1, 61);
                    cartao[i, j] = numeroSorteado;
                    lblNumeros.Text += numeroSorteado.ToString("00")+"-";//"#,##0.00"
                    //lblNumeros.Text += Convert.ToString(numeroSorteado)+"-";
                }
                lstCartoes.Items.Add(lblNumeros.Text);
                lblNumeros.Text = "";
            }
         
        }
    }
}
