using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelMsg1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            labelMsg1.Text = $"Hello {textBoxName.Text} {textBoxSurname.Text}.";
            labelMsg2.Text = $"You still have {65-Convert.ToInt32(textBoxAge.Text)} years till retirement.";
        }
    }
}
