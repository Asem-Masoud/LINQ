using System.Collections;
using System.Text.RegularExpressions;
using static LINQ02.ListGenerator;


namespace LINQ02
{
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

            #region 00 Revision
            /*
            // // Implicitly Typed Local Variable [var — dynamic]

            ////int x = 12;
            ////var x = 12;

            //dynamic x = 12; // Lile var in JS

            // Anonymous Type
            // Extension Methods
            // LINQ :  +40 Extension Methods

            //setup data
            Console.WriteLine(ListGenerator.ProductList[1]);
            Console.WriteLine(ListGenerator.CustomerList[1]);

            // To use static member of static class directly
            // using static class
            // -> using static linq2.ListGenerator
            Console.WriteLine(ProductList[1]);
            Console.WriteLine(CustomerList[2]);
            */
            #endregion


            #region 01 Filtration Operator - Where & OfType

            // LINQ :  +40 Extension Methods
            // LINQ :  13 Category

            // 1. Filtration Operator - Where / OfType

            // All product Out Stock

            //// Fluent Syntax
            //var result = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //// Query Syntax [Query Expression]
            //var result = from p in ProductList
            //             where p.UnitsInStock == 0
            //             select p;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //var result = ProductList.Where(p => p.Category == "Meat/Poultry");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry"
            //             select P;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            ////// 2 Condition

            //var result = ProductList.Where(p => p.Category == "Meat/Poultry").Where(p => p.UnitsInStock > 0);
            ////var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Poultry");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            //var result = from p in ProductList
            //             where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //             select p;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //////////////////////////////////

            // Indexed where Valid Only in Fluent Syntax
            // Can't Be written Using Query Syntax [Query Expression]
            //var result = ProductList.Where((p, index) => index < 10 && p.UnitsInStock == 0);
            //var result = ProductList.Where((p, index) => index < 5);
            //var result = ProductList.Where((p, index) => index < 5 && p.UnitsInStock > 0);
            //var result = ProductList.Where(p => p.UnitsInStock > 0).Where((p, I) => I < 5);


            //foreach (var item in result)
            //{

            //    Console.WriteLine(item);

            //}

            /////////////////////////


            //// OfType
            //ArrayList arrayList = new ArrayList() { 1, "Hello", 2, "From", 3, "ArrayList", 4, 5, 6, "World", 2.5f };
            //var result = arrayList.OfType<string>();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region 02 Transformation Operators - Select, SelectMany

            //var result = ProductList.Select(p => p.ProductName);
            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Seafood").Select(p => new {Name = p.ProductName, p.Category, OldPrice = p.UnitPrice, NewPrice = p.UnitPrice * 0.9m});

            // If one of the property is a sequence then use SelectMany
            //var result = CustomerList.SelectMany(c => c.Orders);

            // Indexed Where is only valid in fluent syntax
            // can't be written using query syntax
            //var result = ProductList.Select((p, i) => new { i, p.ProductName }).Where(p => p.i < 5);


            //var result = from p in ProductList
            //             select p.ProductName;

            //var result = from p in ProductList
            //             where p.UnitsInStock > 0 && p.Category == "Seafood"
            //             select new
            //             {
            //                Name = p.ProductName,
            //                p.Category,
            //                OldPrice = p.UnitPrice,
            //                NewPrice = p.UnitPrice * 0.9m
            //             };

            //var result = from c in CustomerList
            //             from o in c.Orders
            //             select o;

            //PrintCollection(result);

            #endregion


            #region 03 Ordering Operators

            //var result = ProductList.OrderBy(p => p.UnitPrice).Select(p => new {p.ProductName, p.UnitPrice, p.UnitsInStock});
            //var result = ProductList.Where(p => p.Category == "Meat/Poultry" && p.UnitsInStock > 0)
            //    .OrderBy(p => p.UnitsInStock)
            //    .ThenByDescending(p => p.UnitPrice)
            //    .Select(p => new { p.ProductName, p.UnitPrice, p.UnitsInStock });



            //var result = from p in ProductList
            //             where p.Category == "Meat/Poultry" && p.UnitsInStock > 0
            //             orderby p.UnitsInStock ascending, p.UnitPrice descending
            //             select new
            //             {
            //                 p.ProductName,
            //                 p.Category,
            //                 p.UnitsInStock,
            //                 p.UnitPrice
            //             };

            //var result = ProductList.Reverse<Product>();

            //PrintCollection(result);

            #endregion


            #region 04 Element Operators - Immediate Execution
            // First - Last
            //var result = ProductList.First(); // May throw Exception (Sequence contains no elements)
            //var result = ProductList.Last();    // May throw Exception (Sequence contains no elements)

            //var result = ProductList.First(p => p.UnitsInStock == 1000);    // May throw Exception (Sequence contains no matching elements)
            //var result = ProductList.Last(p => p.UnitsInStock == 1000);    // May throw Exception (Sequence contains no matching elements)

            //var result = ProductList.FirstOrDefault();  // Safe
            //var result = ProductList.FirstOrDefault(new Product() { ProductName = "Default Product"});

            //Console.WriteLine(result?.ProductName ?? "Null");

            //var result = ProductList.FirstOrDefault(p => p.UnitsInStock == 1000, new Product() { ProductName = "Default Product" });
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice == 0);

            //var result = ProductList.LastOrDefault();  // Safe
            //var result = ProductList.LastOrDefault(new Product() { ProductName = "Default Product" });

            //Console.WriteLine(result?.ProductName ?? "Null");

            //var result = ProductList.LastOrDefault(p => p.UnitsInStock == 1000, new Product() { ProductName = "Default Product" });

            //Console.WriteLine(result);



            // ElementAt
            //var result = ProductList.ElementAt(0);      // May throw exception
            //var result = ProductList.ElementAtOrDefault(0);

            //var result = ProductList.Single();  // May throw exception
            // Sequence coontains no elements or more than one elements

            //var result = ProductList.Single(p => p.UnitsInStock == 0);  // May throw exception
            // Sequence contains no matching elements or more than one mathcing elements

            //var result = ProductList.SingleOrDefault();  // May throw exception
            // Sequence contains more than one elements
            // return default value if the sequence is empty

            //var result = ProductList.SingleOrDefault(new Product() { ProductName = "Default Product" });
            // May throw exception
            // Sequence contains more than one elements
            // return default value if the sequence is empty


            //var result = ProductList.Single(p => p.UnitsInStock == 0);  // May throw exception
            // Sequence contains more than one mathcing elements
            // returns default if no matching elements or empty

            //var result = ProductList.SingleOrDefault(p => p.UnitsInStock == 1000, new Product() { ProductName = "Default Product" });


            //Console.WriteLine(result);




            // DefaultIfEmpty()
            //var result = ProductList.DefaultIfEmpty();
            //var result = ProductList.DefaultIfEmpty(new Product() { ProductName = "Default Product" });

            //PrintCollection(result);
            #endregion


            #region 05 Aggregate Operators - Immediate Execution
            // Count - Sum - Max - Min - Avg

            // Count
            //var result = ProductList.Count();
            //var result = ProductList.Count;

            //var result = ProductList.Count(p => p.UnitsInStock == 0);   //5

            //var result = ProductList.Where(p => p.UnitsInStock == 0).Count();


            // Sum
            //var result = ProductList.Sum(p => p.UnitPrice);
            //var result = ProductList.Sum(p => p.UnitsInStock);


            // Avg
            //var result = ProductList.Average(p => p.UnitPrice);


            // Max
            //var result = ProductList.Max();
            //var result = ProductList.Max(new ProductComparerUnitInStock());
            //var result = ProductList.Max(p => p.UnitsInStock);

            //var maxPrice = ProductList.Max(p => p.UnitPrice);
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice == maxPrice);

            //var result = ProductList.MaxBy(p => p.UnitPrice);



            // Min
            //var result = ProductList.Min();
            //var result = ProductList.Min(new ProductComparerUnitInStock());
            //var result = ProductList.Min(p => p.UnitPrice);
            //var result = ProductList.MinBy(p => p.UnitPrice);
            //var result = ProductList.MinBy(p => p.ProductName, new ProductComparerNameLength());



            // Aggregate
            //List<string> names = new List<string>() { "Ahmed", "Ali", "Omar", "Osama" };
            //var result = names.Aggregate((str01, str02) => $"{str01} {str02}");


            //Console.WriteLine(result);
            #endregion


            #region 06 Casting Operators - Immediate Execution

            //List<Product> result = (List<Product>) ProductList.Where(p => p.UnitsInStock == 0);
            //List<Product> result = ProductList.Where(p => p.UnitsInStock == 0).ToList();
            //Product[] result = ProductList.Where(p => p.UnitsInStock == 0).ToArray();
            //Dictionary<long, Product> result = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p => p.ProductID);
            //HashSet<Product> result = ProductList.Where(p => p.UnitsInStock == 0).ToHashSet();


            //PrintCollection(result);
            #endregion


            #region 07 Generation Operators

            // The only way to call this method is -> class member method through enumerable class
            // Range - Empty - Repeat

            //var result = Enumerable.Range(1, 100);
            //var result = Enumerable.Empty<Product>().ToList();
            //result.Add(new Product() { ProductName = "Product01"});
            //var result = Enumerable.Repeat(ProductList[0], 3);
            //var result = Enumerable.Repeat(1, 30);


            //PrintCollection(result);
            #endregion


            #region 08 Set Operators

            // Union Family
            // Union - UnionAll - Intersect - Except

            //var seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(50, 100);

            //var result = seq01.Union(seq02);    // Like Union in sql, without duplication
            //var result = seq01.Concat(seq02);     // Like UnionAll in sql, with duplication
            //result = result.Distinct();           // Remove Duplication
            //var result = seq01.Intersect(seq02);
            //var result = seq01.Except(seq02);
            //var result = seq02.Except(seq01);



            //PrintCollection(result);
            #endregion


            #region 09 Quantifier Operators - Return Boolean

            // Any - All - SequenceEquals - Conatins

            //var seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(50, 100);

            // Any() -> If there is one element at least is in the sequence or match the condition
            //var result = seq01.Any();
            //var result = seq01.Any(n => n $ 2 == 0);


            //var result = ProductList.Any(p => p.UnitsInStock == 0);



            // All() -> returns true if all elements in the sequence matchs the condition or empty sequence
            //var result = ProductList.All();
            //var result = ProductList.All(p => p.UnitPrice > );


            // SequnceEqual()
            //var result = seq01.SequenceEqual(seq02);


            // Contains()
            //var result = seq01.Contains(1);

            //var result = ProductList.Contains();

            //Console.WriteLine(result);
            #endregion


            #region V10 Zip Operator

            //var words = new List<string>() { "Ten", "Twenty", "Thirty" };
            //var numbers = new List<int>() { 10, 20, 30, 40, 50 };

            //var result = words.Zip(numbers, (w,n) => $"{n}: {w}");

            //PrintCollection(result);

            #endregion


            #region 11 Grouping Operators

            //var result = ProductList.GroupBy(p => p.Category);
            //var result = from p in ProductList
            //             group p by p.Category;
            //var result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             group p by p.Category;
            //var result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //             into Category
            //             where Category.Count() > 5
            //             select new { CategoryName = Category.Key, CategoryCount = Category.Count() };


            //var result = ProductList
            //    .Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 5)
            //    .Select(g => new
            //    {
            //        CategoryName = g.Key,
            //        CategoryCount = g.Count()
            //    });

            //PrintCollection(result);

            //foreach (var category in result)
            //{
            //    Console.WriteLine($"{category.Key}:");
            //    foreach(var item in category)
            //    {
            //        Console.WriteLine($"  {item}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region 12 Partitioning Operators

            // Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile
            //var result = ProductList.Take(5);
            //var result = ProductList.Where(p => p.UnitsInStock == 0).Take(3);
            //var result = ProductList.Where(p => p.UnitsInStock == 0).TakeLast(3);
            //var result = ProductList.TakeLast(3);

            //var result = ProductList.Skip(5);
            //var result = ProductList.Skip(5).Take(5);
            //var result = ProductList.SkipLast(5);

            //int[] numbers = { 4, 1, 2, 3, 4, 5 };
            //var result = numbers.TakeWhile(n => n % 3 == 0);
            //var result = numbers.SkipWhile(n => n % 3 != 0);

            //int[] numbers = { 5, 4, 1, 3, 9, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((n, i) => n > i);
            //var result = numbers.SkipWhile((n, i) => n > i);


            //PrintCollection(result);
            #endregion


            #region 13 Let and Into
            /*
            // aeoiuAEOIU
            List<string> names = ["Ahmed", "ALi", "Mohamed", "Mona", "Mariam", "Tuqaa", "Saly", "Osama"];

            var result0 = Regex.Replace("Ahmed", "[aeoiuAEOIU]", string.Empty);
            PrintCollection(result0);

            // into : Restart Query with introducing new range variable 
            var result = from name in names
                         select Regex.Replace(name, "[aeoiuAEOIU]", string.Empty)
                         into NoVowlNames
                         where NoVowlNames.Length > 3
                         select NoVowlNames;
            PrintCollection(result);

            // let : Continue query with adding new range variable
            var result2 = from name in names
                          let NoVowlNames = Regex.Replace(name, "[aeoiuAEOIU]", string.Empty)
                          where NoVowlNames.Length > 3
                          select NoVowlNames;

            PrintCollection(result2);
            */
            #endregion

        }
    }
}