using System;

namespace hw1 {
    class HW1 {

        static int readInt() {
            return int.Parse(Console.ReadLine());
        }
     
        static void Main (string[] args) {

            int chinese, english, math;

            Console.Write("國文: ");
            chinese = readInt();

            Console.Write("英文: ");
            english = readInt();

            Console.Write("數學: ");
            math = readInt();


            int sum = chinese + english + math;
            float avg = (float)sum / 3;
           
            Console.WriteLine("平均: {0:0000.00}", avg);
 
        }
       
    }
}
