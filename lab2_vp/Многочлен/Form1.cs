using System;
using System.Windows.Forms;

namespace Многочлен
{
    public partial class Form1 : Form
    {
        Polynomial one, two, result;

        private void button4_Click(object sender, EventArgs e)
        {
            Polynomial polynomial;
            int pow = 0;
            double value = 0;
            int.TryParse(tb_pow.Text, out pow);
            double.TryParse(tb_cof.Text, out value);
            
            if (radioOne.Checked)
                polynomial = one;
            else
                polynomial = two;
            polynomial.SetCoefficient(value, pow);
            
            if (radioOne.Checked)
                tb_one.Text = polynomial.ToString();
            else
                tb_two.Text = polynomial.ToString();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            result = Polynomial.minus(one, two);
            tb_result.Text = result.ToString();
        }

        private void btn_multy_Click(object sender, EventArgs e)
        {
            result = Polynomial.multy(one, two);
            tb_result.Text = result.ToString();
        }

        private void btn_itog_Click(object sender, EventArgs e)
        {
            Polynomial polynomial;
            if (radio1.Checked)
                polynomial = one;
            else
            {
                if (radio2.Checked)
                    polynomial = two;
                else
                    polynomial = result;
            }
            double value = 0;
            double.TryParse(tb_x.Text, out value);
            tb_value.Text = polynomial.GetResult(value).ToString();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            result = Polynomial.plus(one, two);
            tb_result.Text = result.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            one = new Polynomial(100);
            two = new Polynomial(100);
            radioOne.Checked = true;
            radio1.Checked = true;
            tb_one.Text = one.ToString();
            tb_two.Text = two.ToString();
            result = new Polynomial(200);
        }
    }
}
