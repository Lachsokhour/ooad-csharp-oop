using System;

namespace ooad_csharp_oop
{
    class Program
    {
        public static void Main(string[] args) {
            // ឧទាហរណ៍ទី១
            double distance, hour, fuel = 0.0;
            Console.Write("Enter the Distance: ");
            distance = Double.Parse(Console.ReadLine());
            Console.Write("Enter the Hours: ");
            hour = Double.Parse(Console.ReadLine());
            Console.Write("Enter the Fuel: ");
            fuel = Double.Parse(Console.ReadLine());
            
            Car objCar = new Car(distance, hour, fuel);
            Vehicle objVeh = objCar;
            objCar.Average();
            objVeh.Average();
            objCar.Speed();
            objVeh.Speed();
            Console.ReadKey(); 

            // ឧទាហរណ៍ទី២
            double length, width, radius = 0.0;
            Console.Write("Enter the Length: ");
            length = Double.Parse(Console.ReadLine());
            Console.Write("Enter the Width: ");
            width = Double.Parse(Console.ReadLine());
            Rectangle objRectangle = new Rectangle(length, width);
            objRectangle.Area();
            Console.Write("Enter the Radius: ");
            radius = Double.Parse(Console.ReadLine());
            Circle objCircle = new Circle(radius);
            objCircle.Area();
            Console.ReadKey(); 
        }
    }
}
