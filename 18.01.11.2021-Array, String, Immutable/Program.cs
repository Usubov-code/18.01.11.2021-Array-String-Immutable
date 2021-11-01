using System;
using System.Linq;

namespace _18._01._11._2021_Array__String__Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 2
            //int[] arr = { 7, 8, 3, 7, 4 ,3,5,6,8};
            //arg(arr);
            #endregion
            #region task 3
            //int[] task3 = { 7, 8, 3, 4, 5, 6 };
            //Console.WriteLine("please enter the number : ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //argss(task3, a);
            #endregion


            #region substring the string 

            //string a= "lorem ipsum loremp ipsum qazax ipsum qazax iosumm aloooha";

            //  Substring(a);
            #endregion

            #region task2 Reverses
            //int[] arr = { 7, 8, 3, 7, 4, 3, 5, 6, 8 };

            //Reverses(arr);

            #endregion

            #region task 3 Sort
            //int[] a = { 1, 2, 3, 4 };
            //int[] b = { 5, 6, 7, 8 };
            //int[] MergeArr = new int[a.Length + b.Length];
            //a.CopyTo(MergeArr, 0);
            //b.CopyTo(MergeArr, a.Length);
            //Array.Sort(MergeArr);
            //for (int i=MergeArr.Length - 1;i>=0;i-- )
            //{
            //    Console.WriteLine(MergeArr[i]+" ");
            //}


            #endregion


            #region Task 4 min max

            //int[] a = { 1, 2, 3, 4 };

            //Console.WriteLine(a.Max());
            //Console.WriteLine(a.Min());

            #endregion

            #region Task 5 

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] cut = new int[0];
            //int[] tek = new int[0];

            //for (int i=0; i<arr.Length;i++)
            //{
            //    if(arr[i] % 2== 0)
            //    {
            //        Array.Resize(ref cut, cut.Length + 1);
            //        cut[cut.Length - 1] = arr[i];


            //    }
            //    else
            //    {
            //        Array.Resize(ref tek, tek.Length + 1);
            //        tek[tek.Length - 1] = arr[i];
            //    }

            //}

            //foreach (var temp in cut)
            //{
            //    Console.WriteLine(temp +" ");

            //}
            //foreach(var temp in tek)
            //{

            //    Console.WriteLine(temp + " ");
            //}

            #endregion

            #region string task1
            //Console.WriteLine("please enter you text");
            //string a = Console.ReadLine();

            //Console.WriteLine($"The string you endered is: {a} ");
            #endregion

            #region task 2 string

            //string a=Console.ReadLine();

            //Console.WriteLine(a.Length);

            #endregion

            #region taks 3 string

            //string a = "lorem ipsum !";

            //for (int i=a.Length-1;i>=0;i--)
            //{
            //    Console.Write(a[i] + " ");
            //}

            #endregion

            #region task 4 string

            //string str = Console.ReadLine();
            //int a = 0, count = 1;
            //while (a <= str.Length - 1)
            //{
            //    if (str[a] == ' ' && str[a + 1] != ' ' && str[a - 1] != ' ')
            //    {
            //        count++;
            //    }

            //    a++;
            //}
            //Console.Write("Number of words in the string = {0}\n", count);



            #endregion

            #region task 5 string

            string a = "the string where the word the present than once";
            int count = 0;
            string[] words = a.Split(" ");
            for(int i =0; i<words.Length;i++)
            {

                if(words[i]=="the")
                {
                    count++;

                }
                

            }
            
            Console.WriteLine(count);
            #endregion
        }
        static int arg(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {


                    if (arr[i] == arr[j] && i != j)
                    {

                        sum++;


                    }

                }
            }

            Console.WriteLine(sum);

            return sum;
        }

        static void argss(int[] task3, int a)
        {
            for (int i = 0; i < task3.Length; i++)
            {



                if (a == task3[i])
                {

                    Console.WriteLine($"{a} arrayda movcuddur");
                    break;

                }


            }



        }

        public static void Substring(string a)
        {
            int startIndex = 0;
            int length = 10;
            String substring = a.Substring(startIndex, length);
            Console.WriteLine(substring);


        }

        static void Reverses(int[] arr)
        {

            Array.Reverse(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");


            }
        }


    }
}
