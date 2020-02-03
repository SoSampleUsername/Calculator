using System;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool calculation = true;
            while (calculation == true) 
            {
                Console.WriteLine("Enter a number:");
                string value1 = Console.ReadLine();
                double value11 = 0;
                bool check1 = true;
                while (check1)
                {
                    if (!double.TryParse(value1, out value11))
                    {
                        Console.WriteLine("Enter a number:");
                        value1 = Console.ReadLine();
                    }
                    else
                    {
                        check1 = false;
                    }
                }
                Number_two:
                Console.WriteLine("Enter a second number:");
                string value2 = Console.ReadLine();
                double value21 = 0;
                bool check2 = true;
                while (check2)
                {
                    if (!double.TryParse(value2, out value21))
                    {
                        Console.WriteLine("Enter a second number:");
                        value2 = Console.ReadLine();
                    }
                    else
                    {
                        check2 = false;
                    }
                }
                Console.WriteLine("Enter an operation (+,-,/,*,^):");
                string Operation = Console.ReadLine();
                double value3=0;
                bool action = true;
                while (action)
                {
                    if (Operation == "+")
                    {
                        value3 = value11 + value21;
                        Console.WriteLine($"Result: {value3}");
                        action = false;

                    }
                    else if (Operation == "-")
                    {
                        value3 = value11 - value21;
                        Console.WriteLine($"Result: {value3}");
                        action = false;

                    }
                    else if (Operation == "^")
                    {
                        value3 = Math.Pow(value11, value21);
                        Console.WriteLine($"Result: {value3}");
                        action = false;

                    }
                    else if (Operation == "/")
                    {
                        while (value2 == "0")
                        {
                            Console.WriteLine("You can't divide by zero. Enter an another number:");
                            value2 = Console.ReadLine();
                            bool check3 = true;
                            while (check3)
                            {
                                if (!double.TryParse(value2, out value21))
                                {
                                    Console.WriteLine("Enter an another number:");
                                    value2 = Console.ReadLine();
                                }
                                else
                                {
                                    check3 = false;
                                }
                            }
                        }
                        value3 = value11 / value21;
                        Console.WriteLine($"Result: {value3}");
                        action = false;
                    }
                    else if (Operation == "*")
                    {
                        value3 = value11 * value21;
                        Console.WriteLine($"Result: {value3}");
                        action = false;

                    }
                    else if (Operation != "*" || Operation != "-" || Operation != "+" || Operation != "/")
                    {
                        Console.WriteLine("You should enter given operations ");
                        Console.WriteLine("Enter an operation (+,-,/,*):");
                        Operation = Console.ReadLine();
                    }
                    else
                    {
                        action = false;
                    }
                end_question:
                Console.WriteLine("Enter a number what do you want to do?\n1)Start calculations over\n2)Continue calculations with previous result\n3)Find sqrt\n4)Exit");                
                string end_question = Console.ReadLine();
                double q1 = 0;
                bool forWhileQ = true;                    
                    while (forWhileQ)
                    {
                        if (!double.TryParse(end_question, out q1))
                        {
                            Console.WriteLine("Enter a number what do you want to do?\n1)Start calculations over\n2)Continue calculations with previous result\n3)Find sqrt\n4)Exit");
                            end_question = Console.ReadLine();
                        }
                        else if (q1 == 1)
                        {
                            forWhileQ = false;
                            calculation = true;
                        }
                        else if (q1 == 2)
                        {
                            forWhileQ = false;                            
                            value11 = value3;
                            calculation = true;
                            goto Number_two;
                        }
                        else if (q1 == 3)
                        {
                            if (value3 < 0)
                            {
                                Console.WriteLine("Sqrt cannot have negative const");
                                goto end_question;
                            }
                            else
                            {
                                Console.WriteLine($"Result: {Math.Sqrt(value3)}");
                                goto end_question;
                            }                                
                        }
                        else if (q1 == 4)
                        {
                            calculation = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter a number what do you want to do?\n1)Start calculations over\n2)Continue calculations with previous result\n3)Find sqrt\n4)Exit");
                            end_question = Console.ReadLine();
                        }
                    }                     
                }
            }
        }
    }
}