using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.BitwiseCalc
{
    class Program
    {
        delegate int DelBinOP(int a, int b);
        delegate int DelUriOP(int a);

        static void Main(string[] args)
        {
        	Console.ForegroundColor = ConsoleColor.Green;
            int option = 0;
            string soption = "0";
            do
            {
                try
                {
                    string[] options = { "& AND", "| OR", "^ Exclusive OR", "~ NOT", "<< Shift Left", ">> Shift Right" };
                    Utilities.ShowMenu("BITWISE OPERATIONS", options);
                    soption = Utilities.Scanf("Please enter your choice: ");
                    Int32.TryParse(soption,out option);
                    if(soption.Equals("0"))
                    	System.Environment.Exit(0);
                    Utilities.PrintMessage("You choose " + options[option - 1]);
                    switch (soption)
                    {
                        case "1":
                            BinaryOp((a, b) => a & b);
                            break;
                        case "2":
                            BinaryOp((a, b) => a | b);
                            break;
                        case "3":
                            BinaryOp((a, b) => a ^ b);
                            break;
                        case "4":
                            UnaryOp(a => ~a);
                            break;
                        case "5":
                            ShiftOp((a, b) => a << b);
                            break;
                        case "6":
                            ShiftOp((a, b) => a >> b);
                            break;
                        default:
                            Console.WriteLine("\tPlease choose an option!");
                            break;

                    }
                   
                }
                catch (Exception ex)
                {
                    Utilities.PrintMessage(ex.Message);
                }
            } while (!soption.Equals("0"));
            
        }

        static void BinaryOp(DelBinOP del)
        {
        	int op1,op2;
        	var soperator1 = Utilities.Scanf("Enter first integer:");
            Int32.TryParse(soperator1, out op1);
            var soperator2 = Utilities.Scanf("Enter second integer:");
            Int32.TryParse(soperator2, out op2);
            int resp = del(op1, op2);
            Console.WriteLine();
            Utilities.DisplayBinary(op1);
            Utilities.DisplayBinary(op2);
            Console.WriteLine("\t Result: ");
            Utilities.DisplayBinary(resp);
            Utilities.Pause();
        }

        static void ShiftOp(DelBinOP del)
        {
        	int op1,op2;
        	var soperator1 = Utilities.Scanf("Enter first integer:");
            Int32.TryParse(soperator1, out op1);
            var soperator2 = Utilities.Scanf("Enter second integer:");
            Int32.TryParse(soperator2, out op2);
            int resp = del(op1, op2);
            resp = del(op1, op2);
            Console.WriteLine();
            Utilities.DisplayBinary(op1);
            Console.WriteLine("\t Result: ");
            Utilities.DisplayBinary(resp);
            Utilities.Pause();
        }

        static void UnaryOp(DelUriOP del)
        {
        	int op1;
        	var soperator1 = Utilities.Scanf("Enter first integer:");
            Int32.TryParse(soperator1, out op1);
            int resp;
            resp = del(op1);
            Console.WriteLine();
            Utilities.DisplayBinary(op1);
			Console.WriteLine("\t Result: ");            
            Utilities.DisplayBinary(resp);
            Utilities.Pause();
        }

    }
}
