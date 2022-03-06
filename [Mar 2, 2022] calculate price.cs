using System;

namespace hw1 {
    class HW1 {
        
        static int toInt(string str) {
            string temp = "";
            foreach (char i in str)
            {
                if (Char.IsNumber(i)) temp = temp + i;
            }
            return int.Parse(temp);
        }

        static void Main(string[] args) {

            string production1 = Console.ReadLine();
            string production2 = Console.ReadLine(); ;


            string[] buff1 = production1.Split(',');
            string[] buff2 = production2.Split(',');

            Console.WriteLine(production1);
            Console.WriteLine(production2);

            Console.WriteLine("{0} 元", toInt(buff1[1]) * toInt(buff1[2]) + toInt(buff2[1]) * toInt(buff2[2]));
        }
    }
}
