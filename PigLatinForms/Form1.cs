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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtConverted.Text);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string[] words = txtCleartext.Text.Split(' ');
            foreach(string element in words)
            {
                convertToPigLatin(txtCleartext.Text);
            }
        }
        
        private void convertToPigLatin(string text)
        {
            string converted;
            if (text[0] == 'a' || text[0] == 'e' || text[0] == 'i' || text[0] == 'o' || text[0] == 'u')
            {
                txtConverted.Text += text + "way" + " ";
            }
            else if (text[1] != 'a' && text[1] != 'e' && text[1] != 'i' && text[1] != 'o' && text[1] != 'u')
            {
                txtConverted.Text += text.Substring(2) + text[0] + text[1] + "ay" + " ";
            }
            else
            {
                txtConverted.Text += text.Substring(1) + text[0] + "ay" + " ";
            }
        }
    }
}
