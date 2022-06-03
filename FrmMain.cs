using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA220603
{
    public partial class FrmMain : Form
    {
        static Random rnd = new Random();
        static string nev = "Zoli";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
                caption: "ELSŐ",
                text: $"Szia {nev}!\nAkarsz epilepszás rohamot kapni?",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                btnMeg.Visible = true;
                btnMeg.Click += BtnMeg_Click;
            }
        }

        private void BtnMeg_Click(object sender, EventArgs e)
        {
            lblNev.Text = nev;

            lblNev.BackColor = Color.FromArgb(
                red: rnd.Next(256),
                green: rnd.Next(256),
                blue: rnd.Next(256));
        }
    }
}
