using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using static LINQ_Ass.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace LINQ_Ass;
internal class Program
{
    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        ArgumentNullException.ThrowIfNull("Collection is empty");

        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        #region LINQ - Restriction Operators><
        #region Q01
        /*
        //1.Find all products that are out of stock.
        //var result = ProductList.Where(p => p.UnitsInStock == 0);

        var result = from p in ProductList
                     where p.UnitsInStock == 0
                     select p;

        PrintCollection(result);
        */
        #endregion

        #region Q02
        /*
        //2.Find all products that are in stock and cost more than 3.00 per unit.
        //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);

        var result = from p in ProductList
                     where p.UnitsInStock > 0 && p.UnitPrice > 3
                     select p;

        PrintCollection(result);
        */
        #endregion
        #endregion

        #region LINQ - Element Operators
        #region Q01
        //1.Get first Product out of Stock
        //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);

        //var result = (from p in ProductList
        //              where p.UnitsInStock == 0
        //              select p).FirstOrDefault();

        //Console.WriteLine(result);
        #endregion

        #region Q02
        //2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
        //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

        //var result = (from p in ProductList
        //              where p.UnitPrice > 1000
        //              select p).FirstOrDefault();

        //Console.WriteLine(result);
        #endregion
        #endregion

        #region LINQ - Aggregate Operators
        #region Q01
        //1.Uses Count to get the number of odd numbers in the array
        //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = arr.Count(n => n % 2 != 0);

        //var result = (from n in arr
        //              where n % 2 != 0
        //              select n).Count();

        //Console.WriteLine(result);
        #endregion

        #region Q02
        //2.Get the total of the numbers in an array.
        //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = arr.Sum();

        //var result = (from n in arr
        //              select n).Sum();

        //Console.WriteLine(result);
        #endregion

        #region Q03
        //string[] words = File.ReadAllLines(@"E:\mina\Route\Linq\Session2\Linq02\dictionary_english.txt");
        //var result = words.Sum(w => w.Length);

        //var result = (from w in words
        //              select w.Length).Sum();

        //Console.WriteLine(result);
        #endregion

        #region Q04
        //4.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
        //string[] words = File.ReadAllLines(@"E:\mina\Route\Linq\Session2\Linq02\dictionary_english.txt");
        //var result = words.Min(x => x.Length);

        //var result = (from w in words
        //              select w.Length).Min();

        //Console.WriteLine(result);
        #endregion

        #region Q05
        //5.Get the total units in stock for each product category.
        //var result = ProductList.GroupBy(p => p.Category).Select(c => new
        //{
        //    Category = c.Key,
        //    TotalUnitsInStock = c.Sum(p => p.UnitsInStock)
        //});

        //var result = from p in ProductList
        //             group p by p.Category into g
        //             select new
        //             {
        //                 Category = g.Key,
        //                 TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
        //             };

        //PrintCollection(result);
        #endregion

        #region Q06
        //6.Get the cheapest price among each category's products
        //var result = ProductList.GroupBy(p => p.Category).Select(g => new
        //{
        //    Category = g.Key,
        //    CheapestPrice = g.Min(p => p.UnitPrice)
        //});

        //var result = from p in ProductList
        //             group p by p.Category into g
        //             select new
        //             {
        //                 Category = g.Key,
        //                 CheapestPrice = g.Min(p => p.UnitPrice)
        //             };

        //PrintCollection(result);
        #endregion

        #region Q07
        //7.Get the products with the cheapest price in each category(Use Let)
        //var result = ProductList.GroupBy(p => p.Category).Select(g => new
        //{
        //    Category = g.Key,
        //    CheapestProduct = g.MinBy(p => p.UnitPrice)
        //});

        //var result = from p in ProductList
        //             group p by p.Category into g
        //             let minPrice = g.Min(x => x.UnitPrice)
        //             from prod in g
        //             where prod.UnitPrice == minPrice
        //             select new
        //             {
        //                 Category = g.Key,
        //                 CheapestProduct = prod
        //             };

        //PrintCollection(result);
        #endregion

        #region Q08
        /*
        //8.Get the average price of each category's products.
        //var result = ProductList.GroupBy(p => p.Category).Select(g => new
        //{
        //    Category = g.Key,
        //    AveragePrice = g.Average(p => p.UnitPrice)
        //});

        var result = from p in ProductList
                     group p by p.Category into g
                     select new
                     {
                         Category = g.Key,
                         AveragePrice = g.Average(p => p.UnitPrice)
                     };

        PrintCollection(result);
        */
        #endregion
        #endregion



    }
}
