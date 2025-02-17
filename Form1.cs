using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9_DienTichHinhTron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {
            double bk, chuvi, dientich;

            bk = Convert.ToDouble(txtBK.Text);

            if (rdbCV.Checked)
            {
                chuvi = 2 * Math.PI * bk;
                txtKQ.Text = chuvi.ToString();
            }
            if (rdbDT.Checked)
            {
                dientich = (Math.PI * (bk * bk));
                txtKQ.Text = dientich.ToString();
            }
        }

        private void txtKq_TextChanged(object sender, EventArgs e)
        {
            double So = double.Parse(txtBK.Text);
            double chuvi, dientich;
            if (rdbCV.Checked)
            {
                chuvi = Math.PI * (So * 2);
                txtKQ.Text = chuvi.ToString();
            }
            if (rdbDT.Checked)
            {
                dientich = Math.PI * (So * So);
                txtKQ.Text = dientich.ToString();

            }
        }
    }
}
