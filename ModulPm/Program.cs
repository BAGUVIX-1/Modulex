using System;
using System.Diagnostics;
using System.IO;

namespace ModulPm
{
    public class Program
    {
        /// <summary>
        /// Выполнение основных функций калькулятора 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Какое действие выберите? \n1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление");
                try //Добавление конструкции TryCatch для защиты от ввода букв
                {
                    StreamWriter sw = new StreamWriter("debuginfo.txt");//Запись Debug-информации в файл "debuginfo.txt"
                    sw.WriteLine("У пользователя появилось приветственное сообщение");
                    Debug.WriteLine("Пользователь получил сообщение о выборе действия");

                    char choice = '0'; //Объявление переменной Choice
                    double a = 0; //Объявление переменной a
                    double b = 0; //Объявление переменной b
                    double result = 0;

                    choice = Convert.ToChar(Console.ReadLine());
                    Debug.WriteLine("Пользователь выбрал действие");
                    sw.WriteLine("Пользователь выбрал действие");       
                    
                    Console.WriteLine("Введите первое число:");
                    a = Convert.ToDouble(Console.ReadLine()); //Пользователь вводит первое число
                    Debug.WriteLine("Пользователь ввел первое число");
                    sw.WriteLine("Пользователь ввел первое число");

                    Console.WriteLine("Введите второе число:");
                    b = Convert.ToDouble(Console.ReadLine()); //Пользователь вводит второе число
                    Debug.WriteLine("Пользователь ввел второе число");
                    sw.WriteLine("Пользователь ввел второе число");

                    result = 0;
                    Methods methods = new Methods();
                    if (choice == '1')
                    {
                        result = methods.Amount(a, b); //Вызов метода Amount при выборе сложения
                    }
                    else if (choice == '2')
                    {
                        result = methods.Subtraction(a, b);//Вызов метода Subtraction при выборе вычитания
                    }
                    else if (choice == '3')
                    {
                        result = methods.Multiplication(a, b);//Вызов метода Multiplication при выборе умножения
                    }
                    else if (choice == '4')
                    {
                        result = methods.Divide(a, b);//Вызов метода Divide при выборе деления
                    }
                    else
                    {
                        Console.WriteLine("Пожалуйста, введите значение от 1 до 4");
                    }
                    Console.WriteLine($"Результат: {result}");
                    Debug.WriteLine("Пользователь получил результат");
                    sw.WriteLine("Пользователь получил результат");
                    sw.Close();
                }
                catch
                {
                    Console.WriteLine("Пожалуйста, вводите только цифры, нажмите кнопку для продолжения работы");
                }
                Console.ReadKey();
            }
        }
    }
}