using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
  char again = 'y';
                while (again == 'y')
            {
                double total;
                Console.WriteLine("Введите первое число");
                var a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите оператор");
                var oper = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                var b = Convert.ToDouble(Console.ReadLine());
                if (oper == '+')
                {
                    total = a + b;
                    Console.WriteLine($"Сумма {a} и {b} равна {total}.");
                }
                    else if (oper == '-')
                    {
                        total = a - b;
                        Console.WriteLine($"Разность {a} и {b} равна {total}.");
                    }
                        else if (oper == '*')
                        {
                            total = a * b;
                            Console.WriteLine($"Произведение {a} и {b} равно {total}.");
                        }
                            else if (oper == '/')
                            {
                                total = a / b;
                                Console.WriteLine($"Частное от деления {a} на {b} равно {total}.");
                            }
                                
                    else
                    {
                        Console.WriteLine("Неучтённый оператор");
                    }
                Console.WriteLine("Хотите продолжить работу с программой? (y/n)");
                again = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
