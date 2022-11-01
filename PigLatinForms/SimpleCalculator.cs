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
    public partial class SimpleCalculator : Form
    {
        
        char calc_op;


        public SimpleCalculator()
        {
            InitializeComponent();
        }
        
        private void addNum(int num)
        {
            txtResult.Text += num.ToString();
        }

        private void addOP(char num)
        {
            txtResult.Text += num.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            addNum(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            addNum(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addNum(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addNum(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addNum(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addNum(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addNum(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addNum(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addNum(9);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            addNum(0);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            calc_op = '+';
            addOP('+');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            calc_op = '-';
            addOP('-');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            calc_op = '*';
            addOP('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calc_op = '/';
            addOP('/');
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string a = txtResult.Text;
            string[] elements = a.Split(calc_op);
            int[] nums = Array.ConvertAll(elements, int.Parse);
            int result = 0;

            if (calc_op == '+')
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    result += nums[i];
                }
            }
            else if (calc_op == '-')
            {
                for (int i = 0; i < nums.Length + 1; i++)
                {
                    result = nums[0];
                    result -= nums[i + 1];
                }
            }
            else if (calc_op == '*')
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    result = 1;
                    result *= nums[i];
                }
            }
            else if (calc_op == '/')
            {
                for (int i = 0; i < nums.Length + 1; i++)
                {
                    result = nums[0];
                    result /= nums[i + 1];
                }
            }
            else
            {
                MessageBox.Show("Error! Try not entering more than one operator.");
            }

            txtResult.Text = result.ToString();
        }
    }
}
