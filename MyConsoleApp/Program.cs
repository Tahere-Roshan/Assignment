//reference-https://wellsb.com/csharp/beginners/create-menu-csharp-console-application
//reference-https://www.youtube.com/watch?v=5R6QIT9jxGw
//create a Menu-https://www.youtube.com/watch?v=5R6QIT9jxGw
//create a menue-https://www.youtube.com/watch?v=byqyLO8sQpI
//reference-https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c


using Algorithm;
using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection;


namespace MyConsolApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Myclass myclass = new Myclass();
            PrintTable prt=new PrintTable();

            Console.WriteLine("Hello, World!");

            

            /*prt.PrintLine();
            prt.PrintRow("N=100", "N=5000", "N=100,000", "1000,000");
            prt.PrintLine();
            prt.PrintRow("", "", "", "");
            prt.PrintRow("", "", "", "");
            prt.PrintLine();
            Console.ReadLine();*/

            bool finish = false;
            do
            {

                Console.WriteLine("Enter a number to specify your Array Size:");
                int arraySize = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter an item to remove");
                //int item = Convert.ToInt32(Console.ReadLine());
                /*Console.WriteLine("Choose one option from Menue:");
                Console.WriteLine("1- Sort");
                Console.WriteLine("2- Search");
                int menu = Convert.ToInt32(Console.ReadLine());*/
                int[] myArray = myclass.Prepare(100);
                //new Sort().runSorting1(myArray);
                Console.WriteLine("1- Insertion Sort");
                Console.WriteLine("2- Selection Sort");
                Console.WriteLine("3- Bubble Sort");
                Console.WriteLine("4- Merge Sort");
                Console.WriteLine("5- Quick Sort");
                Console.WriteLine("6- Lamba Sort");
                int SortMenue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select your Search Method:");
                Console.WriteLine("1- Linear Search");
                Console.WriteLine("2- Binary Search");
                Console.WriteLine("3- Lamba Search");
                int SearchMenue = Convert.ToInt32(Console.ReadLine());
                new Sort().runSorting(SortMenue, myArray);
                new Search().runSearching(SearchMenue, myArray, arraySize);
                /*new Performance().addition(arraySize);
                new Performance().Deletion(item);
                new Performance().prtlist(arraySize);*/

              /*  switch (menu)
                 {
                     case '1':
                         new Sort().runSorting();
                         break;
                     case '2':
                         Console.WriteLine("Enter a number to specify your Array Size:");
                         int arraySize = Convert.ToInt32(Console.ReadLine());
                         int[] myArray = myclass.Prepare(arraySize);
                         new Search().runSearching(myArray, arraySize);
                         break;

                 }*/


                Console.WriteLine("Finsihed SUccessfully ");
                Console.WriteLine("Restart r/ Close c:");
                char option = Convert.ToChar(Console.ReadLine());
                if (option == 'r')
                    finish = false;
                if (option == 'c')
                    finish = true;
            } while (!finish);



        }
    }
}

