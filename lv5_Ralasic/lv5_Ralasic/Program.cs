using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv5_Ralasic
{
    class Program
    {
        static void Main(string[] args)
        {
            IShipable item1 = new Product("Smartphone", 450, 1);
            IShipable item2 = new Product("Pencil", 5, 0.01);
            IShipable item3 = new Product("Toy car", 50, 5);
            IShipable item4 = new Product("Book", 10, 2);
            IShipable item5 = new Product("NoteBook", 1000, 4.5);
            
            Box box1 = new Box("Small Box");
            Box box2 = new Box("Large Box");

            ShippingService service1 = new ShippingService(0.4);

            box1.Add(item1);
            box1.Add(item2);
            box1.Add(box2);
            box2.Add(item3);
            box2.Add(item4);
            box2.Add(item5);

            Console.Write(box1.Description());
            
            Console.WriteLine("Box shipping cost: "+ service1.TotalShippingCost(box1));
            Console.WriteLine("Item shipping cost: "+ service1.TotalShippingCost(item5));
           
            Console.Write("Box weight: ");
            Console.WriteLine(box1.Weight);
            Console.Write("Box price: ");
            Console.WriteLine(box1.Price);

            
        }
    }
}
