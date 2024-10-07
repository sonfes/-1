//1 ЧАСТЬ, ЗАДАНИЕ 1
//Субочева Софья Александровна
//группа 24ИС11-1

namespace Sonfes_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("one number:");
            double one1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("two number:");
            double two1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("three number:");
            double three1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("four number:");
            double four1 = Convert.ToDouble(Console.ReadLine());

            double SredZnach = (one1 + two1 + three1 + four1) / 4;

            Console.WriteLine(SredZnach);
            */



            //1 ЧАСТЬ, ЗАДАНИЕ 2


            /*
            Console.WriteLine("Простой калькулятор");

            Console.Write("Введите первое число: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Выбор действия
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Нахождение остатка(оператор %)");
            Console.Write("Введите номер действия (1-5): ");
            int action = Convert.ToInt32(Console.ReadLine());

            double result;

            switch (action)
            {
                case 1:
                    result = number1 + number2;
                    Console.WriteLine($"Результат: {number1} + {number2} = {result}");
                    break;
                case 2:
                    result = number1 - number2;
                    Console.WriteLine($"Результат: {number1} - {number2} = {result}");
                    break;
                case 3:
                    result = number1 * number2;
                    Console.WriteLine($"Результат: {number1} * {number2} = {result}");
                    break;
                case 4:
                    if (number2 != 0) // Проверка деления на ноль
                    {
                        result = number1 / number2;
                        Console.WriteLine($"Результат: {number1} / {number2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Деление на ноль недопустимо.");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка: Неверный номер действия.");
                    break;
            }

            Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
            */



            //1 ЧАСТЬ, ЗАДАНИЕ 3 Я НЕ СДЕЛАЛА

            //1 ЧАСТЬ, ЗАДАНИЕ 4


            /*
            Console.WriteLine("Введите путь");
            string str = Console.ReadLine();
            string[] parts = str.Split('/');
            Console.WriteLine(parts[parts.Length - 1]);
            */


            //1 ЧАСТЬ, ЗАДАНИЕ 5

            /*
            Console.WriteLine("Введите предложение:");
            string input = Console.ReadLine();

            // Разделение строки на слова
            string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Переменные
            string longestWord = "";
            int maxLength = 0;

            // Цикл для нахождения самого длинного слова
            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    longestWord = word;
                }
            }

            // Вывод
            if (longestWord.Length > 0)
            {
                Console.WriteLine("Самое длинное слово: " + longestWord);
            }
            else
            {
                Console.WriteLine("В предложении нет никаких слов.");
            }
            */



            //1 ЧАСТЬ, ЗАДАНИЕ 6

            /*
            double[] array1 = { 1.0, 17.0, 8.0, 3.0};
            double[] array2 = { 7.0, 9.0, 11.0, 2.0};

            // Перемножаем массивы
            double[] result = MultiplyArrays(array1, array2);

            // Выводим результат
            Console.WriteLine("Результат перемножения массивов:");
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
        }

        static double[] MultiplyArrays(double[] arr1, double[] arr2)
        {
            // Проверка на равенство длины массивов
            if (arr1.Length != arr2.Length)
            {
                throw new ArgumentException("Массивы должны быть одинаковой длины.");
            }

            // Инициализируем массив для результатов
            double[] result = new double[arr1.Length];

            // Перемножаем элементы массивов
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i] * arr2[i];
            }

            return result;
            */



            //1 ЧАСТЬ, ЗАДАНИЕ 7

            /*
            int[] numbers = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                // Преобразуем введенное значение в int
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maximal = numbers[0];
            int minimal = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > maximal)
                {
                    maximal = numbers[i];
                }
                if (numbers[i] < minimal)
                {
                    minimal = numbers[i];
                }
            }

            // Вывод результатов
            Console.WriteLine($"Максимальное число: {maximal}");
            Console.WriteLine($"Минимальное число: {minimal}");
            */


            //1 ЧАСТЬ, ЗАДАНИЕ 8


            /*
            Console.Write("Сколько будет уровней в пирамиде?");
            int levels = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= levels; i++)
            {
                Console.Write(new string(' ', (levels - i) * 2));

                // Вывод чисел
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                // Переход на новую строку после каждого уровня
                Console.WriteLine();
                */



            //ЧАСТЬ 2, ЗАДАНИЕ 1

            /*
            // Максимальное число для таблицы
            int maxNumber = 9;

            for (int i = 1; i <= maxNumber; i++)
            {
                for (int j = 1; j <= maxNumber; j++)
                {
                    // Выводим результат 
                    Console.Write($"{i} x {j} = {i * j}\t");
                }
                // Переход на новую строку после каждой строки таблицы
                Console.WriteLine();
                */


            //ЧАСТЬ 3, ВАРИАНТ 25 Я НЕ СДЕЛАЛА.


            }
        }
    }
