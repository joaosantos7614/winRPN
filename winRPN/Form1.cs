using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winRPN
{
    public partial class Form1 : Form
    {

        double inputNr; // the input string after converted to numeric value 
        Stack<double> nrStack = new(); // creates the stack that will store the operands
        bool isResult=false; // keeps track if the value on in/out box is an input or an output
        public Form1()
        {
            InitializeComponent();
            inputBox.Text = "0"; // initializes the inputBox with a 0
            
        }

        private void btn_Click(object sender, EventArgs e) // numbers 0 to 9
        {
            if (isResult == true)
                btnEnter_Click(new object(), new EventArgs()); // simulates a press of the Enter button
            if (inputBox.Text == "0")
                inputBox.Text = "";
            Button button = (Button)sender;
            inputBox.Text = inputBox.Text + button.Text;
        }
        private void btnDot_Click(object sender, EventArgs e) // DOT
        {
            if (isResult == true)
                btnEnter_Click(new object(), new EventArgs()); // simulates a press of the Enter button
            inputBox.Text = inputBox.Text + ".";
        }
        private void btnClear_Click(object sender, EventArgs e) // CLEAR
        {
            if (inputBox.Text!="0")
            {
                inputBox.Text = "0";
            }
            else if(nrStack.Count>0)
            {
                nrStack.Pop();
                UpdateStackBox();
            }
            isResult = false;
        }

        private void btnEnter_Click(object sender, EventArgs e) // ENTER
        {
            if (inputBox.Text != "-") // protects agains pressing enter when only - is inputed
            {
                inputNr = Convert.ToDouble(inputBox.Text);
                inputBox.Text = "0";
                nrStack.Push(inputNr);
                UpdateStackBox();
                isResult = false;
            }
        }
        
        private void btnPlus_Click(object sender, EventArgs e) // ADD
        {
            if (nrStack.Count>0)
            {
                inputNr = Convert.ToDouble(inputBox.Text);
                inputBox.Text = Convert.ToString(inputNr + nrStack.Pop());
                UpdateStackBox();
                isResult = true;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e) // MULTIPLY
        {
            if (nrStack.Count > 0)
            {
                inputNr = Convert.ToDouble(inputBox.Text);
                inputBox.Text = Convert.ToString(inputNr * nrStack.Pop());
                UpdateStackBox();
                isResult = true;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e) // DIVIDE
        {
            inputNr = Convert.ToDouble(inputBox.Text);
            if (inputNr != 0 && nrStack.Count>0)
            {
                inputBox.Text = Convert.ToString( nrStack.Pop()/ inputNr );
                UpdateStackBox();
                isResult = true;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e) // SUBTRACT
        {
            if (inputBox.Text=="0")
            {
                inputBox.Text = "-";
            }
            else if (nrStack.Count > 0)
            {
                inputNr = Convert.ToDouble(inputBox.Text);
                inputBox.Text = Convert.ToString(nrStack.Pop()- inputNr);
                UpdateStackBox();
                isResult = true;
            }
            
        }
        private void UpdateStackBox() // UPDATE STACK TEXT BOXES
        {
            if (nrStack.Count > 0)
                stackBox0.Text = Convert.ToString(nrStack.ElementAt(0));
            else
                stackBox0.Text = "";
            if (nrStack.Count >= 2)
                stackBox1.Text = Convert.ToString(nrStack.ElementAt(1));
            else
                stackBox1.Text = "";
            if (nrStack.Count > 2)
                stackBox2.Text = Convert.ToString(nrStack.ElementAt(2));
            else
                stackBox2.Text = "";
        }
    }
}
