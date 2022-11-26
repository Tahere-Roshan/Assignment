using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Performance
    {
        List<int> prfList = new List<int>();
        Stack<int> prfStack = new Stack<int>();
        Queue<int> prfQeue = new Queue<int>();
        Dictionary<int, int> prfDic = new Dictionary<int, int>();
        SortedDictionary<int, int> prfsorDic = new SortedDictionary<int, int>();
        HashSet<int> prfHash = new HashSet<int>();
        Random myRandom = new Random();

        Stopwatch prfst = new Stopwatch();
        public delegate void prfdelegate(int element);

       
        public void addition(int element)
        {
            
            prfst.Start();//add in list
            for (int i = 0; i < element; i++)
                prfList.Add(myRandom.next(0, 10 * element));
            prfst.Stop();
            Console.writeline(string.join(",", prfList));
            calcualteTime(prfst, "Dynamic array");

            prfst.Start();//add in stack
            for (int i = 0; i < element; i++)
                prfStack.Push(myRandom.next(0, 10 * element));
            prfst.Stop();
            //console.writeline(string.join(",", prfstack));
            calcualteTime(prfst, "Stack");

            prfst.start();
            for (int i = 0; i < element; i++)
                prfQeue.Enqueue(myRandom.next(0, 10 * element));
            Console.writeline(string.Join(",", prfQeue));
            prfst.Stop();
            calcualteTime(prfst, "qeue");

            prfst.Start();//add in Dic
            for (int i = 0; i < element; i++)
                prfDic.Add(i, myRandom.Next(0, 10 * element));
            prfst.Stop();
            calcualteTime(prfst, "Dictionary");

            prfst.Start();//add in sort dic
            for (int i = 0; i < element; i++)
                prfsorDic.Add(i, myRandom.Next(0, 10 * element));
            prfst.Stop();
            calcualteTime(prfst, "Sorted Dictionary");

            prfst.Start();//add in hash
            for (int i = 0; i < element; i++)
                prfHash.Add(myRandom.next(0, 10 * element));
            prfst.Stop();
            calcualteTime(prfst, "Hash Set");
        }


        /*public void Deletion(int element)
        {

            prfst.Start();//delete  element from list
            //prfList.Remove(element);
            prfList.Remove(element);
            prfst.Stop();
            Console.WriteLine(string.Join(",", prfList));
            calcualteTime(prfst, "Delete-Dynamic Array");

           *//* prfst.start();
            prfStack.Clear();
            prfst.stop();
            calcualteTime(prfst, "Delete-stack");
            //console.writeline(string.join(",", prfstack));*//*

            prfst.Start();//clear qeue
            prfQeue.Clear();
            prfst.Stop();
            calcualteTime(prfst, "Delete-Qeue");*/

           /* prfst.Start();//delete total element from dictionary
            for (int i = 0; i < element; i++)
                prfDic.Remove(i, element);
            prfst.Stop();
            calcualteTime(prfst, "Delete-Dictionary");

            prfst.Start();
            for (int i = 0; i < element; i++)

                prfsorDic.Add(i, myRandom.Next(0, 10 * element));

            prfst.Stop();
            calcualteTime(prfst, "Delete-Sorted Dictionary");

            prfst.Start();
            for (int i = 0; i < element; i++)


                prfHash.Add(myRandom.Next(0, 10 * element));

            prfst.Stop();
            calcualteTime(prfst, "Delete-Hash Set");*/
       // }

        /*public delegate void prfdelegate(int element);
        public void runPerformanc(int pName, int element)
        {
            prfdelegate addprf=new prfdelegate (addition);
            calcualteTime(addprf,'Addition',)
        }
    */

        private TimeSpan calcualteTime(Stopwatch stp, string pName)
        {
            
            TimeSpan ts = stp.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine(pName + " Performance Runtime" + stp.Elapsed);
            return stp.Elapsed;
        }

       /* private TimeSpan calcualteTime(prfdelegate pDelegate, string pName, int element)
        {
            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start();
            pDelegate(element);
            myStopwatch.Stop();
            TimeSpan ts = myStopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine(pName + " SortRunTime" + myStopwatch.Elapsed);
            return myStopwatch.Elapsed;
        }*/
    }
}
