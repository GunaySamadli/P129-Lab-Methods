using System;

namespace LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded daxil edin");
            string ededSTR = Console.ReadLine();

            int eded = int.Parse(ededSTR);
            int[] array = { 1,2,3,4,2,3};

            //FindCountTotalNumber(eded);


            //Console.WriteLine(Findmaxinarray(array, eded));

            //DividedBySevenAndThree(num);
            //Console.WriteLine(tekcuttapan(eded));

            //Console.WriteLine(FindOddInArray(array));

            //Console.WriteLine(FindAvgEvenInArray(array));

        }

        #region Task 1

        //  FindIsEvenAndOdd
        // Daxil edilmis ededin cutdurse true deyilse false qaytarsin
        static void DividedBySevenAndThree(int a)
        {
            if (a % 21 == 0)
            {
                Console.WriteLine("3-e ve 7-e bolubur");
            }
            else
            {
                Console.WriteLine("3-e ve 7-e bolunmur");
            }

        }
        #endregion

        #region Task 2

        //FindMaxInArray metodu
        //Arrayde(minimum 5 eded olsun)elementlerden en azi 1-i User terefinden daxil edilen N ededinden
        //boyukdurse True,eks halda false yazilsin

        //static bool Findmaxinarray(int[] arr, int num)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (num > arr[i])
        //        {
        //            return true;

        //        }

        //    }
        //    return false;
        //}


        #endregion


        #region Task 3

        //FindIsEvenAndOdd metodu-
        //Daxil edilmis ededin cutdurse true deyilse false qaytarsin

        static bool tekcuttapan(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        #endregion

        #region Task 4

        //        FindCountTotalNumber
        //Istifadeci eded daxil edir.Ededin nece mertebeli oldugunu tapin.
        //(Misal:15613-5 Mertebeli,656 -3 Mertebeli)

        static void FindCountTotalNumber(int a)
        {
            int count = 0;
            int q = 0;
            while (a>0)
            {
                q = a % 10;
                count++;
                a = (a - q) / 10;
            }

            Console.WriteLine(count);
        }



        #endregion

        #region Task5

        //FindOddMaxInArray metodu-
        //Arrayde(minimum 5 eded olsun) cut indexde duran elementlerin cemini tapin


        static int FindOddInArray(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (i%2==0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }


        #endregion

        #region Task6

        //FindAvgEvenInArray metodu-
        //Arrayde(minimum 5 eded olsun) tek indexde duran elementlerin ededi ortasini tapin

        static int FindAvgEvenInArray(int[] array)
        {
            int sum = 0;
            int count = 0;
            int average;

            for (int i = 1; i < array.Length; i++)
            {
                if (i%2!=0)
                {
                    sum += array[i];
                    count++;

                }
            }
            average = sum / count;
            return average;
        }

        #endregion
    }
}
