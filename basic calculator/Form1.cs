using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_calculator
{
    public partial class Form1 : Form
    {
        string display = "";
        Memory c = new Memory();
        bool goBack = true;// whether go back is allowed or not
        string prevClick= "";
        string operand = "";
        bool op1=false;//test for whether op1 has been set
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Handler(object sender, EventArgs e)
        {
            if (sender == btn1) { operand = operand + "1"; prevClick = "1"; display = display + "1"; }
            else if (sender == btn2) { operand = operand + "2"; prevClick = "2"; display = display + "2"; }
            else if (sender == btn3) { operand = operand + "3"; prevClick = "3"; display = display + "3"; }
            else if (sender == btn4) { operand = operand + "4"; prevClick = "4"; display = display + "4"; }
            else if (sender == btn5) { operand = operand + "5"; prevClick = "5"; display = display + "5"; }
            else if (sender == btn6) { operand = operand + "6"; prevClick = "6"; display = display + "6"; }
            else if (sender == btn7) { operand = operand + "7"; prevClick = "7"; display = display + "7"; }
            else if (sender == btn8) { operand = operand + "8"; prevClick = "8"; display = display + "8"; }
            else if (sender == btn9) { operand = operand + "9"; prevClick = "9"; display = display + "9"; }
            else if (sender == btn0) { operand = operand + "0"; prevClick = "0"; display = display + "0"; }
            else if (sender == btnDecimal) { operand = operand + "."; prevClick = "."; display = display + "."; }
            else if (sender == btnSign) { prevClick = "sign"; operand = sign1(); }
            else if (sender == btnDivide) { prevClick = "/"; setOp1("/"); operand = ""; }//operands are set as completed
            else if (sender == btnMultiply) { prevClick = "*"; setOp1("*"); operand = ""; }
            else if (sender == btnSub) { prevClick = "-"; setOp1("-"); operand = ""; }
            else if (sender == btnAdd) { prevClick = "+"; setOp1("+"); operand = ""; }
            else if (sender == btnEquals) { Equals(); } //set Operand 2, calculate answer.
            else if (sender == btnMC) MC(); 
            else if (sender == btnMPlus) MPlus(); 
            else if (sender == btnMR) MR();
            else if (sender == btnMS) MS() ;

                goBack = true;
            txtDisplay.Text = display;
            }

        private void MS()
        {
            if (dataValidationA())
            {
                decimal s = Decimal.Parse(operand, System.Globalization.NumberStyles.Number);
                c.MemoryStore(s);
                MessageBox.Show("s is " + s +" memory has: "+c.Mem);
                goBack = false;
            }
            
        }

        private void MR()// 
        {
            if (op1 && prevClick== "=")
            {
                c.Op1 = c.MemoryRecall();
                operand = c.MemoryRecall().ToString();
                display = operand;
                goBack = false;
            }
            else if(op1)
            {
                c.Op2 = c.MemoryRecall();//if operator 1 has been set, set operator 2 to memory value
                operand = c.MemoryRecall().ToString();
                display = c.Op1.ToString() + c.Operation.ToString() + c.Op2.ToString();
                goBack = false;
            }
            else
            {
                c.Op1 = c.MemoryRecall();
                operand = c.MemoryRecall().ToString();
                display = operand;
                goBack = false;
            }

            //operand = c.Mem.ToString();//where should these two lines of code be? 
            //display = display + operand;
        }

        private void MPlus()
        {
            if (dataValidationA())
            {
                c.MemoryAdd(Decimal.Parse(operand, System.Globalization.NumberStyles.Number));
                goBack = false;
            }
        }

        private void MC()
        {
            c.MemoryClear();
            goBack = false;
        }

        private string sign1()
        {
            decimal op = 0;
           if (dataValidationA())
            {
                //MessageBox.Show("operand is "+operand);
                op = Decimal.Parse(operand, System.Globalization.NumberStyles.Number);
                op = op * -1;
                display = display.Replace(operand, op.ToString());//replace previous operand with new one
                operand = op.ToString();
                goBack = false;//undo by clicking sign button again
            }

            return operand;
        }
        private void setOp1(string Operator)
        {
            if (dataValidationA())//make sure decimal can be safely parsed
            {
                Decimal a = Decimal.Parse(display, System.Globalization.NumberStyles.Number);
                c.Op1 = a;
                c.Operation = Operator;
                display = c.Op1.ToString()+Operator;
                operand = "";
                op1 = true;
            }
        }
        private bool dataValidationA()//tests for null and decimal format
        {
            try
            {
                Decimal a = Decimal.Parse(operand, System.Globalization.NumberStyles.Number);//implicity checks for null values also
                
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number.", "Entry Error");
                return false;
            }
        }
        private void Calculate()
        {
            //MessageBox.Show("Value of Op1: "+c.Op1+" Value of Operation: "+c.Operation+" Value of Op2: "+ c.Op2);
            c.Op2 = Decimal.Parse(operand);
            display = c.Equals().ToString();
            txtDisplay.Text = display;
            goBack = false;
            prevClick = "=";
            operand = display;//check this line for logic.  After completing, operand is -12
        }

        private void EqualsAgain()
        {
            try
            {
                //MessageBox.Show("op1: "+c.Op1+" operation: "+c.Operation+" op2: "+c.Op2);
                display = c.Equals().ToString();
                txtDisplay.Text = display;
                goBack = false;
                prevClick = "=";
                operand = display;
            }
            catch (OverflowException) { MessageBox.Show("The Answer is too big"); }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            display = "";
            operand = "";
            c.AllClear();
            prevClick = "";
            op1 = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (goBack)//allowed to go back if calculation has not been completed.
            {
                if (display.Length > 0)
                {
                    display = display.Remove(display.Length - 1);//take last entry off
                    operand = operand.Remove(display.Length - 1);
                    txtDisplay.Text = display;
                }
            }
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (dataValidationA())
            {
                c.Op1 = Decimal.Parse(operand, System.Globalization.NumberStyles.Number);
                if (c.Op1 >= 0)
                {
                    display = c.Sqrt().ToString();
                    txtDisplay.Text = display;
                    goBack = false;
                    prevClick = "sq";
                }
                else MessageBox.Show("Cannot take the squareroot of a negative number.");
            }
        }
        private void Reciprocal_Click(object sender, EventArgs e)
        {
            if (dataValidationA()&& operand !="0")
            {
                c.Op1 = Decimal.Parse(operand, System.Globalization.NumberStyles.Number);
                display = c.Reciprocal().ToString();
                txtDisplay.Text = display;
                goBack = false;
                prevClick = "r";
            }
            else if (operand=="0") //if operand is 0, error message
            {
                MessageBox.Show("Cannot calculate Reciprocal of 0.", "Calculation Error");
            }
        }
        
        private void Equals()
        {
            if (NotDivideByZero() && isNotNull() && op1)
            {
                if (prevClick != "=") { Calculate(); }
                else if (prevClick == "=") { EqualsAgain(); }
            }
            else MessageBox.Show("Please enter an operator and a second operand.");
        }

        private bool AllSet()
        {
            throw new NotImplementedException();
        }

        private bool isNotNull()
        {
            if (operand != "") return true;
            else { MessageBox.Show("Please enter a number", "Entry Error"); return false; }
        }


        private bool NotDivideByZero()
        {
            if (operand=="0" && c.Operation=="/")//check for divide by zero
            {
                MessageBox.Show("Cannot Divide by Zero");
                return false;//divide by zero, so fails data validation
            }
            return true;//if above condition not met
        }
    }
}
