using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator0
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((Text_Output.Text == "0") || (isOperationPerformed))
                Text_Output.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            double pi = 3.14;
            if (button.Text == "π")
            {
                if (!Text_Output.Text.Contains("3.14"))
                    Text_Output.Text = Text_Output.Text + pi;
            }
            else
            {
                if (button.Text == ".")
                {
                    if (!Text_Output.Text.Contains("."))
                        Text_Output.Text = Text_Output.Text + button.Text;

                }
                else
                    Text_Output.Text = Text_Output.Text + button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
             if (resultValue !=0)
            {
                Btn_Eql.PerformClick();
                operationPerformed = button.Text;
                Lbl_Chc.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
                

            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(Text_Output.Text);
                Lbl_Chc.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }
        private void Button__Ce(object sender, EventArgs e)
        {
            Text_Output.Text = "0";
        }
        private void button_clear(object sender, EventArgs e)
        {
            Text_Output.Text = "0";
            resultValue=0;
        }


        private void button_equal(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    Text_Output.Text = (resultValue + Double.Parse(Text_Output.Text)).ToString();
                    break;
                case "-":
                    Text_Output.Text = (resultValue - Double.Parse(Text_Output.Text)).ToString();
                    break;
                case "*":
                    Text_Output.Text = (resultValue * Double.Parse(Text_Output.Text)).ToString();
                    break;
                case "/":
                    Text_Output.Text = (resultValue / Double.Parse(Text_Output.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(Text_Output.Text);
            Lbl_Chc.Text = "";
        }

       

        
    }
}
