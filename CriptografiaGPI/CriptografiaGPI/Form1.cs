using System;
using System.Windows.Forms;

namespace CriptografiaGPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            txtCriptografia.Text = Criptografia.Criptografar(txtNormal.Text);
        }

        private void btnDescriptografar_Click(object sender, EventArgs e)
        {
            txtNormal.Text = Criptografia.Descriptografar(txtCriptografia.Text);
        }
    } 
}