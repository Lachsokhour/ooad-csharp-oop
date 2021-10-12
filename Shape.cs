using System;

namespace ooad_csharp_oop
{
    // ឧទាហរណ៍ទី២
    public class Shape
    {
        protected double length = 0.0;
        protected double radius = 0.0;
        protected double width = 0.0;

        public Shape(double length, double width) {
            this.length = length;
            this.width = width;
        }

        public Shape(double radius) {
            this.radius = radius;
        }

        public virtual void Area() {
            double area = 0.0;
            area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of Shape is :{0:0.00} ", area);
        }
    }

    public class Rectangle : Shape {
        public Rectangle(double length, double width)
            : base(length, width) {
        }
        public override void Area() {
            double area = 0.0;
            area = length * width;
            Console.WriteLine("Area of Rectangle is : {0:0.00} ", area);
        }
    }
    public class Circle : Shape {
        public Circle(double radius)
            : base(radius) {
        }
    }
}