using System;
using System.Linq;

namespace LINQ_with_Group
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberList = { 1, 1, 1, 1, 4, 4, 2, 3, 5, 6, 6, 10, 9, 8 };

            // GROUP - DISTINCT
            /*
             * var queryList = numberList.Distinct()
                                      .OrderBy(item => item)
                                      .Select(item => item);
            */

            var queryList = numberList
                                    .OrderBy(item => item)
                                    .GroupBy(item => item)
                                    .Select(item => item);

            foreach (var item in queryList)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
