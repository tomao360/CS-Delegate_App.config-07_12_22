using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WinFormsDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int result = DelegateClass.Instance.Calc(int.Parse(num1TextBox.Text), int.Parse(num2TextBox.Text), DelegateClass.Instance.Addition);
                MessageBox.Show(result.ToString(), "Result");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter 2 numbers to perform a calculation" ,ex.Message);
            }


            //-------App.config exaple-------
            string s1 = ConfigurationManager.AppSettings["outputFolder"];
            //-------------------------------
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int result = DelegateClass.Instance.Calc(int.Parse(num1TextBox.Text), int.Parse(num2TextBox.Text), DelegateClass.Instance.Subtraction);
                MessageBox.Show(result.ToString(), "Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter 2 numbers to perform a calculation", ex.Message);
            }
        }

        private void divisionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int result = DelegateClass.Instance.Calc(int.Parse(num1TextBox.Text), int.Parse(num2TextBox.Text), DelegateClass.Instance.Division);
                MessageBox.Show(result.ToString(), "Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter 2 numbers to perform a calculation", ex.Message);
            }
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int result = DelegateClass.Instance.Calc(int.Parse(num1TextBox.Text), int.Parse(num2TextBox.Text), DelegateClass.Instance.Mult);
                MessageBox.Show(result.ToString(), "Result");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter 2 numbers to perform a calculation", ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            num1TextBox.Text = "";
            num2TextBox.Text = "";
        }
    }
}
