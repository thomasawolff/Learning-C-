using System.Diagnostics;

// Constructors:
// Whenever a class is called to instantiate and object, its constructor is called
// Constructors allow to create default objects as soon as the object is created
// and make code more flexable and easier to read

// Constructor must have same name as the class
// We can initialize values inside constructors

namespace ExampleProj
{
    public class Example
    {
        int exampleNumber;
        string exampleName;

        public Example(int num)
        {
            exampleNumber = num;
        }

        public Example(int num, string name)
        {
            exampleNumber = num;
            exampleName = name;
        }

//        public static void Main(string[] args)
//        {
//            Example ex = new Example(12);
//            Example ex2 = new Example(12, "Thelma");
//            System.Diagnostics.Debug.WriteLine(ex.exampleNumber, ex2.exampleName);

//            // ~Example() { } <<--- finalizer
//        }
    }
}

// Finalizers:
// Similar to constructors, but finalizers are called when garbage is being collected by collector
// A class has just on finalizer and it has no parameters
// Also have no access modifiers


// Properties:
// We dont want to make many variables public. Since these variables can be assigned different values 
// by any classes, comprimising the integrity of the code.
// Properties have all the benefits of being a private variable but can still be public.

// Public values but not without uncontrolled access to objects data
// Allow to get and set variables
// get: returns the property value
// set: assigns the property value

// Attributes can accept arguments just methods or properties
// A program can examine its own metadata or other programs by using reflection 
// Specify an attribute by placing the name of attribute in square brackets
// above variable, class, or method it applies to

// Attribute can be applied to any of the following programming constructs:
// Assembly
// Module
// Field
// Event
// Method
// Param
// Property
// Return type

{
    public class Attributes
    {
        [Obsolete("OldMethod is obsolete, Please use the NewMethod instead.")]
        static void OldMethod() { }

        static void NewMethod() { }

        public string Id_ { get; set; }  auto-implemented property

        private string id;

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        // public static void Main(string[] args)
        // {
        //     Program program = new Program();
        //     program.Id = "1234";  // using the set ability of the property
        //     System.Diagnostics.Debug.WriteLine(program.Id);  // using the get ability of the property
        //     OldMethod();

        // }
    }

    [AttributeUsage(AttributeTargets.All)]  //Step 2: use the attribute usage attribute and pass in AttributeTargets.All: valid to all targets
    public class ExampleAttribute : Attribute { }  //Creating a custom attribtue: step 1, create a class the extends the attribute class

    class Example
    {
        [ExampleAttribute]
        private object exampleObj;
    }



}

//Lambda expressions: Two types
//Expression lamda: open & closed parenthesis,lamda operator, and the expression 

{
   namespace ExampleProj
   {
       public class Example
       {
        //    public static void Main(string[] args)
        //    {   
        //        // Lambda parameters are only valid inside of the lambda and not valid inside the enclosing method
        //        // This applies to return statements on the lambda function
        //        // Return statement on the lambda will stop execution of lambda but outer method will continue to run
        //        // Go to, break, continue only valid if inside the lambda block, cannot be used to jump to outer function
        //        Action<string> debug = (s) => System.Diagnostics.Debug.WriteLine("Hello World"); // Expression lambda passing parameter s
        //        debug("Example");

        //        // Using Func to be able to call a lambda function to multiply two numbers
        //        Func<int, int, int> multiply = (x, y) => { return x * y; };
        //        System.Diagnostics.Debug.WriteLine(multiply(3, 2));
        //    }
       }
   }

}

{
    namespace ExampleProj
    {
        public static class Program // Extension Methods
        {
            public static bool GreaterThan(this int i, int val)
            {
                if (i > val)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class Example
        {
            public void PrintHelloWorld()
            {
                System.Diagnostics.Debug.WriteLine("Hello World");
            }

            static async Task CookMeat() // using System.Threading.Tasks for async functions
            {
                Debug.WriteLine("Cook Meat");
            }

            static async Task CookVegetables()
            {
                Debug.WriteLine("Cook Vegetables");
            }

            static async Task MakeBread()
            {
                Debug.WriteLine("Make Bread");
            }

            static async Task MakeSoup()
            {
                Debug.WriteLine("Make Soup");
            }

            static async Task MakeSalad()
            {
                Debug.WriteLine("Make Salad");
            }

            static async Task MakeDrinks()
            {
                Debug.WriteLine("Make Drinks");
            }

            public static async Task MakeDinnerAsync()
            {
                await CookMeat();
                await CookVegetables();
                await MakeBread();
                await MakeSoup();
                await MakeSalad();
                await MakeDrinks();
            }
        }

        public class Example2 : Example // Using inheritance to print Hello World to the console
        {
            public void PrintHelloWorld() // Method overriding
            {
                System.Diagnostics.Debug.WriteLine("Hi world, how are you?");
            }

            public static void Example1(params string[] words) // Type of the params parameter has to be a single-dimensional array
                                                               // Can only use the params parameter once in a method decleration
                                                               // Cannot have multiple endless types for a method 
            {
                foreach (string word in words)
                {
                    System.Diagnostics.Debug.WriteLine(word);
                }
            }

            //public static void Main(string[] args)
            //{
            //    Example2 ex2 = new Example2();
            //        ex2.PrintHelloWorld();
            //    Example1();
            //    Example1("Hi");
            //    Example1("Hi", "Hello World");
            //    Example1("Hi", "Hello World", "Goodbye");

            //    System.Diagnostics.Debug.WriteLine(8.GreaterThan(1));

            //    MakeDinnerAsync();

            //}
        }
    }
}
