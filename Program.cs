using System;
using System.Collections.Generic;

namespace boxing_unboxing {
    class Program {
        static void Main (string[] args) {

            List<object> boxList = new List<object> ();
            boxList.Add (7);
            boxList.Add (28);
            boxList.Add (-1);
            boxList.Add (true);
            boxList.Add ("chair");

            int sum = 0;

            foreach (var item in boxList) {
                if (item is int) {
                    int IsInt = (int) item;
                    sum += IsInt;
                }
                Console.WriteLine (item);
            }
            Console.WriteLine ("Sum: " + sum);
        }
    }
}