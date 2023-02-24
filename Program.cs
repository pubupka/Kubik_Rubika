using System;
using System.IO;

namespace Кубик_рубика
{
    class HelloWorld
    {
        static void Main()
        {
            StreamReader str = new StreamReader(@"C:\Users\Halim\OneDrive\Рабочий стол\Кубик Рубика\input_s1_19.txt");
            string line = str.ReadLine();
            string[] line_copy = line.Split(' ');
            int n = int.Parse(line_copy[0]);
            int m = int.Parse(line_copy[1]);

            string numbers = str.ReadLine();
            string[] numbers_copy = numbers.Split(' ');
            int x = int.Parse(numbers_copy[0]);
            int y = int.Parse(numbers_copy[1]);
            int z = int.Parse(numbers_copy[2]);
            int a, b;

            for(int k = 0; k < m; k++)
            { 
                string move = str.ReadLine();
                string[] move_copy = move.Split(' ');
                string os = move_copy[0];
                int block = int.Parse(move_copy[1]);
                int direction = int.Parse(move_copy[2]);

                if(os == "Z") //y - строки, x - столбцы
                {
                    a = x;
                    b = y;
                    if (block == z)
                    {
                        if (direction == 1)
                        {
                            y = n - a + 1;
                            x = b;
                        }

                        if (direction == -1)
                        {
                            x = n - b + 1;
                            y = a;
                        }
                    }
                    else
                        continue;
                }

                if (os == "Y") //z - строки, x - столбцы
                {
                    a = x;
                    b = z;
                    if (block == y)
                    {
                        if (direction == 1)
                        {
                            z = n - a + 1;
                            x = b;
                        }

                        if (direction == -1)
                        {
                            x = n - b + 1;
                            z = a;
                        }
                    }
                    else
                        continue;
                }

                if (os == "X") //z - строки, y - столбцы
                {
                    a = y;
                    b = z;
                    if (block == x)
                    {
                        if (direction == 1)
                        {
                            z = n - a + 1;
                            y = b;
                        }

                        if (direction == -1)
                        {
                            y = n - b + 1;
                            z = a;
                        }
                    }
                    else
                        continue;
                }
            }
            Console.WriteLine(Convert.ToString(x) + " " + Convert.ToString(y) + " " + Convert.ToString(z));
        }
    }
}