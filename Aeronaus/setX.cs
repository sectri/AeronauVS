using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeronaus
{
    public partial class setX : Form
    {
        int x;
        public setX(String text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void setX_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void acceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Falta informacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            x = int.Parse(textBox1.Text);
            this.Hide();
        }

        public int getValor
        {
            get
            {
                return x;
            }
        }

        private void onlyNumeric(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
