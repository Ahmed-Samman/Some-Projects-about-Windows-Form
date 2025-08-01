using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTxtBirthDate.MaskFull && maskedTxtPhoneNumber.MaskFull && maskedTxtZipCode.MaskFull)
            {
                maskTxtName.BackColor = Color.Green;
                maskedTxtBirthDate.BackColor = Color.Green;
                maskedTxtPhoneNumber.BackColor = Color.Green;
                maskedTxtZipCode.BackColor = Color.Green;   
            }
            else
            {
                maskTxtName.BackColor = Color.Red;
                maskedTxtBirthDate.BackColor = Color.Red;
                maskedTxtPhoneNumber.BackColor = Color.Red;
                maskedTxtZipCode.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskTxtName.BackColor = Color.White;
            maskedTxtBirthDate.BackColor = Color.White;
            maskedTxtPhoneNumber.BackColor = Color.White;
            maskedTxtZipCode.BackColor = Color.White;

            maskTxtName.Clear();
            maskedTxtBirthDate.Clear();
            maskedTxtPhoneNumber.Clear();
            maskedTxtZipCode.Clear();


        }





    }
}
