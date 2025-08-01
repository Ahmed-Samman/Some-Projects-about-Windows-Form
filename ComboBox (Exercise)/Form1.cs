using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox__Exercise_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; // Set default selection to the first item
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Book")
            {
                lblThings.Text = comboBox1.Text.ToString();
                pictureBox1.Image = Properties.Resources.Book;
            }
            else if (comboBox1.SelectedItem.ToString() == "Boy")
            {
                lblThings.Text = comboBox1.Text.ToString();
                pictureBox1.Image = Properties.Resources.Boy;
            }
            else if (comboBox1.SelectedItem.ToString() == "Girl")
            {
                lblThings.Text = comboBox1.Text.ToString();
                pictureBox1.Image = Properties.Resources.Girl;
            }
            else 
            {
                lblThings.Text = comboBox1.Text.ToString();
                pictureBox1.Image = Properties.Resources.Pen;
            }
        }

       
    }
}
