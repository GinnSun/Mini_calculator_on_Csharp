using System;
using System.Globalization;

namespace Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("First number: ");
            string num1 = Console.ReadLine(); ;
            Console.WriteLine("Second numbe: ");
            string num2 = Console.ReadLine(); ;
            Console.WriteLine("Thrid number");
            string num3 = Console.ReadLine(); ;
            if (num3 == "" || num3 == " ")
            {
                Console.WriteLine("Choose what you want to do with your numbers?");
                Console.WriteLine("1.addition 2.subtraction 3.division 4.multiply 5. division by modulo");
                string choice = Console.ReadLine(); ;
                if (choice == "1")
                {
                    NumberFormatInfo numberFormatinfo = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };
                    try
                    {
                        double number1 = double.Parse(num1, numberFormatinfo), number2 = double.Parse(num2, numberFormatinfo);
                        double result = number1 + number2;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong number entry, close the program and try again!");
                    }
                }
                if (choice == "2")
                {
                    NumberFormatInfo numberFormatinfo = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };
                    try
                    {
                        double number1 = double.Parse(num1, numberFormatinfo), number2 = double.Parse(num2, numberFormatinfo);
                        double result = number1 - number2;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong number entry, close the program and try again!");
                    }
                }
                if (choice == "3")
                {
                    NumberFormatInfo numberFormatinfo = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };
                    try
                    {
                        double number1 = double.Parse(num1, numberFormatinfo), number2 = double.Parse(num2, numberFormatinfo);
                        double result = number1 / number2;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong number entry, close the program and try again!");
                    }
                }
                if (choice == "4")
                {
                    NumberFormatInfo numberFormatinfo = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };
                    try
                    {
                        double number1 = double.Parse(num1, numberFormatinfo), number2 = double.Parse(num2, numberFormatinfo);
                        double result = number1 * number2;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong number entry, close the program and try again!");
                    }
                }
                if (choice == "5")
                {
                    NumberFormatInfo numberFormatinfo = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };
                    try
                    {
                        double number1 = double.Parse(num1, numberFormatinfo), number2 = double.Parse(num2, numberFormatinfo);
                        double result = number1 % number2;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong number entry, close the program and try again!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Choose what you want to do with your numbers?");
                Console.WriteLine("1.addition 2.subtraction 3.division 4.multiply 5. division by modulo");
                string choice_for_three_num = Console.ReadLine(); ;
                if (choice_for_three_num == "1")
                {
                    NumberFormatInfo numberFormatinfo = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };
                    try
                    {
                        double number1 = double.Parse(num1, numberFormatinfo), number2 = double.Parse(num2, numberFormatinfo), number3 = double.Parse(num3, numberFormatinfo);
                        double result = number1 + number2 + number3;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong number entry, close the program and try again!");
                    }
                }
                if (choice_for_three_num == "2")
                {
                    NumberFormatInfo numberFormatinfo = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };
                    try
                    {
                        double number1 = double.Parse(num1, numberFormatinfo), number2 = double.Parse(num2, numberFormatinfo), number3 = double.Parse(num3, numberFormatinfo);
                        double result = number1 - number2 - number3;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong number entry, close the program and try again!");
                    }
                }
                if (choice_for_three_num == "3")
                {
                    NumberFormatInfo numberFormatinfo = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };
                    try
                    {
                        double number1 = double.Parse(num1, numberFormatinfo), number2 = double.Parse(num2, numberFormatinfo), number3 = double.Parse(num3, numberFormatinfo);
                        double result = number1 / number2 / number3;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong number entry, close the program and try again!");
                    }

                }
                if (choice_for_three_num == "4")
                {
                    NumberFormatInfo numberFormatinfo = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };
                    try
                    {
                        double number1 = double.Parse(num1, numberFormatinfo), number2 = double.Parse(num2, numberFormatinfo), number3 = double.Parse(num3, numberFormatinfo);
                        double result = number1 * number2 * number3;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong number entry, close the program and try again!");
                    }
                }
                if (choice_for_three_num == "5")
                {
                    NumberFormatInfo numberFormatinfo = new NumberFormatInfo()
                    {
                        NumberDecimalSeparator = ".",
                    };
                    try
                    {
                        double number1 = double.Parse(num1, numberFormatinfo), number2 = double.Parse(num2, numberFormatinfo), number3 = double.Parse(num3, numberFormatinfo);
                        double result = number1 * number2 * number3;
                        Console.WriteLine("Result: " + result);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong number entry, close the program and try again!");
                    }
                }
            }
        }
    }
}