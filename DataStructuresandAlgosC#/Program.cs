using System.Diagnostics;
using DSA_Lib;
namespace DataStructuresandAlgosC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raen Reyes");
            //readind data from the txt file that is passed and turning it into an array
            var numFromFile = In.ReadInts("2Kints.txt").ToArray();
            var stopWatch = new Stopwatch();


            stopWatch.Start();
            //this code returns the paire and we store it in a variable called triplets
            var triplets = ThreeSum.Count(numFromFile);
            stopWatch.Stop();

            //1kints took .58 seconds to process
            //2k kints took 3.6 seconds to process
            //4k kints took 28.44 seconds to process
            //8k kints took 224 seconds to process
            //16Kints took a 1803.3574453 seconds to process

            Console.WriteLine("The number of zero sum triplets there are is " + triplets);
            Console.WriteLine("This took " + stopWatch.Elapsed.TotalSeconds + " seconds");
            Console.ReadLine();
        }
    }
}