namespace ooad_csharp_oop
{
    // ឧទាហរណ៍ទី១
    public class Vehicle
    {
        protected double distance = 0.0;
        protected double hour = 0.0;
        protected double fuel = 0.0;

        public Vehicle(double distance, double hour, double fuel) {
            this.distance = distance;
            this.hour = hour;
            this.fuel = fuel;
        }

        public virtual void Average() {
            double average = 0.0;
            average = distance / fuel;
            System.Console.WriteLine("Vehicle Average is {0:0.00}", average);
        }

        public virtual void Speed() {
            double speed = 0.0;
            speed = distance / hour;
            System.Console.WriteLine("Vehicle Average is {0:0.00}", speed);
        }
    }

    public class Car : Vehicle {
        public Car(double distance, double hour, double fuel)
            : base(distance, hour, fuel) {
        }

        public override void Average() {
            double average = 0.0;
            average = distance / fuel;
            System.Console.WriteLine("Vehicle Average is {0:0.00}", average);
        }

        public override void Speed() {
            double speed = 0.0;
            speed = distance / hour;
            System.Console.WriteLine("Vehicle Average is {0:0.00}", speed);
        }
    }
}