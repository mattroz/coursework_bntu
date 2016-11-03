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

            timeStart_NUD.Value = 3;
            timeFinish_NUD.Value = 12;
            timeQuantum_NUD.Value = (decimal)0.3;

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
            /*  clear chart and list box  */
            timeFunctionPlot.Series["Series1"].Points.Clear();
            pe_logBox.Items.Clear();
            
            PolinomialEquation pe = new PolinomialEquation();
            pe.aCoefficient = Convert.ToDouble(pe_firstCoeff_TB.Text);
            pe.bCoefficient = Convert.ToDouble(pe_secondCoeff_TB.Text);
            pe.dCoefficient = Convert.ToDouble(pe_fourthCoeff_TB.Text);

            float point;
            float time_start = (float)timeStart_NUD.Value,
                  time_finish = (float)timeFinish_NUD.Value,
                  time_quantum = (float)timeQuantum_NUD.Value;

            //pe_answerHolder.Text = point.ToString();

            /*   Plotting    */
            for (float t = time_start; t <= time_finish; t += time_quantum )
            {
                pe.cCoefficient = pe.dCoefficient / t;  //  change C coefficient value dynamically
                point = pe.calculateCurrentValue(t);
                timeFunctionPlot.Series["Series1"].Points.AddXY(t, point);

                pe_logBox.Items.Add(point);
            }

            

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
