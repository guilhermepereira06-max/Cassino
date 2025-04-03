using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roleta
{
    public partial class frmCacaNiquel : Form
    {
        public partial class Roleta : Form
        {
            private Random sorteio = new Random();
            private int niquel1, niquel2, niquel3;
            private int contaGiro = 0;
            private int contaNiquel = 1;
        }
        public frmCacaNiquel()
        {
            InitializeComponent();
        }
        private void tmrSorteioGeral_Tick(object sender, EventArgs e)
        {
            MostraNiquel();
        }
        private void btnJogar_Click(object sender, EventArgs e)
        {
            btnJogar.Text = "&STOP";
            tmrNiquel.Enabled = true;
        }

        private void MostraNiquel()
        {
            niquel1 = sorteio.Next(0, 10);
            niquel2 = sorteio.Next(0, 10);
            niquel3 = sorteio.Next(0, 10);
            lblNiquel1.Text = niquel1.ToString();
            lblNiquel2.Text = niquel2.ToString();
            lblNiquel3.Text = niquel3.ToString();

        }



        private void btnGirar_Click(object sender, EventArgs e)
        {
            int niquel1 = 0, niquel2 = 0, niquel3 = 0;
            MostraNiquel();
        }
        private void tmrNiquel_Tick(object sender, EventArgs e)
        {
            contaGiro++;
            if (contaNiquel == 1)
            {
                niquel1 = sorteio.Next(0, 10);
                lblNiquel1.Text = niquel1.ToString();
            }
            else if (contaNiquel == 2)
            {
                niquel2 = sorteio.Next(0, 10);
                lblNiquel2.Text = niquel2.ToString();
            }
            else if (contaNiquel == 3)
            {
                niquel3 = sorteio.Next(0, 10);
                lblNiquel3.Text = niquel3.ToString();
            }
            else
            {
               // atingiu a condição de término
                tmrNiquel.Enabled = false;
                /* MessageBox.Show("Parabéns, você ganhou no Tigrinho!!! \n\n" +
                               "sequencia: " + niquel1.ToString() + " - " +
                                              niquel2.ToString() + " - " +
                                              niquel3.ToString(),
                                 "Tigrinho Wins !!!",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation); */
                lblNiquel1.Text = String.Empty;
                lblNiquel2.Text = String.Empty;
                lblNiquel3.Text = String.Empty;
                btnJogar.Text = "&Jogar";
                //lstNiquel.Items.Add(niquel1.ToString() + " - " + niquel2.ToString() + " - " + niquel3.ToString());
                contaGiro = 0;
                contaNiquel = 1;
                if ((niquel1 == niquel2) && (niquel2 == niquel3))
                {
                    MessageBox.Show("Parabéns, você ganhou um trabalho 6x1 das 8h as 18h sem direito a transporte e ticket de alimentação!!! \n\n" +
                              "sequencia: " + niquel1.ToString() + " - " +
                                             niquel2.ToString() + " - " +
                                             niquel3.ToString(),
                                "Tigrinho Wins !!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((niquel1 == niquel2) || (niquel1 == niquel3) || (niquel2 == niquel3))
                {
                    MessageBox.Show("Você ganhou uma beterraba!! \n\n" +
                       "sequencia: " + niquel1.ToString() + " - " +
                                        niquel2.ToString() + " - " +
                                        niquel3.ToString()
                       );
                }
                else
                {
                    MessageBox.Show("Você ganhou um milinho :( \n\n" +
                        "sequencia: " + niquel1.ToString() + " - " +
                                        niquel2.ToString() + " - " +
                                        niquel3.ToString()
                        );
                }
            }

            if (contaGiro == 10)
            {
                contaNiquel++;
                contaGiro = 0;
            }
        }
         private Random sorteio = new Random();
        private int niquel1, niquel2, niquel3;

        private void frmCacaNiquel_Load(object sender, EventArgs e)
        {

        }

        private int contaGiro = 0;
        private int contaNiquel = 1; 
        }
    
    }

