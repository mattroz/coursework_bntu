using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // NonLinearEquation nle = new NonLinearEquation(0.0, 0.85, 0.0001);
           // textBox1.Text = nle.solveByIterationsMethod().ToString();
        }

        /*         NON-LINEAR EQUATION UI IMPLEMENTATION         */

        private void nle_setVariablesButton_Click(object sender, EventArgs e)
        {
            NonLinearEquation nle = new NonLinearEquation();
            nle.leftBoundaryPoint = Convert.ToDouble(leftBoundaryPoint_TB.Text);
            nle.rightBoundaryPoint = Convert.ToDouble(rightBoundaryPoint_TB.Text);
            nle.Epsilon = Convert.ToDouble(epsilon_TB.Text);

            nle_answerHolder.Text = nle.solveByIterationsMethod().ToString();
        }

        private void leftBoundaryPoint_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void rightBoundaryPoint_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void epsilon_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        /*       QUADRATICS EQUATION UI IMPLEMENTATION       */

        private void qe_setVariableButton_Click(object sender, EventArgs e)
        {
            QuadraticEquation qe = new QuadraticEquation();
            qe.setCoefficients(Convert.ToDouble(qe_firstCoeffTB.Text),
                                Convert.ToDouble(qe_secondCoeffTB.Text),
                                Convert.ToDouble(qe_thirdCoeffTB.Text));

            qe_answerHolder.Text = qe.solveByDiscriminant().ToString();

        }

        private void qe_firstCoeffTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void qe_secondCoeffTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void qe_thirdCoeffTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        
        
    }
}
