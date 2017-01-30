using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace COMP1004_W2017_Lesson4
{
    public partial class CalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private string _operand1;
        private string _operand2;
        private bool _isCalculatorClear;

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();

            this._clearCalculator();
        }

        /// <summary>
        /// This method clears the calculator app and resets the variables
        /// </summary>
        private void _clearCalculator()
        {
            this._operand1 = "";
            this._operand2 = "";
            this._isCalculatorClear = true;
            ResultTextBox.Text = "0";
        }


        /// <summary>
        /// Event Handler for all Calculator Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            Button CalculatorButton = sender as Button;

            switch (CalculatorButton.Tag.ToString())
            {
                case "Operand":
                    if (this._isCalculatorClear)
                    {
                        ResultTextBox.Text = CalculatorButton.Text;
                        this._isCalculatorClear = false;
                    }
                    else
                    {
                        ResultTextBox.Text += CalculatorButton.Text;
                    }
                    break;
                case "Operator":
                    break;
                case "Other":
                    break;
            }
        }
    }
}
