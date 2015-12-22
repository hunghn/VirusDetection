using DemoSOM.SOM;
using DemoSOM.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOM
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            x = x | 2 | 1;
            x = x & 0;
            x = x | 0 | 1;
            x = x & 0;
            x = x | 2 | 0;
            x = x & 0;
            x = x | 2 | 1;
            String LearningFile = "D:\\LearnDB.txt";
            String TestingFile = "D:\\TestDB.txt";

            DBGenerate db = new DBGenerate();
            db.generateData(20);
            db.writeTestDB(LearningFile);

            db.generateData(40);
            db.writeTestDB(TestingFile);

            DBLoading dbLoading = new DBLoading();
            double[][] input = dbLoading.loadDB(LearningFile);
            MySOM mySOM = new MySOM(input);

            mySOM.TrainNetwork();
            
            // Get result
            mySOM.testData(input);
            Console.WriteLine("\n\n");
            Console.ReadLine();

            // Get test result
            double[][] testInput = dbLoading.loadDB(TestingFile);
            mySOM.testData(testInput);
            Console.ReadLine();


        }
    }
}
