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
    public partial class AnoynymusMethodExample2 : Form
    {
        public AnoynymusMethodExample2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello2 World");
        }
            private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Click NEXT";
            btn.Size = new Size(100, 50);
            btn.Location = new Point(150, 100);

          //  btn.Click += new EventHandler(button2_Click);


            btn.Click += delegate (object sender1, EventArgs e1)
            {
                MessageBox.Show("Hello World");
            };
            this.Controls.Add(btn);

        }
    }
}
