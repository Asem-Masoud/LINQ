using static LINQ01.ListGenerator;

namespace LINQ01
{

    internal class Program
    {

        #region S01R01

        //public static var Print(var x)
        //{
        //    return x;
        //} // 5. Invalid

        #endregion

        static void Main()
        {

            #region 01 Implicitly-Type Local Variables [var - dynamic]

            /*// var: 
            var Data01 = "Ahmed";

            // 1. Compiler Can Detect the DataType of The Local Variable Based on Initial Value, At Compilation Time

            // var Data02; //Invalid -> // 2. Must Be Initialized

            // var Data03 = null; //Invalid -> // 3. Can't Initialized The Local Variable By null

            // var Data01 = 1.2m; //Invalid -> // 4. Can't change DataType of The Local Variable After Initialization
            // in 1st var Data01 = "Ahmed"; [string] then var Data01 = 1.2m; [Decimal]

            // 5. Can't Use Var As Parameter or Return Type

            // ----------------------------------------------------//

            // Dynamic: Lile Var in JS

            dynamic Data04 = "Asem";
            Console.WriteLine(Data04.GetType().Name); // String

            // 1. CLR Detect the DataType of The Local Variable Based on Last Value, At RunTime.
            // 2. Don't Need To Be Initialized.
            // 3. Can Initialized The Local Variable By null.
            // 4. Can change DataType of The Local Variable After Initialization.
            // 5. Can Use Var As Parameter or Return Type.
            // 6. Be CareFul When Used Dynamic.
            // 7. Like var in JS Or object in C#.

            //Data04 = null;
            //Console.WriteLine(Data04.GetType().Name); //.RuntimeBinderException: Cannot perform runtime binding on a null reference

            Data04 = 12;
            Console.WriteLine(Data04.GetType().Name); // Int32

            Data04 = 12.5;
            Console.WriteLine(Data04.GetType().Name); // Double

            Data04 = 12.5f;
            Console.WriteLine(Data04.GetType().Name); // Single

            Data04 = 12.5m;
            Console.WriteLine(Data04.GetType().Name); // Decimal

            Data04 = true;
            Console.WriteLine(Data04.GetType().Name); // Boolean

            //var x = 12;
            //var X = () => Console.WriteLine(Data04.GetType().Name);
            //var X = delegate () { Console.WriteLine(Data04.GetType().Name); };
            //dynamic X = delegate () { Console.WriteLine(Data04.GetType().Name); }; // Invalid
            */

            #endregion


            #region 02 Anonymous Type

            // Anonymous Type : Used We need to Using This Type Once Time, Or Found Data not Known this type
            //Employee E01 = new Employee() { Id = 1, Name = "Asem", Salary = 12000 };
            /*
            var E01 = new { Id = 1, Name = "Asem", Salary = 12000.0m };

            Console.WriteLine(E01.Id);
            Console.WriteLine(E01.Name);
            Console.WriteLine(E01.Salary);

            //E01.Id = 12; // Invalid -> Immutable Can't Change Its Value After Creation

            Console.WriteLine(E01.GetType().Name); //<>f__AnonymousType0`3

            Console.WriteLine(E01);// { Id = 1, Name = Asem, Salary = 12000.0 }
                                   // Compiler Will Override On ToString

            var E02 = new { Id = 1, Name = "Asem", Salary = 12000.0m };
            Console.WriteLine(E02.GetType().Name);//<>f__AnonymousType0`3
            var E03 = new { id = 12, Name = "Ahmed", Salary = 15000.0m };
            Console.WriteLine(E03.GetType().Name);//<>f__AnonymousType1`3
            // The Same Anonymous Type As Long as:
            // 1. The Same Property Name [Case Sensitive]
            // 2. The Same Property Order

            Console.WriteLine(E01.GetHashCode());//
            Console.WriteLine(E02.GetHashCode());

            if (E01.Equals(E02))// Comp will override on Equals
                Console.WriteLine("E01 == E02");
            else
                Console.WriteLine("E01 != E02");

            //------------------------------//

            var E04 = E02;
            Console.WriteLine(E04);//{ Id = 1, Name = Asem, Salary = 12000.0 }

            var E05 = E02 with { Id = 5 }; // New Feature C# 10.0
            Console.WriteLine(E05);//{ Id = 5, Name = Asem, Salary = 12000.0 }
            */

            #endregion


            #region 03 Extension Methods
            /*
            ///////////////INT///////
            int Number = 12345;
            //var Result = IntExtension.Reverse(Number);// class member method
            var Result = Number.Reverse();// Extension Methods
            Console.WriteLine(Result);//54321

            ///////////////LONG///////
            long Num = 50263256;
            var Result2 = Num.Reverse();
            Console.WriteLine(Result2);
            */
            #endregion


            #region 04 What is LINQ

            // LINQ: Language Integrated Query
            //     : +40 Extension Methods (LINQ Operators) Against Any Data [Data in Sequence]
            //     : Regardless Data store.
            //     : 13 Category
            //     : LINQ Operators Exists in Built-in Class "Enumerable"

            // Sequence: Object From Class Implement Interface "IEnumerable"
            // Local Sequence: L2O -> LINQ TO Object OR L2XML
            // Remote Sequence: L2EF 

            // LINQ Operators Has 3  أشكال
            // Input Sequence -> LINQ Operators -> OutPut Sequence
            // Input Sequence -> LINQ Operators -> One Value
            //                -> LINQ Operators -> OutPut Sequence


            /*// Example For Return Sequence
            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var Result = Enumerable.Where(Numbers, N => N % 2 == 0);

            foreach (var n in Result) { Console.Write($"{n}"); }
            */

            /*// Example For Return One Value
             List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
             var Result = Enumerable.Any(Numbers, N => N % 2 == 0); // Any -> Return True/False

             Console.WriteLine(Result);
            */

            #endregion


            #region 05 LINQ Syntax

            // 1. Fluent Syntax
            // Use LINQ Methods

            /*// 1.1. LINQ Operator as => Class Member Method Through Class "Enumerable"

             List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
             var result = Enumerable.Where(Numbers, X => X % 2 == 0);
             foreach (var item in result)
             {
                 Console.Write(item + " ");
             }
             */

            /*// 1.2. LINQ Operator as => Extension Method Through Sequence [Recommended]

            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var result = Numbers.Where(X => X % 2 == 0);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            */


            /*// 2. Query Syntax [Query Expression] Like SQL Style
            // Start By -> from
            // End By -> select , group by
            // Query Syntax easier than fluent (Join, Group By, Let, Into )

            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = from N in Numbers
                         where N % 2 == 0
                         select N;

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            */


            #endregion


            #region 06 LINQ Execution Ways

            // 1. Differed Execution Way : not Working in the same line that calling in it -> 10 Category

            // 2. Immediate Execution Way : Working in the same line that calling in it -> 3 Category [Element,Casting & Aggregate Operators]

            /*// Differed [Where]
            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = Numbers.Where(X => X % 2 == 0); // Differed

            Numbers.AddRange(new int[] { 9, 10, 11, 12, 13, 14 });

            foreach (var item in result)// here
            {
                Console.Write(item + " ");
            }
            */


            /* // Immediate [ToList()]
            List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var result = Numbers.Where(X => X % 2 == 0).ToList(); // Immediate

            Numbers.AddRange(new int[] { 9, 10, 11, 12, 13, 14 });// Don't Effected

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            */

            #endregion


            #region 07 Setup Data

            //ProductList.

            /*
            //Console.WriteLine(ListGenerator.ProductList[0]);
            //Console.WriteLine(ListGenerator.CustomerList[0]);


            var result = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            var result2 = ListGenerator.CustomerList.Where(C => C.City == "Berlin");

            foreach (var item2 in result2)
            {
                Console.WriteLine(item2);
            }
            */


            /*// Syntax Sugar After Typing [using static LINQ01.ListGenerator;] Before NameSpace

            Console.WriteLine(ProductList[0]);
            Console.WriteLine(CustomerList[0]);


            var result = ProductList.Where(P => P.UnitsInStock == 0);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            var result2 = CustomerList.Where(C => C.City == "Berlin");

            foreach (var item2 in result2)
            {
                Console.WriteLine(item2);
            }
            */


            #endregion

        }
    }
}
