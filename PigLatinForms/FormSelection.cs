using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PigLatinForms
{
    public partial class FormSelection : Form
    {
        public FormSelection()
        {
            InitializeComponent();
        }

        private void btnPL_Click(object sender, EventArgs e)
        {
            Hide();
            new frmMain().Show();
        }

        private void btnRPS_Click(object sender, EventArgs e)
        {
            Hide();
            new RPS().Show();
        }
    }
}
