using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        // operator precedence
        static int PreCedence(char op)
        {
            switch (op) 
            {
                case '*':
                case '/':
                    return 1;
                case '+':
                case '-':
                    return 2;
                default:
                    return 0;

            }

        }

        // Process operator
        static void ProcessOperator(Stack<double> val, Stack<char> operators)
        {
            if (operators.Count > 0)
               { 
                char op = operators.Pop();
                double b = val.Pop();
                double a = val.Pop();
                switch (op)
                {
                    case '+':
                        val.Push(a + b);
                        break;
                    case '-':
                        val.Push(a - b);
                        break;
                    case '*':
                        val.Push(a * b);
                        break;
                    case '/':
                        if (b == 0)
                            throw new DivideByZeroException("Division by zero error");
                        val.Push(a / b);
                        break;
                    default:
                        throw new ArgumentException("Invalid operator");

                }
            }
        }

        static double Calculator(string[] token)
        {
            Stack<double> val = new Stack<double>();
            Stack<char> op = new Stack<char>();

            foreach(string i in token)
            {
                if (i == "")
                {
                    continue;
                }
                // if it is a number, push into stack
                if (double.TryParse(i, out double number))
                {
                    val.Push(number);
                }
                else if (i == "(")
                {
                    op.Push(i[0]);
                }
                else if (i == ")")
                {
                    while(op.Peek() != '(')
                    {
                        ProcessOperator(val, op); 
                    } 
                    op.Pop();// delete '('
                }
                else
                {
                    while(op.Count > 0 && PreCedence(op.Peek()) >= PreCedence(i[0]))
                    {
                        ProcessOperator(val, op); 
                    }
                    op.Push(i[0]);
                }
            }
            while(op.Count > 0)
                { 
                ProcessOperator(val, op);
                }
            return val.Pop();
        }

        private void RFile_Click(object sender, EventArgs e)
        {
            try
            {
                using(StreamReader sr = new StreamReader("input3.txt"))
                {
                    string content = sr.ReadToEnd();
                    richTextBox1.Text = content;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        static void Divideoperand(Stack<double> numbers, Stack<char> operators)
        {  

        }

        

        private void WFile_Click(object sender, EventArgs e)
        { 
            try
            {
                using (StreamWriter sw = new StreamWriter("output3.txt"))
                {
                        string[] lines = File.ReadAllLines("input3.txt");
                        foreach (string line in lines)
                        {
                        string[] tokens = Regex.Split(line, @"([()*/+-])").Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
                        double result = Calculator(tokens);
                        sw.WriteLine($"{line} = {result}");
                        }
                }
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
