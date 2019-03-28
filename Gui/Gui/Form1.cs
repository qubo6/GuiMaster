using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public float FontSize { get; set; } = 10;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var chars = txtText.Text.ToCharArray();
            int a = chars.Count();
            label1.Text = Convert.ToString(a);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Microsoft Sans Serif", FontSize);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Arial", FontSize);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Font = new Font("Comic Sans MS", FontSize);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                FontSize = 10;
                txtText.Font = new Font(Font.Name, FontSize);
            }
            else
            {
                if (float.TryParse(textBox1.Text, out float _fontSize))
                {
                    FontSize = _fontSize;
                    txtText.Font = new Font(Font.Name, FontSize);
                }
                else
                {
                    MessageBox.Show("cislo");
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                txtText.ForeColor = Color.Red;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                txtText.ForeColor = Color.Pink;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                txtText.ForeColor = Color.Green;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                txtText.ForeColor = Color.Blue;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtText.ReadOnly = !txtText.ReadOnly;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item != checkBox2)
                {
                    item.Enabled = !item.Enabled;
                }

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Dock = DockStyle.Left;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Dock = DockStyle.Right;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Dock = DockStyle.None;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Dock = DockStyle.Top;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            txtText.Dock = DockStyle.Bottom;
        }
        int counter = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            counter++;
            switch (counter % 2)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\transformer2\Pictures\Saved Pictures\Kros2.jpg");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\transformer2\Pictures\Saved Pictures\Kros1.jpg");
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 10)
            {

                progressBar1.Value++;
            }
            else if (progressBar1.Value==10)
            {
                progressBar1.Value = 0;
            }
            
        }
    }
}
