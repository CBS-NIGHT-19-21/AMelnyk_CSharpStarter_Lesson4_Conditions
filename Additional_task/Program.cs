using System;
// Создать проект по шаблону Console Application. 
// Написать программу русско-английский переводчик. Программа знает 10 слов о погоде. Требуется,
// чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на 
// английском языке. Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести 
// сообщение, что такого слова нет.

namespace Additional_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово о погоде");
            
            //Вод и инициализация переменной.
            string weather = Console.ReadLine();
            // Для перевода введенного слова, используем переключатель switch-case.
            switch (weather)
            {
                case "облако":
                    {
                        Console.WriteLine("Cloud");
                        break;
                    }
                case "туман":
                    {
                        Console.WriteLine("Fog");
                        break;
                    }
                case "солнце":
                    {
                        Console.WriteLine("Sun");
                        break;
                    }
                case "дождь":
                    {
                        Console.WriteLine("Rain");
                        break;
                    }
                case "мороз":
                    {
                        Console.WriteLine("Frost");
                        break;
                    }
                case "снег":
                    {
                        Console.WriteLine("Snow");
                        break;
                    }
                case "ветер":
                    {
                        Console.WriteLine("Wind");
                        break;
                    }
                case "ураган":
                    {
                        Console.WriteLine("Storm");
                        break;
                    }
                case "гроза":
                    {
                        Console.WriteLine("Thunderstorm");
                        break;
                    }
                case "буря":
                    {
                        Console.WriteLine("Hurricane");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Введенное слово отсутствует в словаре");
                        break;
                    }

            }

            Console.ReadKey();
        }
    }
}
