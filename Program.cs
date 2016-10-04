using System;

namespace ConsoleApplication
{
    public class Program
    {
        //Random Array
        //     public static void findMax(int[] array)
        //     {
        //         int max = array[0];
        //         for (int i = 0; i < array.Length; i++)
        //         {
        //             if (array[i] > max)
        //             {
        //                 max = array[i];
        //             }
        //         }
        //         Console.WriteLine("max is {0}", max);
        //     }
        //     public static void findMin(int[] array)
        //     {
        //         int min = array[0];
        //         for (int i = 0; i < array.Length; i++)
        //         {
        //             if (array[i] < min)
        //             {
        //                 min = array[i];
        //             }
        //         }
        //         Console.WriteLine("min is {0}", min);
        //     }
        //     public static int[] randomArr()
        //     {
        //         int Min = 5;
        //         int Max = 25;
        //         int sum = 0;
        //         int[] randArr = new int[10];
        //         Random randNum = new Random();
        //         for (int i = 0; i < randArr.Length; i++)
        //         {
        //             randArr[i] = randNum.Next(Min, Max);
        //               sum += randArr[i];
        //             Console.WriteLine(randArr[i]);
        //         }
        //         Console.WriteLine("sum is {0}",sum);
        //         findMax(randArr);
        //         findMin(randArr);
        //         return randArr;
        //     }

    //    //Create A Coin Toss
    //    public static string coinToss(){
    //        Random rand = new Random();
    //        Console.WriteLine("Tossing A Coin...!");
    //        int result = rand.Next(1,3);
    //        if(result == 1) {
    //            Console.WriteLine("You Flipped Tails!");
    //        }
    //        if(result == 2) {
    //            Console.WriteLine("You Flipped Heads!");
    //        }
    //        return("The result was: " + result);
    //    }

      
    //    public static string TossMultipleCoins(int num){
    //        int headToss = 0;
    //        int totalToss = 0;
    //        Random rand = new Random();
    //        for(int i = 1; i < num; i++) {
    //            Console.WriteLine("Tossing A Coin...");
    //            int result = rand.Next(1,3);
    //            if(result == 1) {
    //                totalToss += 1;
    //                Console.WriteLine("You Flipped Tails!");
    //            }
    //            if(result == 2) {
    //                headToss += 1;
    //                totalToss += 1;
    //                Console.WriteLine("You Flipped Heads!");
    //            }
    //        }
    //        var ratio = ((double)headToss / totalToss);
           
    //        Console.WriteLine("Total # of tosses: " + totalToss + " - # of heads tosses: " + headToss + " - Ratio: " + ratio);
    //        return("coin toss done");
    //    }
        public static void Names()
           {
               string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
               string[] shuffled = new string[5];
               Random random = new Random();
               for(int i = 0; i < names.Length; i++)
               {
                   bool flag = true;
                   while(flag)
                   {
                       int idx = random.Next(0,5);
                       if(shuffled[idx] == null)
                       {
                           shuffled[idx] = names[i];
                           flag = false;
                       }

                   }
               }
               for(int k = 0; k < shuffled.Length; k++)
              {
                  if(shuffled[k].Length < 5){
                      shuffled[k] = null;
                  }
                  Console.WriteLine(shuffled[k]);
              }
          }
        public static void Main(string[] args)
        {
            // randomArr();
            // coinToss();
            // TossMultipleCoins(4);
            Names();
        }
    }
}
