using MyEditControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonAnyChar_CheckedChanged(object sender, EventArgs e)
        {
            validatedTextBox.Clear();
            validatedTextBox.textValidate = null;
        }

        private void radioButtonDigitsOnly_CheckedChanged(object sender, EventArgs e)
        {
            validatedTextBox.Clear();
            validatedTextBox.textValidate = new NumericOnlyText();
        }

        private void radioButtonLettersOnly_CheckedChanged(object sender, EventArgs e)
        {
            validatedTextBox.Clear();
            validatedTextBox.textValidate = new LettersOnlyText();
        }
    }
}
