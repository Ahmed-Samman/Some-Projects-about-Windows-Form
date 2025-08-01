using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Picture_Box__Exercise_.Properties;


namespace Picture_Box__Exercise_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }   

        private void rbtnBoy_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Boy;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }
        private void rbtnGirl_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Girl;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }
        private void rbtnBook_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Book;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }
        private void rbtnPen_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Pen;
            lblTitle.Text = ((RadioButton)sender).Tag.ToString();
        }

      
    }
}
