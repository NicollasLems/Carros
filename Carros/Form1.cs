using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carros
{
    public partial class frmcarro : Form
    {
        public frmcarro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtcarro.Clear();
            txtimposto.Clear();
            txtpreco.Clear();
            txtlucro.Clear();
            txtvfinal.Clear();
            txtcarro.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double preco, imposto, a, lucro, vfinal;

            preco = Convert.ToDouble(txtpreco.Text);
            imposto = preco / 100 * 45;
            a = preco + imposto;
            lucro = a / 100 * 12;
            vfinal = a + lucro;

            txtimposto.Text = "R$" + imposto.ToString();
            txtlucro.Text = "R$" + lucro.ToString();
            txtvfinal.Text = "R$" + vfinal.ToString();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
