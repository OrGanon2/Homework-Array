using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First
            int[] array1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("please enter number from 1 - 10");
                int num = int.Parse(Console.ReadLine());
                array1[i] = num;
            }
            for (int y = 9; y >= 0; y--)
            {
                Console.WriteLine(array1[y]);
            }

            #endregion

            #region second
            int[] array2 = new int[5] { 3, 4, 2, 1, 5 };
            Console.WriteLine(" 1 :{0} \n 2: {1} \n 3: {2} \n 4: {3} \n ", array2[0], array2[1], array2[2], array2[3], array2[4]);




            #endregion
            #region third

            int[] myArr1 = new int[10]; //{ 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] myArr2 = new int[10];
            for (int i = 0; myArr1.Length > i; i++)
            {
                Console.WriteLine("enter a first number");
                int x = int.Parse(Console.ReadLine());
                myArr1[i] = x;
                myArr2[i] = myArr1[i];
            }
            for (int y = 0; y < 10; y++)
            {
                Console.WriteLine("myArr1: {0}  myArr2: {1}", myArr1[y], myArr2[y]);
            }
            for (int f = 0; myArr1.Length > f; f++)
            {
                Console.WriteLine("enter a first number");
                myArr1[f] = int.Parse(Console.ReadLine());
                Console.WriteLine("myArr1: {0}  myArr2: {1}", myArr1[f], myArr2[f]);
            }
            #endregion

            #region fourth + fifth
            int[] myArr1 = new int[10]; //{ 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] myArr2 = new int[10];
            for (int i = 0; myArr1.Length > i; i++)
            {
                Console.WriteLine("enter a first number");
                int x = int.Parse(Console.ReadLine());
                myArr1[i] = x;
                myArr2[i] = myArr1[i];
            }
            myArr2 = myArr1;
            for (int y = 0; y < 10; y++)
            {
                Console.WriteLine("myArr1: {0}  myArr2: {1}", myArr1[y], myArr2[y]);
            }
            for (int f = 0; myArr1.Length > f; f++)
            {
                Console.WriteLine("enter a first number");
                myArr1[f] = int.Parse(Console.ReadLine());
                Console.WriteLine("myArr1: {0}  myArr2: {1}", myArr1[f], myArr2[f]);
            }



            int[] myArr1 = new int[10]; //{ 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] myArr2 = new int[10];
            for (int i = 0; myArr1.Length > i; i++)
            {
                Console.WriteLine("enter a first number");
                int x = int.Parse(Console.ReadLine());
                myArr1[i] = x;
                myArr2[i] = myArr1[i];
            }
            myArr2 = myArr1;
            for (int y = 0; y < 10; y++)
            {
                Console.WriteLine("myArr1: {0}  myArr2: {1}", myArr1[y], myArr2[y]);
            }
            for (int f = 0; myArr1.Length > f; f++)
            {
                Console.WriteLine("enter a first number");
                myArr1[f] = int.Parse(Console.ReadLine());
                Console.WriteLine("myArr1: {0}  myArr2: {1}", myArr1[f], myArr2[f]);
            }
            #endregion
            #region six

            Console.WriteLine("enter number of students");
            int student = int.Parse(Console.ReadLine());
            int[] Class_Shoko = new int[student];
            int sum_num = 0;
            for (int i = 0; Class_Shoko.Length > i; i++) 
            {
                Console.WriteLine("enter AVICHIES");
                int grades = int.Parse(Console.ReadLine());
                Class_Shoko[i] = grades;
            }
            for (int x = 0; Class_Shoko.Length > x; x++)
            {
                sum_num += Class_Shoko[x];
            }
            Console.WriteLine("sum grades:{0} Avarage: {1}" , sum_num , sum_num / student);
            #endregion
        }
    }
}
