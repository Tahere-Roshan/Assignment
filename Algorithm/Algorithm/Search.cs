using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Search
    {

        public delegate int searchDelegate(int[] myArray, int item);

        //Linear Search Method-https://www.geeksforgeeks.org/binary-search/?ref=lbp

        public int LinearSearch(int[] myArray, int item)
        {
            int N = myArray.Length;
            for (int i = 0; i < N; i++)
                if (myArray[i] == item)
                    return i;
            return -1;
        }

        //Linear Search Method-https://www.tutorialspoint.com/Binary-search-in-Chash


        public int BinarySearch(int[] myArray, int item)
        {
            int minNum = 0;
            int maxNum = myArray.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (item == myArray[mid])
                {
                    return ++mid;
                }
                else if (item < myArray[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return -1;
        }
        public int LambaSearch(int[] myArray, int item)//Lamba Search
        {
            return Array.Find(myArray, x => x == item);

        }
        public void runSearching(int aMenu, int[] myArray, int item)
        {

            switch (aMenu)
            {
                case 1:
                    searchDelegate obj1 = new searchDelegate(LinearSearch);
                    calcualteTime1(obj1,"Linear Search", myArray);
                    calcualteTime2(obj1, "Linear Search", myArray);
                    calcualteTime3(obj1, "Linear Search", myArray);

                    break;
                case 2:
                    searchDelegate obj2 = new searchDelegate(BinarySearch);
                    calcualteTime1(obj2, "Binary Search", myArray);
                    calcualteTime2(obj2, "Binary Search", myArray);
                    calcualteTime3(obj2, "Binary Search", myArray);
                    break;

                case 3:
                    searchDelegate obj3 = new searchDelegate(LambaSearch);
                    calcualteTime1(obj3, "Lamda Search", myArray);
                    calcualteTime2(obj3, "Lamda Search", myArray);
                    calcualteTime3(obj3, "Lambda Search", myArray);
                    break;
            }

        }

        /*  public void runSearching(int[] myArray, int item)
          {


                      searchDelegate obj1 = new searchDelegate(LinearSearch);
                      calcualteTime1(obj1, myArray);
                      calcualteTime2(obj1, myArray);
                      calcualteTime3(obj1, myArray);


                      searchDelegate obj2 = new searchDelegate(BinarySearch);
                      calcualteTime1(obj2, myArray);
                      calcualteTime2(obj2, myArray);
                      calcualteTime3(obj2, myArray);

                      searchDelegate obj3 = new searchDelegate(LambaSearch);
                      calcualteTime1(obj3, myArray);
                      calcualteTime2(obj3, myArray);
                      calcualteTime3(obj3, myArray);



          }*/
        private TimeSpan calcualteTime1(searchDelegate aDelegate,String OperationName, int[] myArray)
        {
            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start();
            aDelegate(myArray, myArray[0]);
            myStopwatch.Stop();
            TimeSpan ts = myStopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine(OperationName +" FirstSearch" + myStopwatch.Elapsed);
            return myStopwatch.Elapsed;

        }

        private TimeSpan calcualteTime2(searchDelegate aDelegate, String OperationName, int[] myArray)
        {
            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start();
            aDelegate(myArray, myArray[myArray.Length/2]) ;
            myStopwatch.Stop();
            TimeSpan ts = myStopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine(OperationName + " MiddleSearch" + myStopwatch.Elapsed);
            return myStopwatch.Elapsed;
        }
        private TimeSpan calcualteTime3(searchDelegate aDelegate, String OperationName, int[] myArray)
        {
            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start();
            aDelegate(myArray, myArray[myArray.Length-1]);
            myStopwatch.Stop();
            TimeSpan ts = myStopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine(OperationName+" LastSearch" + myStopwatch.Elapsed);
            return myStopwatch.Elapsed;
        }
    }
}
