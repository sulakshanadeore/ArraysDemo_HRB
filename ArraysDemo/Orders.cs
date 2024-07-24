using AbstractDemoLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    internal class Orders
    {
        int[] arr = new int[5] { 1,2,3,4,5};

        internal ElectronicProducts[] electroProd = new ElectronicProducts[5];//declaration
        public Orders()
        {
            //initializing the array elements
            electroProd[0] = new ElectronicProducts() { ProdID = 1, ProductName = "Laptop", Price = 40000 };
            electroProd[1] = new ElectronicProducts() { ProdID = 2, ProductName = "Hard Disk", Price = 4000 };
            electroProd[2] = new ElectronicProducts() { ProdID = 3, ProductName = "Desktop", Price = 45000 };
            electroProd[3] = new ElectronicProducts() { ProdID = 4, ProductName = "Mouse", Price = 1000 };
            electroProd[4] = new ElectronicProducts() { ProdID = 5, ProductName = "Printer", Price = 8000 };

        }

        public void InitializeArray()
        {
            


        }
    }
}
