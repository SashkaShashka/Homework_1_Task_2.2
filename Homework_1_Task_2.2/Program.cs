using System;

namespace Homework_1_Task_2._2
{
    class Program
    {
        static double ReadDouble()
        {
            double val;
            while (!double.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine("Это по твоему хоть немного похоже на double????");
                Console.Write("У тебя есть еще одна попытка: ");

            }
            return val;
        }
        static double ReadDoubleValueOnRange(string message, double min_val, double max_val)
        {
            double val;
            do
            {
                Console.Write(message + " в диапазоне от " + min_val + " до " + max_val + ": ");
                val = ReadDouble();

            } while (!(val <= max_val && val >= min_val));

            return val;
        }
        static int ReadInt()
        {
            int val;
            while (!int.TryParse(Console.ReadLine(), out val))
            {
                Console.WriteLine("Это по твоему хоть немного похоже на int????");
                Console.Write("У тебя есть еще одна попытка: ");
            }
            return val;
        }
        static int ReadIntValueOnRange(string message, int min_val, int max_val)
        {
            int val;
            do
            {
                Console.Write(message + "в диапазоне от " + min_val + " до " + max_val + ": ");
                val = ReadInt();

            } while (!(val <= max_val && val >= min_val));

            return val;
        }
        static void Main(string[] args)
        {
            double width = ReadDoubleValueOnRange("Введите ширину комнаты", 1, 1000000);
            double length = ReadDoubleValueOnRange("Введите длину комнаты", 1, 1000000);
            double height = ReadDoubleValueOnRange("Введите высоту комнаты", 1, 200);

            double perimeter = (width + length) * 2;
            double area = perimeter * height;

            int countOfDoors = ReadIntValueOnRange("Введите количество дверей в комнате", 1, 10);
            int countOfWindows = ReadIntValueOnRange("Введите количество окон в комнате", 0, 10);

            double sumPerDoorsAndWindows = 0;

            double sumAreaDoorsAndWindow = 0;

            for (int i = 0; i < countOfDoors; i++)
            {
                double widthDoor = ReadDoubleValueOnRange("Введите ширину " + (i + 1) + " двери", 0, Math.Max(width, length));
                double heighDoor = ReadDoubleValueOnRange("Введите высоту " + (i + 1) + " двери", 0, height);

                sumPerDoorsAndWindows += widthDoor;
                sumAreaDoorsAndWindow += widthDoor * heighDoor;
            }
            for (int i = 0; i < countOfWindows; i++)
            {
                double widthWindow = ReadDoubleValueOnRange("Введите ширину " + i + 1 + " окна", 0, Math.Max(width, length));
                double heighWindow = ReadDoubleValueOnRange("Введите высоту " + i + 1 + " окна", 0, height);

                sumPerDoorsAndWindows += widthWindow;
                sumAreaDoorsAndWindow += widthWindow * heighWindow; ;
            }
            if (sumPerDoorsAndWindows < perimeter)
            {
                Console.WriteLine("Общая площадь стен с учетом проемов: " + (area - sumAreaDoorsAndWindow));
            }
            else
            {
                Console.WriteLine("Очень жаль, но такого помещения не может быть, крыше держаться не за что");

            }
        }


    }
}
