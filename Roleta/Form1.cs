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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MostraNiquel(int niquel1, int niquel2,int niquel3)
        {
            Random sorteio = new Random();
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
            MostraNiquel(niquel1, niquel2, niquel3);
        }
    }
}
