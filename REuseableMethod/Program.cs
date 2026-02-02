using System.Security.Cryptography;

namespace REuseableMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestRandomNumber();
            //pause
            Console.Read();
        }

        static void TestRandomNumber()
        {
            int max = 10, min = 5, currentNumber = 0, paddingLeft = 2, paddingRight = paddingLeft += 1;
            
            int[] results = new int[12];
            
            for (int i = 0; i < 1000; i++)
            {
                //Console.Write(RandomNumber(10, 5).ToString().PadLeft(2));
                currentNumber = RandomNumber(max,min);
                results[currentNumber] += 1;
            }

            //Make column headers
            for (int i = 0; i < results.Length; i++)
            {
                Console.Write(i.ToString().PadLeft(paddingLeft).PadRight(paddingRight) + "|");
            }
            Console.WriteLine();
            
            //Get array data
            foreach (int result in results)
            {
                Console.Write(result.ToString().PadLeft(paddingLeft).PadRight(paddingRight) +"|");
            }
        }
        static int RandomNumber(int max, int min)
        {

           
            
            Random rand = new Random();
            int range = ++max - min; //get the actual number of random values possible
            int randomNumber = rand.Next(range);
            randomNumber += min;
            return randomNumber;
        }
    }
}
