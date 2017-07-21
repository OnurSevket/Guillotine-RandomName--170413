using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guillotine
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            int id = int.Parse(lblTimer.Text);
            if (id <= 30)
            {
                lblTimer.Text = (id + 1).ToString();

                form1.AddLabel();
            }
            else if (id > 30 && id < 60)
            {
                lblTimer.Text = (id + 1).ToString();

                form1.DeleteLabel();
            }

            if (id == 60)
            {
                for (int i = 0; i < 3; i++)
                {
                    Control c = this.Controls[i];
                    if (c is Label)
                    {
                       
                        c.Font = new Font("Times News Roman", 25);
                        
                        c.Location = new Point(300, 250);
                       
                    }
                }
            }
            id++;

        }
    }
}
