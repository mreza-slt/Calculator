using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Calculator
{
    public partial class Form1 : Form
    {

        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate(); 
        }

        bool ValidateInput()
        {
            bool isValide = true;

            if (txtNumber1.Value ==0)
            {
                isValide= false;
                MessageBox.Show("لطفا عدد اول را وارد کنید.");
            }
            else if(txtNumber2.Value ==0)
            {
                    isValide = false;
                    MessageBox.Show("لطفا عدد دوم را هم وارد کنید.");
            }


            return isValide;
        }
        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int sum = calculate.Plus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum is " + sum);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int sum = calculate.Minus((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum is " + sum);
            }
        }

        private void btnMultyple_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int sum = calculate.Multiple((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum is " + sum);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int sum = calculate.Divide((int)txtNumber1.Value, (int)txtNumber2.Value);
                MessageBox.Show("Sum is " + sum);
            }
        }
    }
}
