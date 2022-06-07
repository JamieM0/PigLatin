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
            pnlConvertedSide.Visible = false;
            btnConvert.Enabled = false;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtConverted.Text);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Animate to the left
            int currentX = pnlClearSide.Location.X;
            int currentY = pnlClearSide.Location.Y;
            int animationSpeed = 220;
            Point currentP = new Point(currentX, currentY);
            if (currentP != new Point(176, 103))
            {
                for (int i = 0; i < animationSpeed; i++)
                {
                    pnlClearSide.Location = new Point(pnlClearSide.Location.X - 1, currentY);
                }
            }

            txtConverted.Text = "";
            string[] words = txtCleartext.Text.Split(' ');
            foreach(string element in words)
            {
                convertToPigLatin(element);
            }

            pnlConvertedSide.Visible = true;
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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnTestAnimate_Click(object sender, EventArgs e)
        {
            int currentX = pnlClearSide.Location.X;
            int currentY = pnlClearSide.Location.Y;
            int animationSpeed = 1000;
            Point currentP = new Point(currentX, currentY);
            if (currentP != new Point(176, 103))
            {
                for (int i = 0; i < animationSpeed; i++)
                {
                    pnlClearSide.Location = new Point(pnlClearSide.Location.X + 1, currentY);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCleartext.Text = "";
            txtConverted.Text = "";
            pnlConvertedSide.Visible = false;

            //Animate to the right
            int currentX = pnlClearSide.Location.X;
            int currentY = pnlClearSide.Location.Y;
            int animationSpeed = 220;
            Point currentP = new Point(currentX, currentY);
            if (currentP != new Point(176, 103))
            {
                for (int i = 0; i < animationSpeed; i++)
                {
                    pnlClearSide.Location = new Point(pnlClearSide.Location.X + 1, currentY);
                }
            }
        }

        private void txtCleartext_TextChanged(object sender, EventArgs e)
        {
            if (txtCleartext.Text.Length < 3)
            {
                btnConvert.Enabled = false;
            }
            else
            {
                btnConvert.Enabled = true;
            }
        }
    }
}
