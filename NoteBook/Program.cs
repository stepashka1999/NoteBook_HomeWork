using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBook
{
    class Program
    {
        //Определение центра окна
        static readonly int cursorPos = Console.WindowWidth / 2;

        static void Main(string[] args)
        {    
            //массив для хранения баллов по 3м предметам
            int[] exams = new int[3];
        
            //массив с данными для вывода в консоль
            string[] pattern = { "Name: ", "Age: ", "Height: ", "History: ", "Math: ", "Russian: " };

            //массив для входных данных о пользователе
            string[] input = new string[pattern.Length - 3];

            //Цикл для вывода данных в консоль и заполнения массивов
            for(int i = 0; i < pattern.Length; i++)
            {
                Console.CursorLeft = cursorPos - pattern[i].Length;
                Console.Write(pattern[i]);

                if (i < 3) input[i] = Console.ReadLine();
                else exams[i - 3] = int.Parse(Console.ReadLine());
            }

            var avgEx = AvgExams(exams);
            var str = "Средний балл: ";

            //Установка курсора в центр с учетом длинны строки
            Console.CursorLeft = cursorPos - str.Length;
            
            //Вывод в консоль
            Console.WriteLine(str + avgEx);

            Console.WriteLine();

            //-------------> Обычный вывод <-------------//

            var printInfo = "Обычный вывод";       // Информация о типе вывода
            
            // Установка курсора в центр окна с учетом длинны строки
            Console.CursorLeft = cursorPos - printInfo.Length / 2;

            Console.WriteLine(printInfo + '\n');

            SimplePrint(pattern, input, exams);

            Console.WriteLine();

            //----------------------------------------//



            //-------------> Форматированный вывод <-------------//

            printInfo = "Форматированный вывод";    // Информация о типе вывода
           
            // Установка курсора в центр окна с учетом длинны строки
            Console.CursorLeft = cursorPos - printInfo.Length / 2;

            Console.WriteLine(printInfo + '\n');
            //Форматированный вывод
            FormatPrint(pattern, input, exams);

            Console.WriteLine();

            //------------------------------------------------//


            //-------------> Вывод строк с интерполяцией <-------------//

            printInfo = "Вывод с интерполяцией строк";    // Информация о типе вывода

            // Установка курсора в центр окна с учетом длинны строки
            Console.CursorLeft = cursorPos - printInfo.Length / 2;

            Console.WriteLine(printInfo + '\n');
            //Вывод с интерполяцией строк
            InterPrint(pattern, input, exams);

            //-------------------------------------------------------//

            //-------------> Вывод строк с интерполяцией по центру экрана <-------------//

            Console.WriteLine("Нажмите любую кнопку, чтобы очистить консоль и вывести текст по центру");
            Console.ReadKey();

            Console.Clear();

            //установка цвета текста консоли
            Console.ForegroundColor = ConsoleColor.Green;
                        
            PrintInfoOnTheCenter(pattern, input, exams);


            Console.ReadKey();
            

        }

        /// <summary>
        /// Расщитывает среднее чисел массива
        /// </summary>
        /// <param name="exams">Целочисленный массив</param>
        /// <returns>Возвращает среднее все чисел массива</returns>
        public static float AvgExams(int[] exams)
        {
            return (float)exams.Sum() / exams.Length;
        }

        /// <summary>
        /// Обычный вывод в консоль
        /// </summary>
        /// <param name="pattern">Паттерн вывода</param>
        /// <param name="info">Информация о пользователе</param>
        /// <param name="exams">Экзамены</param>
        public static void SimplePrint(string[] pattern, string[] info, int[] exams)
        {            
            var title = "Информация о пользователе:";      // Заголовок
             
            // Установка курсора в центр окна с учетом длинны строки
            Console.CursorLeft = cursorPos - title.Length/2;

            Console.WriteLine(title);

            for(int i = 0; i < pattern.Length; i++)
            {
                Console.CursorLeft = cursorPos - pattern[i].Length;
                if (i < 3) Console.WriteLine(pattern[i] + " " + info[i]);
                else Console.WriteLine(pattern[i] + " " + exams[i-3]);
            }

            var avgEx = AvgExams(exams);
            var str = "Средний балл: ";

            //Установка курсора в центр с учетом длинны строки
            Console.CursorLeft = cursorPos - str.Length;

            //Вывод в консоль
            Console.WriteLine(str + avgEx);
        }

        /// <summary>
        /// Форматированный в консоль
        /// </summary>
        /// <param name="pattern">Паттерн вывода</param>
        /// <param name="info">Информация о пользователе</param>
        /// <param name="exams">Экзамены</param>
        public static void FormatPrint(string[] pattern, string[] info, int[] exams)
        {           
            var title = "Информация о пользователе:";      // Заголовок

            // Установка курсора в центр окна с учетом длинны строки
            Console.CursorLeft = cursorPos - title.Length / 2;

            Console.WriteLine(title);

            for (int i = 0; i < pattern.Length; i++)
            {
                Console.CursorLeft = cursorPos - pattern[i].Length;
                if (i < 3) Console.WriteLine("{0} {1}", pattern[i], info[i]);
                else Console.WriteLine("{0} {1}", pattern[i], exams[i - 3]);
            }

            var avgEx = AvgExams(exams);
            var str = "Средний балл: ";

            //Установка курсора в центр с учетом длинны строки
            Console.CursorLeft = cursorPos - str.Length;

            //Вывод в консоль
            Console.WriteLine("{0} {1}",str, avgEx);
        }

        /// <summary>
        /// Вывод с интерполяцией строк
        /// </summary>
        /// <param name="pattern">Паттерн вывода</param>
        /// <param name="info">Информация о пользователе</param>
        /// <param name="exams">Экзамены</param>
        public static void InterPrint(string[] pattern, string[] info, int[] exams)
        {
            var title = "Информация о пользователе:";      // Заголовок

            // Установка курсора в центр окна с учетом длинны строки
            Console.CursorLeft = cursorPos - title.Length / 2;

            Console.WriteLine(title);

            for (int i = 0; i < pattern.Length; i++)
            {
                Console.CursorLeft = cursorPos - pattern[i].Length;
                if (i < 3) Console.WriteLine($"{pattern[i]} {info[i]}");
                else Console.WriteLine($"{pattern[i]} {exams[i-3]}");
            }

            var avgEx = AvgExams(exams);
            var str = "Средний балл: ";

            //Установка курсора в центр с учетом длинны строки
            Console.CursorLeft = cursorPos - str.Length;

            //Вывод в консоль
            Console.WriteLine($"{str} {avgEx}");
        }

        /// <summary>
        /// Выводит информацию о пользователе по центру окна
        /// </summary>
        /// <param name="pattern">Паттерн вывода</param>
        /// <param name="info">Информация о пользователе</param>
        /// <param name="exams">Экзамены</param>
        public static void PrintInfoOnTheCenter(string[] pattern, string[] info, int[] exams)
        {
            var defaultIndent = pattern.Length + 2;

            Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.WindowHeight / 2 - defaultIndent/2 - 1);

            var titile = "ИНФОРМАЦИЯ О ПОЛЬЗОВАТЕЛЕ\n";
            Console.WriteLine(titile);

            var k = 0;
            
            for (int i = 0; i < pattern.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.WindowHeight / 2 - (defaultIndent/2 - i - 1) + k);

                if (i < 3)
                {
                    //Имя длинное
                    if (i == 0 && info[i].Length > 30)
                    {
                        var tempRes = info[i].Split(' ');
                        Console.WriteLine($"{pattern[i]} {tempRes[0]}");

                        //Ваш способ
                        var fName = "Full Name: " + info[i];
                        Console.CursorLeft = Console.WindowWidth / 2 - fName.Length / 2;
                        Console.WriteLine(fName);
                        k = 1;
                    }
                    else
                    {
                        Console.WriteLine($"{pattern[i]} {info[i]}");
                    }
                }
                else Console.WriteLine($"{pattern[i]} {exams[i - 3]}");
            }

            var avgEx = AvgExams(exams);
            var str = "Средний балл: ";

            //Установка курсора в центр с учетом длинны строки
            Console.SetCursorPosition(Console.WindowWidth / 2 - 3, Console.WindowHeight / 2 +defaultIndent/2);

            //Вывод в консоль
            Console.WriteLine($"{str} {avgEx}");
        }
    }
}
