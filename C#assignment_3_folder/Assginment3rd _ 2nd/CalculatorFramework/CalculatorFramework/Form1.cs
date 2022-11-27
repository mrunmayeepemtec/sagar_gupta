using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFramework
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool IsOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void button_click(object sender, EventArgs e)
        {
            if((textBoxResult.Text == "0") || (IsOperationPerformed))
                textBoxResult.Clear();
            IsOperationPerformed = false;

            Button button = (Button)sender;
            textBoxResult.Text = textBoxResult.Text + button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Convert.ToDouble(textBoxResult.Text);
            LabelCurrentOperations.Text = resultValue +" "+operationPerformed;
            IsOperationPerformed = true;


        }

        private void nclear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
        }

        private void n_equal(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;

                case "-":
                    textBoxResult.Text = (resultValue + Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;

                case "*":
                    textBoxResult.Text = (resultValue + Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;

                case "/":
                    textBoxResult.Text = (resultValue + Convert.ToDouble(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;

            }
        }
    }
}
