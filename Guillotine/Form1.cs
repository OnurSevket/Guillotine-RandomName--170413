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
    public partial class Form1 : Form
    {
        List<string> nameList = new List<string>();

        Random rnd = new Random();
     
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartGuillotine_Click(object sender, EventArgs e)
        {

           
            form2.Owner = this;
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            nameList.Add(firstName +" "+ lastName);
            txtFirstName.Clear();
            txtLastName.Clear();
        }

        public void AddLabel()
        {

            int deneme = 20;
            int counter = 0;
            int i = 0;
            if (i < nameList.Count)
            {
                int windowHeight = form2.Height;
                int windowWidth = form2.Width;

                int randomName = rnd.Next(0, nameList.Count);
                int randomSize = rnd.Next(1, 40);
                //int randomLocation = rnd.Next(windowHeight, windowWidth);

                Label label = new Label();
                label.Text = nameList[randomName];
                label.Tag = counter;
                label.AutoSize = true;
                label.Font = new Font("Arial", randomSize);
                label.Location = new Point(rnd.Next(windowHeight), rnd.Next(windowWidth));
                label.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));

                form2.Controls.Add(label);
                deneme = deneme + 200;
                counter++;
                i++;
            }
        }

        public void DeleteLabel()
        {
            int i = form2.Controls.Count - 2;
            if (i >= 0)
            {

                Control c = form2.Controls[i];

                if (c is Label)
                {
                    form2.Controls.RemoveAt(i);

                }
            }
            i--;
        }
    }
}
