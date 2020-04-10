using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SortingSort
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SortingForm());


        }
    }

    public class Arr
    {

        static int[] a;


        public static void setArray(int size, int range)
        {
            a = new int[size];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(range);
            }
        }

        public static int[] getArray()
        {
            return a;
        }

        public static int Len()
        {
            return a.Length;
        }

        public static void CreateUnsortedArrayInTxtFile()
        {

            // Запись файла
            String WritePath = @"C:\Users\User\Documents\input.txt";
            StreamWriter sw = new StreamWriter(WritePath, false, System.Text.Encoding.Default); ;
            String Text = "";

            Text = Text + string.Join(" ", Arr.getArray());

            sw.WriteLine(Text);

            sw.Close();
        }

        public static void CreateSortedArrayInTxtFile()
        {

            // Запись файла
            String WritePath = @"C:\Users\User\Documents\output.txt";
            StreamWriter sw = new StreamWriter(WritePath, false, System.Text.Encoding.Default); ;
            String Text = "";

            Text = Text + string.Join(" ", Arr.getArray());

            sw.WriteLine(Text);

            sw.Close();
        }

        public static string ReadArrayInTxtFile()
        {

            // Запись файла
            String Text = File.ReadAllText(@"C:\Users\User\Documents\input.txt");

            return Text;

        }

        public static int[] InsertSort()
        {
            for (int i = 1; i < a.Length; i++)
            {
                int j = i;
                while (j > 0 && a[j - 1] > a[j])
                {
                    int t = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = t;
                    j--;
                }
            }
            return a;
        }

        public static int[] BubbleSort()
        {
            for (int j = 0; j < a.Length - 1; j++)
                for (int i = 0; i < a.Length - j - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int t = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = t;
                    }
                }
            return a;
        }

        public static int[] ShellSort()
        {
            for (int step = a.Length / 2; step > 0; step /= 2)

                for (int i = step; i < a.Length; i++)
                {
                    int t = a[i];
                    int j;
                    for (j = i; j >= step && a[j - step] > t; j -= step)
                    {
                        a[j] = a[j - step];
                    }
                    a[j] = t;

                }
            return a;
        }

        public static int[] MergeSort()
        {
            mergeSort(a, a.Length);

            void mergeSort(int[] arr, int len)
            {
                if (len < 2)
                {
                    return;
                }
                int mid = len / 2;
                int[] l = new int[mid];
                int[] r = new int[len - mid];

                for (int i = 0; i < mid; i++)
                {
                    l[i] = arr[i];
                }
                for (int i = mid; i < len; i++)
                {
                    r[i - mid] = arr[i];
                }
                mergeSort(l, l.Length);
                mergeSort(r, r.Length);

                merge(arr, l, r, l.Length, r.Length);
            }

            void merge(int[] arr, int[] l, int[] r, int left, int right)
            {

                int i = 0, j = 0, k = 0;
                while (i < left && j < right)
                {
                    if (l[i] <= r[j])
                    {
                        arr[k++] = l[i++];
                    }
                    else
                    {
                        arr[k++] = r[j++];
                    }
                }
                while (i < left)
                {
                    arr[k++] = l[i++];
                }
                while (j < right)
                {
                    arr[k++] = r[j++];
                }

                a = arr;
            }
            
            return a;

        }

        public static int [] Quicksort()
        {
            sort(a, 0, a.Length-1);
            int partition(int [] arr, int low, int high)
            {
                int pivot = arr[high];
                int i = low - 1;

                for (int j = low; j < high; j++)
                {

                    if (arr[j] <= pivot)
                    {
                        i++;

                        int t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }

                }

                int x = arr[i + 1];
                arr[i + 1] = arr[high];
                arr[high] = x;

                return i + 1;

            }

            void sort(int [] arr, int low, int high)
            {
                if (low < high)
                {
                    int pi = partition(arr, low, high);
                    sort(arr, low, pi - 1);
                    sort(arr, pi + 1, high);
                }
            }

            return a;
        }
    }
}


