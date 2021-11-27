using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15._1
{
    internal class Program
    {
        static void Main()
        {
            //ArithProgression arithProg = new ArithProgression();
            //GeomProgression geomProg = new GeomProgression();

            //Console.WriteLine("Арифметическая прогрессия");
            //Console.WriteLine();

            //arithProg.setStart(0);
            //Console.WriteLine();

            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine("Следующее число ряда: " + arithProg.getNext());

            //arithProg.reset();

            //Console.WriteLine("Геометрическая прогрессия");
            //Console.WriteLine();

            //geomProg.setStart(1);
            //Console.WriteLine();

            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine("Следующее число ряда: " + geomProg.getNext());

            //geomProg.reset();

            Console.WriteLine("Выберете необходимое действие");
            Console.WriteLine();
            Console.WriteLine("     1. Арифметическая прогрессия");
            Console.WriteLine("     2. Геометрическая прогрессия");
            Console.WriteLine();
        Start:
            Console.Write("Ваш выбор: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    Console.WriteLine();
                    ArithGeom.variant1();
                    break;

                case "2":

                    Console.WriteLine();
                    ArithGeom.variant2();
                    break;


                default:

                    Console.WriteLine("Такого параметра не существует!");
                    Console.WriteLine();
                    goto Start;
            }

            Console.ReadKey();
        }

        interface ISeries
        {
            void setStart(int x);

            int getNext();

            void reset();
        }

        class ArithProgression : ISeries
        {

            int start;
            int val;

            public ArithProgression()
            {
                start = 0;
                val = 0;
            }



            public void setStart(int x)
            {
                start = x;
                val = start;
                Console.WriteLine("Начальное число ряда: {0}", val);

            }

            public int getNext()
            {
                val += 2;
                return val;

            }

            public void reset()
            {
                val = start;

                Console.WriteLine();
                Console.WriteLine("Возврат к начальному значению: {0}", val);
            }
        }

        class GeomProgression : ISeries
        {
            int start;
            int val;

            public GeomProgression()
            {
                start = 0;
                val = 0;
            }



            public void setStart(int x)
            {
                start = x;
                val = start;
                Console.WriteLine("Начальное число ряда: {0}", val);

            }

            public int getNext()
            {
                val *= 2;
                return val;

            }

            public void reset()
            {
                val = start;

                Console.WriteLine();
                Console.WriteLine("Возврат к начальному значению: {0}", val);
            }
        }

        static class ArithGeom
        {
            public static void variant1()
            {
                ArithProgression arithProg = new ArithProgression();

                Console.WriteLine("Арифметическая прогрессия");
                Console.WriteLine();

                arithProg.setStart(0);
                Console.WriteLine();

                for (int i = 0; i < 5; i++)
                    Console.WriteLine("Следующее число ряда: " + arithProg.getNext());

                arithProg.reset();

                ArithGeom.ReturnMenu();

            }

            public static void variant2()
            {
                GeomProgression geomProg = new GeomProgression();

                Console.WriteLine("Геометрическая прогрессия");
                Console.WriteLine();

                geomProg.setStart(1);
                Console.WriteLine();

                for (int i = 0; i < 5; i++)
                    Console.WriteLine("Следующее число ряда: " + geomProg.getNext());

                geomProg.reset();

                ArithGeom.ReturnMenu();
            }

            public static void ReturnMenu()
            {

                Console.WriteLine();
                Console.WriteLine("     1. Для возврата к главному меню");
                Console.WriteLine("     2. Для выхода из программы");
                Console.WriteLine();
            Start1:
                Console.Write("Ваш выбор: ");

                string choice1 = Console.ReadLine();

                switch (choice1)
                {
                    case "1":

                        Console.WriteLine();
                        Program.Main();
                        break;

                    case "2":

                        Console.WriteLine();
                        Console.WriteLine("Для завершения нажмите любую клавишу");
                        break;

                    default:

                        Console.WriteLine("Такого параметра не существует!");
                        Console.WriteLine();
                        goto Start1;


                }







            }
        }
    }
}
