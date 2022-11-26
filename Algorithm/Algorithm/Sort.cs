using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Sort
    {

        public delegate void sortDelegate(int[] myArray);
        Myclass sortclass=new Myclass();

        //Insertion Sort Method-https://www.youtube.com/watch?v=yCxV0kBpA6M

        public void InstertionSort(int[] myArray)
        {
            int j, temp;

            for (int i = 1; i < myArray.Length; i++)
            {
                temp = myArray[i];
                j = i - 1;
                while (j >= 0 && myArray[j] > temp)
                {
                    myArray[j + 1] = myArray[j];
                    j--;
                }
                myArray[j + 1] = temp;
            }


        }
        //Selection Sort Method-https://youtu.be/yCxV0kBpA6M
        public void SelectionSort(int[] myArray)
        {
            sortclass = new Myclass();
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[min] > myArray[j])
                    {
                        min = j;
                    }
                    
                    sortclass.Swap(myArray, i, min);
                }

            }
        }

        //Bubble Sort Method-https://www.educba.com/bubble-sort-in-c-sharp/
        public void BubbleSort(int[] myArray)
        {
            sortclass = new Myclass();
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length - 1; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        sortclass.Swap(myArray, j + 1, j);
                    }
                }
            }
        }

        public void merge(int[] arr)
        {
            mergeSort(arr, 0, arr.Length - 1);
        }
        public void merge(int[] arr, int p, int q, int r)
        {
            int i, j, k;
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1];
            int[] R = new int[n2];
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[p + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[q + 1 + j];
            }
            i = 0;
            j = 0;
            k = p;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void mergeSort(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(arr, p, q);
                mergeSort(arr, q + 1, r);
                merge(arr, p, q, r);
            }
        }

        //public void QuickSort(int[] myarray)
        //{
        //    int leftindex = 0;
        //    int rightindex = myarray.Length - 1;
        //    int pivot = myarray[leftindex];
        //    while (leftindex <= rightindex)
        //    {
        //        while (myarray[leftindex] < pivot)
        //        {
        //            leftindex++;
        //        }
        //        while (myarray[rightindex] < pivot)
        //        {
        //            rightindex--;
        //        }
        //        if (leftindex <= rightindex)
        //        {
        //            Myclass.Swap(myarray, leftindex, rightindex);
        //            leftindex++;
        //            rightindex--;
        //        }
        //    }
        //    if (leftindex < rightindex)
        //    {
        //        QuickSort(myarray);
        //    }

        //}
        private int partition(int[] arr, int low, int high)
        {

            // pivot
            int pivot = arr[high];

            // Index of smaller element and
            // indicates the right position
            // of pivot found so far
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                // If current element is smaller
                // than the pivot
                if (arr[j] < pivot)
                {

                    // Increment index of
                    // smaller element
                    i++;
                    sortclass.Swap(arr, i, j);
                }
            }
            sortclass.Swap(arr, i + 1, high);
            return (i + 1);
        }

        /* The main function that implements QuickSort
                    arr[] --> Array to be sorted,
                    low --> Starting index,
                    high --> Ending index
           */
        private void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                // pi is partitioning index, arr[p]
                // is now at right place
                int pi = partition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
        public void QuickSort(int[] myArray)
        {
            quickSort(myArray, 0, myArray.Length-1);
        }


            //Method "SortByLamba"-https://www.dotnetperls.com/sort-list-https://www.youtube.com/watch?v=F6iHzYLh2cA

            public void SortByLamba(int[] myArray)
        {
            Array.Sort(myArray, (x, y) => x.CompareTo(y));
        }


        /* public void runSorting1(int myArray)
         {
             Myclass sCreator = new Myclass();
             myArray = sCreator.Prepare(100);
             *//*int[] arr2 = sCreator.Prepare(5000);
             int[] arr3 = sCreator.Prepare(100000);
             int[] arr4 = sCreator.Prepare(1000000);*//*
             sortDelegate obj1 = new sortDelegate(InstertionSort);
             calcualteTime(obj1,"Insertion(100)", myArray);
             *//*calcualteTime(obj1, arr2);
             calcualteTime(obj1, arr3);
             calcualteTime(obj1, arr4);
             sortDelegate obj2 = new sortDelegate(SelectionSort);
             calcualteTime(obj2, arr1);
             calcualteTime(obj2, arr2);
             calcualteTime(obj2, arr3);
             calcualteTime(obj2, arr4);
             sortDelegate obj3 = new sortDelegate(BubbleSort);
             calcualteTime(obj3, arr1);
             calcualteTime(obj3, arr2);
             calcualteTime(obj3, arr3);
             calcualteTime(obj3, arr4);
             sortDelegate obj4 = new sortDelegate(merge);
             calcualteTime(obj4, arr1);
             calcualteTime(obj4, arr2);
             calcualteTime(obj4, arr3);
             calcualteTime(obj4, arr4);
             sortDelegate obj5 = new sortDelegate(QuickSort);
             calcualteTime(obj5, arr1);
             calcualteTime(obj5, arr2);
             calcualteTime(obj5, arr3);
             calcualteTime(obj5, arr4);
             sortDelegate obj6 = new sortDelegate(SortByLamba);
             calcualteTime(obj6, arr1);
             calcualteTime(obj6, arr2);
             calcualteTime(obj6, arr3);
             calcualteTime(obj6, arr4);*//*



         }
 */

        public void runSorting(int aMenu, int[] myArray)
        {


            switch (aMenu)
            {
                case 1:
                    sortDelegate obj1 = new sortDelegate(InstertionSort);
                    calcualteTime(obj1, "Insertion", myArray);
                    break;
                case 2:
                    sortDelegate obj2 = new sortDelegate(SelectionSort);
                    calcualteTime(obj2, "Selection", myArray);
                    break;

                case 3:
                    sortDelegate obj3 = new sortDelegate(BubbleSort);
                    calcualteTime(obj3, "Bubble", myArray);
                    break;

                case 4:
                    sortDelegate obj4 = new sortDelegate(merge);
                    calcualteTime(obj4, "Merge", myArray);
                    break;
                case 5:
                    sortDelegate obj5 = new sortDelegate(QuickSort);
                    calcualteTime(obj5, "Quick", myArray);
                    break;
                case 6:
                    sortDelegate obj6 = new sortDelegate(SortByLamba);
                    calcualteTime(obj6, "Lamda", myArray);
                    break; ;

            }

        }

        private TimeSpan calcualteTime(sortDelegate aDelegate, string aName,int[] myArray)
        {
            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start();
            aDelegate(myArray);
            myStopwatch.Stop();
            TimeSpan ts = myStopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine(aName+" SortRunTime" + myStopwatch.Elapsed);
            return myStopwatch.Elapsed;
        }


    }

}


