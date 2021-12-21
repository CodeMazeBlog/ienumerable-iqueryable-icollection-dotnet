using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetCollectionsExample
{
    class Program
    {
        private static void IEnumerableLoopExample(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is even");
                }
            }
        }

        static void Main(string[] args)
        {
            //IEnumerableLoopExample(new List<int> { 1, 2, 3, 4, 5 });
            //var evenNumbers = YieldEvenNumbersExample();
            //foreach (var number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            //var numbers = GetNumbersFromDb();
            //var evenNumbers = numbers.Where(number => number % 2 == 0)
            //                         .ToList();

            //foreach (var number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //}

            var numbers = new List<int> { 1, 2, 3, 5 };
            ICollectionExample(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }

        static IEnumerable<int> YieldEvenNumbersExample()
        {
            for (var i = 1; i <= 5; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        }

        static IQueryable<int> GetNumbersFromDb()
        {
            return new[] { 1, 2, 3, 4, 5 }.AsQueryable();
        }

        static void ICollectionExample(ICollection<int> numbers)
        {
            numbers.Add(100);

            if (numbers.Contains(1))
            {
                numbers.Remove(1);
            }
        }

    }
}
