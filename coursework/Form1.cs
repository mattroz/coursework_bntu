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

            /*   DEFAULT SETTINGS   */
            leftBoundaryPoint_TB.Text = "0";
            rightBoundaryPoint_TB.Text = "0,85";
            epsilon_TB.Text = "0,0001";

            qe_firstCoeffTB.Text = "3";
            qe_secondCoeffTB.Text = "3";
            qe_thirdCoeffTB.Text = "-3";

            pe_fourthCoeff_TB.Text = "5";

            machineTimeRB.Checked = true;
        }

        /*          VALIDATION          */

        private bool isValid(KeyPressEventArgs _event)
        {
            bool result = (Char.IsDigit(_event.KeyChar) || Char.IsControl(_event.KeyChar) 
                            || _event.KeyChar == ',' || _event.KeyChar == '-') ? false : true;
            return result;
        }


        /*         NON-LINEAR EQUATION UI IMPLEMENTATION         */

        private void nle_setVariablesButton_Click(object sender, EventArgs e)
        {
            NonLinearEquation nle = new NonLinearEquation();
            nle.leftBoundaryPoint = Convert.ToDouble(leftBoundaryPoint_TB.Text);
            nle.rightBoundaryPoint = Convert.ToDouble(rightBoundaryPoint_TB.Text);
            nle.Epsilon = Convert.ToDouble(epsilon_TB.Text);

            nle_answerHolder.Text = nle.solveByIterationsMethod().ToString();
            pe_firstCoeff_TB.Text = nle_answerHolder.Text;
        }

        private void leftBoundaryPoint_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isValid(e);
        }

        private void rightBoundaryPoint_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isValid(e);
        }

        private void epsilon_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isValid(e);
        }


        /*       QUADRATICS EQUATION UI IMPLEMENTATION       */

        private void qe_setVariableButton_Click(object sender, EventArgs e)
        {
            QuadraticEquation qe = new QuadraticEquation();
            qe.setCoefficients(Convert.ToDouble(qe_firstCoeffTB.Text),
                                Convert.ToDouble(qe_secondCoeffTB.Text),
                                Convert.ToDouble(qe_thirdCoeffTB.Text));

            qe_answerHolder.Text = qe.solveByDiscriminant().ToString();
            pe_secondCoeff_TB.Text = qe_answerHolder.Text;

        }

        private void qe_firstCoeffTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isValid(e);
        }

        private void qe_secondCoeffTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isValid(e);
        }

        private void qe_thirdCoeffTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isValid(e);
        }

        /*       POLYNOMIAL EQUATION UI IMPLEMENTATION       */

        private void pe_calculateVariableButton_Click(object sender, EventArgs e)
        {
            PolinomialEquation pe = new PolinomialEquation();
            pe.aCoefficient = Convert.ToDouble(pe_firstCoeff_TB.Text);
            pe.bCoefficient = Convert.ToDouble(pe_secondCoeff_TB.Text);
            pe.cCoefficient = Convert.ToDouble(pe_thirdCoeff_TB.Text);
            pe.dCoefficient = Convert.ToDouble(pe_fourthCoeff_TB.Text);

            float point = pe.calculateCurrentValue(3);
            //float time_start = 3.0, time_finish = 12.0, time_quantum = 0.3;

            pe_answerHolder.Text = point.ToString();
            pe_logBox.Items.Add(point);

            //for()
            //{
            
            //}

            //chart1.Series["Series1"].Points.AddXY(3);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
