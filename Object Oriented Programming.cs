// Classes and objects
namespace OOP1
{
    public class Classes1
    {
        //public static void Main(string[] args) // Static keyword means we dont need an object to reference the class
        //{
        //    //Car car = new Car();
        //    Car.Start();
        //    Car.Drive();
        //    Car.Stop();
        //}
    }

    public static class Car
    {
        static int speed;
        static string color;
        static float price;

        public static void Start()
        {
            System.Diagnostics.Debug.WriteLine("Car is started");
        }

        public static void Drive()
        {
            System.Diagnostics.Debug.WriteLine("Car is driving");
        }

        public static void Stop()
        {
            System.Diagnostics.Debug.WriteLine("Car is stopped");
        }
    }
}

namespace OOP2
{
    public abstract class Adding
    {
        private static int number1 = 3; // Encapsulation: changing from public static to private static 
        private static int number2 = 5;

        public static int MultiplyWithExtras(int num1, int num2)
        {
            return num1 * num2 + number1 + number2;
        }
    }

    public class MainClass : Adding
    {
        //public static void Main(string[] args)
        //{
        //    //Adding.MultiplyWithExtras(1, 2);
        //    MainClass Example = new MainClass();
        //    MainClass.MultiplyWithExtras(1,2);  
        //}
    }
}

namespace Abstraction
{
    public abstract class AbstractClass { }

    public class Class1 : AbstractClass
    {
        Class1 Example = new Class1();
    }
}

namespace Inheritance
{

    public class Class1 // Adding Sealed to a class causes it to be uninheritable
    {
        protected int myInt; // Protects this variable to only be usable by classes that inherit this class, Class1
        public void Print()
        {
            System.Diagnostics.Debug.WriteLine("Hello World");
        }
    }

    public class Class2 : Class1
    {
        //public static void Main(string[] args)
        //{
        //    Class2 obj = new Class2();
        //    obj.Print();
        //    int myInt2 = obj.myInt;
        //}
    }
}


namespace Polymorphism
{
    public class Class1 
    {
        public virtual void Example() // Adding Virtual to the method makes base class method overridable for polymorphism
        {
            System.Diagnostics.Debug.WriteLine("Class 1's Example Method");
        }
    }

    public class Class2 : Class1
    {
        public override void Example()// Adding Override allows Class2 method to override Class1 method
        {
            System.Diagnostics.Debug.WriteLine("Class 2's Example Method");
        }
    }

    public class Class3
    {
        public static void Main(string[] args)
        {
            Class1 obj = new Class2();
            obj.Example();
        }
    }
}
