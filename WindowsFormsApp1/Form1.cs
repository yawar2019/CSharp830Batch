using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            int num1, num2, c = 0;

            try
            {

                num1 = Convert.ToInt32(txtNum1.Text);
                num2 = Convert.ToInt32(txtNum2.Text);
                  c = num1 + num2;
                lblTotal.Text = c.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                 
            }
            finally
            {
                lblTotal.Text=c.ToString();
            }
        }

        
    }
}
