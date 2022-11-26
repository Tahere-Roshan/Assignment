//Reference-https://www.tutorialsteacher.com/articles/generate-random-numbers-in-csharp


//1-Create Dynamic Library

using System;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Runtime.CompilerServices;

namespace Algorithm
{

    public class Myclass
    {

        //Part D

        //Swap Method

        public delegate void sortDelegate(int[] myArray);
       public  void Swap(int[] myArray, int i, int j)
        {
            int temp;
            temp = myArray[i];
            myArray[i] = myArray[j];
            myArray[j] = temp;
        }

        //Randomize Method
        public  int[] Randmize(int[] myArray)
        {
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(0, 10 * myArray.Length);

            }
            return myArray;
        }

        //Prepare Method
        public  int[] Prepare(int Arraysize) // I want to call it in the sort class that asked me should be static-look
        {
            int[] myArray = new int[Arraysize];
            return Randmize(myArray);
            
        }
    }
}
