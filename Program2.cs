using System;

namespace Program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Size:");
            String line;

            int size;

            line = Console.ReadLine();
            size = Int32.Parse(line);
            String[] values = new String[size];
            float[] vals = new float[size];
            Console.WriteLine("Please Enter indices:");
            line = Console.ReadLine();
            values = line.Split(' ');

            for (int i = 0; i < size; i++)
                vals[i] = Single.Parse(values[i], System.Globalization.NumberStyles.Float);

            Program2 p = new Program2();
            p.sort(vals);


            for (int i = 0; i < size; i++)
                Console.Write(vals[i] + " ");
        }

        public void sort(float[] arr)
        {
            float temp;
            for (int k = 0; k <= arr.Length - 1; k++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if(arr[i].CompareTo(arr[i + 1]) > 0)
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    }
}
