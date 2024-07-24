using AbstractDemoLibrary;
using ArraysDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        //SingleDimensionalArrays();

        //MultiDimensionalArray();
        //JaggedDemo();

       

        //ElectronicProducts p1=new ElectronicProducts();
        //p1.ProdID = 1;
        //p1.ProductName = "Laptop";
        //p1.Price = 40000;
        //electroProd[0] = p1;




      
        Orders order1=new Orders();
      //  order1.InitializeArray();
        


        foreach (var product in order1.electroProd) 
        {
            Console.WriteLine(product.ProdID);
            Console.WriteLine(product.ProductName);
            Console.WriteLine(product.Price);

        }





        Console.ReadLine();









    }

    private static void JaggedDemo()
    {
        int[][] jagged = new int[4][];
        jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
        jagged[1] = new int[4] { 10, 20, 30, 40 };
        jagged[2] = new int[6] { 100, 200, 300, 400, 500, 600 };
        jagged[3] = new int[10] { 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000 };


        foreach (var inArray in jagged)
        {

            foreach (var element in inArray)
            {

                Console.Write(element + "\t");
            }
            Console.WriteLine();
        }
    }

    private static void MultiDimensionalArray()
    {
        int[,] arr1 = new int[4, 3] {
            { 0, 0, 0 },
            { 1, 1, 1 },
            { 2, 2, 2 },
            { 3, 3, 3 }
        };
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                //   Console.WriteLine("arr1[{0},{1}] = {2}", i, j, arr1[i, j]);
                Console.WriteLine($"arr1[{i},{j}]={arr1[i, j]}");
            }
        }
    }

    private static void SingleDimensionalArrays()
    {
        int[] arr = new int[5] { 100, 200, 300, 400, 500 };

        int[] arr1 = new int[5];
        arr1[0] = 10;
        arr1[1] = 21;
        arr1[2] = 300;
        arr1[3] = 140;
        arr1[4] = 510;
        foreach (var t in arr1)
        {
            Console.WriteLine(t);
        }

        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    Console.WriteLine(arr1[i]);
        //}

        Array.Sort(arr1);
        Array.Reverse(arr1);
        Console.WriteLine("Sorted Array:");
        //for (int i = 0; i < arr1.Length; i++)
        //{
        //    Console.WriteLine(arr1[i]);
        //}




        foreach (var t in arr1)
        {
            Console.WriteLine(t);
        }




        //Console.WriteLine("------------------------------------");

        //Array a=Array.CreateInstance(typeof(int), 5);
        //            //Value,index
        //a.SetValue(10, 0);
        //a.SetValue(20, 1);
        //a.SetValue(30, 2);
        //a.SetValue(40, 3); 
        //a.SetValue(50, 4);

        //a.GetValue(0);


        //for (int i = 0; i < a.Length; i++)
        //{
        //   Console.WriteLine(a.GetValue(i));

        //}
    }
}