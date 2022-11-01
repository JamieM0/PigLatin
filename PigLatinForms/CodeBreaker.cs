using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PigLatinForms
{
    public partial class CodeBreaker : Form
    {
        public CodeBreaker()
        {
            InitializeComponent();
            disableAns();
            lb1.Text = "*";
            lb2.Text = "*";
            lb3.Text = "*";
            lb4.Text = "*";
        }

        private void CodeBreaker_Load(object sender, EventArgs e)
        {

        }

        private void disableAns()
        {
            txt1.Enabled = false;
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
        }

        private void enableAns()
        {
            txt1.Enabled = true;
            txt2.Enabled = true;
            txt3.Enabled = true;
            txt4.Enabled = true;
        }
        
        private void shuffle(Label label)
        {
            for (int i=0; i < 11; i++)
            {
                // Generate random number
                Random rnd = new Random();
                label.Text = rnd.Next(0, 10).ToString();
                //Thread.Sleep(100);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            shuffle(lb1);
            shuffle(lb2);
            shuffle(lb3);
            shuffle(lb4);
        }
    }
}
