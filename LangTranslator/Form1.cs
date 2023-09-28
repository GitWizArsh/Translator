using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangTranslator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFrench_Click(object sender, EventArgs e)
        {
            txtTranslate.Text = "Bonjour";
        }

        private void btnGerman_Click(object sender, EventArgs e)
        {
            txtTranslate.Text = "Guten Morgen";
        }

        private void btnPolish_Click(object sender, EventArgs e)
        {
            txtTranslate.Text = "dzień dobry";
        }
    }
}
