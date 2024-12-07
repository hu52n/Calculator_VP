using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        string first = "";
        string second = "";
        char function; 
        double result = 0.0;
        string userInput="";


        public Calculator()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            DisplaySecreen.Text = "";
            userInput += "0";
            DisplaySecreen.Text += userInput;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DisplaySecreen.Text = "";
            userInput += "1";
            DisplaySecreen.Text += userInput;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            DisplaySecreen.Text = "";
            userInput += "2";
            DisplaySecreen.Text += userInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DisplaySecreen.Text = "";
            userInput += "3";
            DisplaySecreen.Text += userInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            DisplaySecreen.Text = "";
            userInput += "4";
            DisplaySecreen.Text += userInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            DisplaySecreen.Text = "";
            userInput += "5";
            DisplaySecreen.Text += userInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            DisplaySecreen.Text = "";
            userInput += "6";
            DisplaySecreen.Text += userInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            DisplaySecreen.Text = "";
            userInput += "7";
            DisplaySecreen.Text += userInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            DisplaySecreen.Text = "";
            userInput += "8";
            DisplaySecreen.Text += userInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DisplaySecreen.Text = "";
            userInput += "9";
            DisplaySecreen.Text += userInput;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput= "";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first); //الفرق بين بارس و كنفيرت  
            secondNum = Convert.ToDouble(second);
            //Add
            if (function == '+')
            {
                result = firstNum + secondNum;
                DisplaySecreen.Text = result.ToString();
            }
            //Subtract
            else if (function == '-')
            {
                result = firstNum - secondNum ;
                DisplaySecreen.Text = result.ToString();
            }
            //Multiplication
            else if (function == '*')
            {
                result = firstNum * secondNum;
                DisplaySecreen.Text = result.ToString();
            }
            //Divion
            else if (function == '/')
            {
                if (secondNum == 0)
                {
                    DisplaySecreen.ForeColor = Color.Red;
                    DisplaySecreen.Font = new Font(DisplaySecreen.Font.FontFamily, 20); // 20 is the font size
                    DisplaySecreen.Text = "Can not divid by zero";
                    
                }
                else if (secondNum != 0)
                {
                    DisplaySecreen.ForeColor = Color.White;
                    DisplaySecreen.Font = new Font(DisplaySecreen.Font.FontFamily, 30);
                }
                else
                {
                    result = firstNum / secondNum;
                    DisplaySecreen.Text = result.ToString();
                }
            }
            
            userInput = "";


        }

        private void btndot_Click(object sender, EventArgs e)
        {
            DisplaySecreen.Text = "";   //
            userInput += ".";
            DisplaySecreen.Text += userInput;
        }

        private void btnCancelALL_Click(object sender, EventArgs e)
        {
           // function = '\0'; 
            first = userInput;
            userInput = "";
            result = 0.0;
            DisplaySecreen.Text = "0";
        }

        private void btnCancelOne_Click(object sender, EventArgs e)
        {


        }
    }
}
