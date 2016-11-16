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
        public struct TimeFunctionChart_s
        {
            public float
                start_time,
                finish_time,
                time_quantum,
                elapsed_time_in_msecs,
                total_time;
        }

        /******************************/
        /*          GLOBALS           */
        /******************************/
        #region

        public const int NUM_OF_POLYNOMIAL_COEFFS = 4;
        
        // globals because of need of Timer's correct work
        PolynomialEquation pe = new PolynomialEquation();   
        TimeFunctionChart_s chartTimeProperties = new TimeFunctionChart_s();
        LINQEntity linq = null;
        TextBox[] coefficientsTextBoxesArray = new TextBox[NUM_OF_POLYNOMIAL_COEFFS];
        #region vldtn
        string[] ppArray = { "UGxvdHR", "pbmcgd", "GhlIGZ1bm", 
                             "N0aW9uIG", "9mIHRpbW", "UgKFJvemF", 
                             "ub3YgTS5", "TLiwgdGF", "zayAxNCk="};
        #endregion vldtn

        /*   Array which contains points calculated by Horner's method,
         *   need for LINQs
         */
        List<float> pointsArray = new List<float>();
        #endregion


        public Form1()
        {
            InitializeComponent();

            /************************/
            /*   DEFAULT SETTINGS   */
            /************************/
            #region
            leftBoundaryPoint_TB.Text = "0";
            rightBoundaryPoint_TB.Text = "0,85";
            epsilon_TB.Text = "0,0001";

            #region vldtn
            if (!formIsValid(this.Text))
            {
                Console.WriteLine("Exit due to ownership");
                Environment.Exit(0);
            }
            #endregion vldtn

            qe_firstCoeffTB.Text = "3";
            qe_secondCoeffTB.Text = "3";
            qe_thirdCoeffTB.Text = "-3";

            pe_thirdCoeff_TB.Text = "5";
            pe_fourthCoeff_TB.Text = "-5";

            timeStart_NUD.Value = 3;
            timeFinish_NUD.Value = 12;
            timeQuantum_NUD.Value = (decimal)0.3;

            machineTimeRB.Checked = true;

            qe_calculateVariableButton.Enabled = false;
            pe_startPlottingButton.Enabled = false;

            makeLINQToolStripMenuItem.Enabled = false;
             #endregion
        }



        /************************************/
        /*          CUSTOM METHODS          */
        /************************************/
        #region
        private bool isValid(KeyPressEventArgs _event)
        {
            bool result = (Char.IsDigit(_event.KeyChar) || Char.IsControl(_event.KeyChar) 
                            || _event.KeyChar == ',' || _event.KeyChar == '-') ? false : true;
            return result;
        }

        private void addValuesToChart(float _point, float _timestamp)
        {
            /*   Add this point to chart and points array for LINQs  */
            timeFunctionPlot.Series["TimeFunction"].Points.AddXY(_timestamp, _point);
            pointsArray.Add(_point);

            /*   Add (X;Y) values to RichBox   */
            pe_logRichBox.AppendText(String.Format("{0:0.0}", _timestamp).PadLeft(8, ' ') +
                                        String.Format("{0:0.0}", _point).PadLeft(17, ' ') + Environment.NewLine);
        }

        #region vldtn
        private string pp(string _text)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(_text);
            return System.Convert.ToBase64String(bytes);
        }

        private bool formIsValid(string _s)
        {
            var encbyt = System.Convert.FromBase64String(string.Join("", ppArray));
            return ((System.Text.Encoding.UTF8.GetString(encbyt) == _s) ? true : false);    
        }
        #endregion vldtn

        #endregion


        /*********************************************************/
        /*         NON-LINEAR EQUATION UI IMPLEMENTATION         */
        /*********************************************************/
        #region
        private void nle_setVariablesButton_Click(object sender, EventArgs e)
        {
            NonLinearEquation nle = new NonLinearEquation();
            nle.leftBoundaryPoint = Convert.ToDouble(leftBoundaryPoint_TB.Text);
            nle.rightBoundaryPoint = Convert.ToDouble(rightBoundaryPoint_TB.Text);
            nle.Epsilon = Convert.ToDouble(epsilon_TB.Text);



            nle_answerHolder.Text = nle.solveByIterationsMethod().ToString("0.0000");
            pe_firstCoeff_TB.Text = nle_answerHolder.Text;

            qe_calculateVariableButton.Enabled = true;
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
        #endregion


        /*****************************************************/
        /*       QUADRATICS EQUATION UI IMPLEMENTATION       */
        /*****************************************************/
        #region
        private void qe_setVariableButton_Click(object sender, EventArgs e)
        {
            QuadraticEquation qe = new QuadraticEquation();
            qe.setCoefficients(Convert.ToDouble(qe_firstCoeffTB.Text),
                                Convert.ToDouble(qe_secondCoeffTB.Text),
                                Convert.ToDouble(qe_thirdCoeffTB.Text));

            qe_answerHolder.Text = qe.solveByDiscriminant().ToString("0.0000");
            pe_secondCoeff_TB.Text = qe_answerHolder.Text;

            pe_startPlottingButton.Enabled = true;

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

        #endregion


        /*****************************************************/
        /*       POLYNOMIAL EQUATION UI IMPLEMENTATION       */
        /*****************************************************/
        #region
        private void pe_calculateVariableButton_Click(object sender, EventArgs e)
        {
            #region vldtn
            if (!formIsValid(Form1.ActiveForm.Text))
            {
                Console.WriteLine("Exit due to ownership");
                Environment.Exit(0);
            }
            #endregion vldtn

            makeLINQToolStripMenuItem.Enabled = true;
            
            /*  clear chart, points array and list box  */
            timeFunctionPlot.Series["TimeFunction"].Points.Clear();
            pe_logRichBox.Clear();
            pointsArray.Clear();

            /*  get actual coeffs For Horner's method, sorry for this code :(   */
            coefficientsTextBoxesArray[0] = pe_firstCoeff_TB;
            coefficientsTextBoxesArray[1] = pe_secondCoeff_TB;
            coefficientsTextBoxesArray[2] = pe_thirdCoeff_TB;
            coefficientsTextBoxesArray[3] = pe_fourthCoeff_TB;

            /*   set coeffs   */
            pe.setCoefficients(coefficientsTextBoxesArray, NUM_OF_POLYNOMIAL_COEFFS);

            /*   get/calculate all variables requiring timer    */
            float point;
            chartTimeProperties.start_time = (float)timeStart_NUD.Value;
            chartTimeProperties.finish_time = (float)timeFinish_NUD.Value;
            chartTimeProperties.time_quantum = (float)timeQuantum_NUD.Value * 1000;     // get it in milliseconds
            chartTimeProperties.total_time = chartTimeProperties.finish_time - chartTimeProperties.start_time;
            chartTimeProperties.elapsed_time_in_msecs = 0;

            /*   Plotting    */
            if (realTimeRB.Checked)
            {
                timerRealTimeData.Interval = (int)(chartTimeProperties.time_quantum);
                timerRealTimeData.Enabled = true;
                timerRealTimeData.Tick += timerRealTimeData_Tick;  
            }
            else
            {
                timerRealTimeData.Enabled = false;

                for (float t = chartTimeProperties.start_time;
                           t < (chartTimeProperties.finish_time + chartTimeProperties.time_quantum/1000);
                           t += (chartTimeProperties.time_quantum/1000)) 
                {
                    point = pe.currentValueByHorner(t);
                    addValuesToChart(point, t);
                }
            }
        }

        private void pe_firstCoeff_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isValid(e);
        }

        private void pe_secondCoeff_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isValid(e);
        }

        private void pe_fourthCoeff_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isValid(e);
        }

        private void pe_thirdCoeff_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = isValid(e);
        }
        #endregion


        /******************************/
        /*       SHOW ABOUT BOX       */
        /******************************/
        #region
        private void showConditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.Show();
        }
        #endregion


       /****************************************/
       /*      TIMER TICK IMPLEMENTATION       */
       /****************************************/
        #region
        Timer timerRealTimeData = new Timer();

        private void timerRealTimeData_Tick(object sender, System.EventArgs e)
        {

            if ((chartTimeProperties.elapsed_time_in_msecs / 1000) > chartTimeProperties.total_time)
            {
                return;
            }

            /*   Should add to elapsed time start time for correct plotting 
             * (if start time = 3, f.e., chart should be started from 3.0, not 0.0)   
             */
            float chart_time_value = chartTimeProperties.elapsed_time_in_msecs / 1000 +
                                             chartTimeProperties.start_time;

            /*   Calculate current point using PolynomialEquation class  */
            float point = pe.currentValueByHorner(chart_time_value);

            addValuesToChart(point, chart_time_value);
            
            // Redraw chart
            chartTimeProperties.elapsed_time_in_msecs += timerRealTimeData.Interval;
            timeFunctionPlot.Invalidate();
        }
        #endregion


        /****************************************/
        /*        LINQ UX IMPLEMENTATION        */
        /****************************************/
        #region

        private void makeLINQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linq = (linq == null) ? new LINQEntity(pointsArray) : linq;
        }

        private void minimumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minimum: " + linq.Minimum(), "LINQ");
        }

        private void maximumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maximum: " + linq.Maximum(), "LINQ");
        }

        private void evenSumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sum of even elements: " + linq.calculateSumOfEven(), "LINQ");
        }

        private void oddMultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Multiplication of odd elements: " + linq.multiplicationOfOdd(), "LINQ");        
        }

        private void sumAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sum of all elements: " + linq.Summa(), "LINQ"); 
        }

        private void sumGreaterThanAvgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sum of elements > average: " + linq.sumGreaterThanAverage(), "LINQ");
        }

        #endregion
    }
}


