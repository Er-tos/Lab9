using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            int firstNumber = 0;
            int secondNumber = 0;
            int operationCode = 0;
            int test;
            Console.Write("Введите целое число. X=");
            bool checkFirst = true;
            try
            {
                firstNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.Write("Ошибка! ");
                Console.WriteLine(ex.Message);
                checkFirst = false;
            }
            if (checkFirst)
            {
                Console.Write("Введите целое число. Y=");
                try
                {
                    secondNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Write("Ошибка! ");
                    Console.WriteLine(ex.Message);
                    checkFirst = false;
                }
                if (checkFirst)
                {
                    Console.WriteLine("Введите код операции:");
                    Console.WriteLine("     1 - сложение");
                    Console.WriteLine("     2 - вычитание");
                    Console.WriteLine("     3 - произведение");
                    Console.WriteLine("     4 - частное");
                    try
                    {
                        Console.Write("Ваш выбор: ");
                        operationCode = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Ошибка! ");
                        Console.WriteLine(ex.Message);
                        checkFirst = false;
                    }
                    if (checkFirst)
                    {
                        if (operationCode == 1)
                        {
                            Console.Write("Результат: ");
                            Console.WriteLine(firstNumber + secondNumber);
                        }
                        else if (operationCode == 2)
                        {
                            Console.Write("Результат: ");
                            Console.WriteLine(firstNumber - secondNumber);
                        }
                        else if (operationCode == 3)
                        {
                            Console.Write("Результат: ");
                            Console.WriteLine(firstNumber * secondNumber);
                        }
                        else if (operationCode == 4)
                        {
                            try
                            {
                                test = firstNumber / secondNumber;
                                Console.Write("Результат: ");
                                Console.WriteLine(Math.Round(Convert.ToDouble(firstNumber) / Convert.ToDouble(secondNumber), 2));
                            }
                            catch (Exception ex)
                            {
                                Console.Write("Ошибка! ");
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет операции с указанным номером");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
