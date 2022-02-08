

using DesignPatterns.Behavorial.Strategy.ConcreteStrategy;
using DesignPatterns.Behavorial.Strategy.Context;
using System;

namespace DesignPatterns.Behavorial.Strategy
{
    public class StrategyExecutor
    {
        public static void Execute()
        {
            var studentList = new MySortedList();

            studentList.Add("Samuel");
            studentList.Add("Jimmy");
            studentList.Add("Sandra");
            studentList.Add("Anna");
            studentList.Add("Debora");
            studentList.Add("Patricia");
            studentList.Add("Alberto");
            studentList.Add("Marcelo");

            Console.WriteLine("Ascending");
            Console.WriteLine("---------");
            studentList.SetStrategy(new AscendingSortStrategy());
            studentList.Sort();

            Console.WriteLine("Descending");
            Console.WriteLine("----------");
            studentList.SetStrategy(new DescendingSortStrategy());
            studentList.Sort();

            Console.WriteLine("Random");
            Console.WriteLine("------");
            studentList.SetStrategy(new RandomSortStrategy());
            studentList.Sort();
        }
    }
}
