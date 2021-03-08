using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWordGenerator
{
    public partial class frmMain : Form
    {
        //Variablendeklaration
        Random rnd = new Random();
        String[] vokale = new String[] {
            "a",
            "e",
            "i",
            "o",
            "u",
        };

        String[] konsonanten = new String[] {
            "b",
            "c",
            "d",
            "f",
            "g",
            "h",
            "j",
            "k",
            "l",
            "m",
            "n",
            "p",
            "q",
            "r",
            "s",
            "t",
            "v",
            "w",
            "x",
            "z",
        };

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            rtxWord.Clear(); 

            for (int i = 0; i < Convert.ToInt32(txtWordLength.Text); i++)
            {
                if (Convert.ToInt32(txtWordLength.Text) > Convert.ToInt32(rtxWord.TextLength))
                {
                    int indexVokale = rnd.Next(vokale.Length);
                    rtxWord.Text += vokale[indexVokale];
                }
                else
                {
                    return;
                }

                if (Convert.ToInt32(txtWordLength.Text) > Convert.ToInt32(rtxWord.TextLength))
                {
                    int indexKonsonanten = rnd.Next(konsonanten.Length);
                    rtxWord.Text += konsonanten[indexKonsonanten];
                }else
                {
                    return;
                }
            }
        }
    }
}
