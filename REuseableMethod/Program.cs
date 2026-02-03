using System.Security.Cryptography;

namespace REuseableMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestRandomNumber();
            TestRunningTotal();

            //pause
            Console.Read();
        }

        static void TestRunningTotal()
        {
            string userInput = "";

            do
            {
                Console.WriteLine("Enter a number to add total." +
                                  "\n Enter C to clear \nEnter q to quit");
                userInput = Console.ReadLine();
                try
                {
                    RunningTotal(int.Parse(userInput));


                }
                catch (Exception)
                {
                    switch (userInput)
                    {
                        case "c":
                            RunningTotal(0, true);
                            break;
                        case "C":
                            RunningTotal(0, true);
                            break;
                        default:
                            break;
                    }

                }
                Console.WriteLine($"You Entered {userInput}");
                Console.WriteLine($"The current total is {RunningTotal()}");
            }while (userInput != "q" || userInput != "Q");
            Console.WriteLine("have a nice day");
        }
        //keep track of a running total
        //optionally add the integer padded in a s an argument to the total
        //return the running total
        //optionally clear the running total
        static private int _runningTotal = 0;
        static int RunningTotal(int currentValue = 0, bool clear = false)
        {
            _runningTotal += currentValue;
            if (clear)
            {
                _runningTotal = 0;
            }
            return _runningTotal;
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
