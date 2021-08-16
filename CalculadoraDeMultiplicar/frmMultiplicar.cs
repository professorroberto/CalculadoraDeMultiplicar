using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraDeMultiplicar
{
    public partial class frmMultiplicar : Form
    {
        int res;
        public frmMultiplicar()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            res = int.Parse(txtN1.Text) * int.Parse(txtN2.Text);
            lblRes.Text = res.ToString();
        }
    }
}
