using System;


namespace Program1
{
    class Program1
    {
        static void Main(string[] args)
        {
            String input;
            int num;

            Console.WriteLine("Please enter an integer:");
            input = Console.ReadLine();
            num = Int32.Parse(input);
            int[] numarr = new int[num];
            Program1 p = new Program1();
            int n = 0;
            for (int i = 2; i < num; i++) {
                if (p.numChecker(i))
                {
                    numarr[n] = i;
                    n++;
                }
            }

            int k = 0;
            do
            {
                Console.Write(numarr[k] + " ");
                k++;
            } while (numarr[k] != 0);
        }


        public bool numChecker(int num){
            if (num < 2)
                return false;
            if(num == 2)
            {
                return true;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

    }
}


