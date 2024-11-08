using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections.Generic;



namespace algorthms_c_sharp;
// C# code​​​​​​‌‌​​​​​‌​‌​​​​​‌‌‌‌‌​‌​‌‌ below
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Write your answer here, and then test your code.
// Your job is to implement the EvaluateRPN() method.

public class Answer {

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
   public  static Boolean ShowExpectedResult = false;
   public  static Boolean ShowHints = false;

    public static bool IsNumber(string token)
    {
        try
        {
            double.Parse(token);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    public static bool IsOperator(string token)
    {
        return "+-*/".Contains(token);
    }

    public static double PerformOperation(string @operator, double operand1, double operand2)
    {
        switch (@operator)
        {
            case "+":
                return operand1 + operand2;
            case "-":
                return operand1 - operand2;
            case "*":
                return operand1 * operand2;
            case "/":
                if (operand2 == 0)
                {
                    throw new DivideByZeroException("Division by zero is not allowed.");
                }
                return operand1 / operand2;
            default:
                throw new ArgumentException("Invalid operator: " + @operator);
        }
    }

     // Return the result of the Reverse Polish notation expression
    public static double EvaluateRPN(string expression) {
        string[] arr = expression.Split(' ');
        Stack<double> stack = new Stack<double>();
        double res = 0;
        foreach(string token in arr)
        {
            if (IsNumber(token.ToString()))
            {
                double t = Convert.ToDouble(token);
                stack.Push(t);
            }
            else if (IsOperator(token.ToString()))
            {
                double pop2 = stack.Pop();
                double pop1 = stack.Pop();
                res = PerformOperation(token, pop1, pop2);
                stack.Push(res);
            }
        }

        // Your code goes here.
        return res;
    }

}

class ReversePolish
{
    public ReversePolish()
    {
        Console.WriteLine("reverse polish");
    }

    private int Calculate(string expression)
    {   
        Stack<int> st = new Stack<int>();
        
        return st.Pop();
    }

}