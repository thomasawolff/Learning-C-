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

// Public access modifier: anyone can access variable or function
// Protected access modifier: only it's class and any sub-classes of its class can access the variable or function
// Private access modifier: all access to variable or function has to be in the same (it's) class
// Internal: only classes in the same assembly can access the variable or function.
// We should make all variables private but access them through properties
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
        public static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.Print();
            int myInt2 = obj.myInt;
        }
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

    //public class Class3
    //{
    //    public static void Main(string[] args)
    //    {
    //        Class1 obj = new Class2();
    //        obj.Example();
    //    }
    //}
}


namespace partialClasses
{
    // The partial keyword can be used to split the definition of a class, method, interface, or struct into
    // multiple files. Though they all must have the same access modifiers. Namespaces and classes must
    // also have the same name.

    public partial class PartialClass
    {
        void Method1() { }
    }
}


namespace Indexers
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    ExampleClassWithIndexer exampleClassWithIndexer = new ExampleClassWithIndexer();
        //    exampleClassWithIndexer[0] = "Hi";
        //    exampleClassWithIndexer[1] = 2;
        //    exampleClassWithIndexer[2] = true;
        //    exampleClassWithIndexer[3] = 1.0f;

        //    for(int i = 0; i < 4; i++)
        //    {
        //        System.Diagnostics.Debug.WriteLine(exampleClassWithIndexer[i]);
        //    }
        //}
    }

    // Indexer is a special type of method to be added to a class so that it can be indexed like an array
    // Indexers are referenced by the This keyword. Refers to the object instance
    public class ExampleClassWithIndexer
    {
        private string[] dataArray = new string[100];
        public object this[int index]
        {
            get { 
                if(index < 0 || index >= dataArray.Length)
                {
                    System.Diagnostics.Debug.WriteLine("Invalid Index");
                    return new object();
                } else
                {
                    return dataArray[index];
                }
            }
            set {
                if (index < 0 || index >= dataArray.Length)
                {
                    System.Diagnostics.Debug.WriteLine("Invalid Index");
                }
                else
                {
                    dataArray[index] = (string) value;
                }
            }
        }
    }
}
