using System;
// Создайть проект по шаблону Console Application. 
// Написать программу - консольный калькулятор. 
// Создать две переменные с именами operand1 и operand2 с произвольными значениями.
// Предложить пользователю ввести знак арифметической операции. Примите 
// значение, введенное пользователем, и поместите его в строковую переменную sign. 
// Для организации выбора алгоритма вычислительного процесса, использовать переключатель switch. 
// Вывести на экран результат выполнения арифметической операции. 
// В случае использования операции деления, организовать проверку попытки деления на ноль. И если 
// таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке 
//пользователя.

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод и инициализация переменных.
            Console.WriteLine("Введите первое число");
            string myOperand1 = Console.ReadLine();
            double operand1 = Convert.ToDouble(myOperand1);

            Console.WriteLine("Введите второе число");
            string myOperand2 = Console.ReadLine();
            double operand2 = Convert.ToDouble(myOperand2);
            Console.WriteLine("Введите арифметическую операцию");
            char sing = Convert.ToChar(Console.ReadLine());

            // Для организации выбора алгоритма вычислительного процесса, используем переключатель switch-case.
            switch (sing)
            {
                case '+':
                    {
                        Console.WriteLine($"Результат сложения чисел = {operand1 + operand2}");
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine($"Результат вычитания чисел = {operand1-operand2}");
                        break;
                    }
                case '*':
                    {
                    Console.WriteLine($"Результат умножения чисел = {operand1*operand2}");
                        break;
                    }
                case '/':
                    {
                        //Проверка деления на ноль.
                        if (operand2 == 0)
                        {
                            Console.WriteLine($"Ошибка деления на ноль");
                        }
                        Console.WriteLine($"Результат деления чисел = {operand1/operand2}");
                        break;
                    }

            }

            Console.ReadKey();
        }
    }
}
