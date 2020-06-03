using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciamento_de_Interface_Grafica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            if (this.PrimaryTextBox.Text.Length < 1)
            {
                this.TextError.SetError(this.PrimaryTextBox, "String Vazia");
            }
            else
            {
                this.TextError.SetError(this.PrimaryTextBox, String.Empty);
            }
        }
    }
}