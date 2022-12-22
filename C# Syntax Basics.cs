/*
{
    class Program
    {
        public static void Main(String[] args) // Main Method. Static means main method can be called without an object. Void means this method does not return a value
        {
            bool complete = false;
            bool started = true;
            int x;

            int i = 3;
            while(i > 0)
            {
                System.Diagnostics.Debug.WriteLine("Loading");
                i--;
            }
        }
    }
}
*/

// C# is case sensitive with variable names
// The first character must be a letter or underscore
// C# variables can only contain letters, numbers, and underscore character

/*
class Program1
{
    public static void Main(String[] args)
    {
        PrintHi();
    }

    static void PrintHi() // Because the main function is static, this function must also be static so that it can be called
    {
        System.Diagnostics.Debug.WriteLine("Hi");
    }
}
*/

/*
class Program2
{
    public static void Main(String[] args)
    {
        PrintMessage("Hello World");
    }

    static void PrintMessage(string message)
    {
        System.Diagnostics.Debug.WriteLine(message);
    }
}

*/

// There are 4 main access modifiers: public, protected, private, and internal

// public: variables and functions that can be accessed by any classes having a reference to this class
// want to reduce the number of variables and functions that are private.
// makes sure the code is as encapsulated as possible

// protected: a variable or method that is protected within one class can only be accessed by a another class
//  that is a subclass of the original class. But another class cannot access this variable.

// private: a variable or method that is private within one class cannot be accessed by a another class
//  that is a subclass of the original class. 

// If a variable does not have an access modifier declared, it is thought of as a private variable
// If a class does not have an access modifier declared, it is thought of as internal by default 

// If a class within a class, the internal class has a default access of private and outer class has default access of internal


/*
namespace ExampleProj2
{
    class Program
    {
        public static void Main(String[] args)
        {
            System.Diagnostics.Debug.WriteLine(5 % 4);
        }
    }
}
*/

/*
namespace ExampleProj3
{
    class Program
    {
        public static void Main(String[] args)
        {
            int number = 4;
            number--;
            System.Diagnostics.Debug.WriteLine(number);
        }
    }
}
*/

// Is operator: Used to check if a value is of a certain type
// Helps avoid an InvalidCastException
// Lets us know if we can case to a certain type

/*
public class Ex1 { }
public class Ex2 : Ex1 { }

class Program
{
    public static void Main(String[] args)
    {
        Ex2 ex2Object = new Ex2();
        bool b = ex2Object is Ex1;
        System.Diagnostics.Debug.WriteLine(b);
    }
}

*/

/*
namespace ExampleProj
{
    class Program
    {
        public static void Main(String[] args)
        {
            int x;
            int value;
            var isGreater = x > value ? true : false;
        }
    }
}
*/

namespace ExampleProj
{
    class Box
    {
        private int length;
        private int width;
        private int height;

        public Box(int length, int width, int height)
        {
            this.length = length; // Using 'this' we reference the class member variables. 
            this.width = width; // Otherwise we are referencing the arguments passed into the constructor
            this.height = height;
        }

        public int GetLength() // Getter functions
        {
            return length;
        }

        public int GetWidth() // Getter functions
        {
            return width;
        }

        public int GetHeight() // Getter functions
        {
            return height;
        }

        public static Box operator +(Box box1, Box box2) // creating the overloaded operator
        {
            return new Box(box1.GetLength() + box2.GetLength(),
                box1.GetWidth() + box2.GetWidth(),
                box1.GetHeight() + box2.GetHeight());
        }
    }

    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Box box1 = new Box(2,2,2);
    //        Box box2 = new Box(2,2,2);
    //        Box box3 = box1 + box2;
    //        System.Diagnostics.Debug.WriteLine("Length: " + box3.GetLength());
    //        System.Diagnostics.Debug.WriteLine("Width: " + box3.GetWidth());
    //        System.Diagnostics.Debug.WriteLine("Height: " + box3.GetHeight());
    //    }
    //}
}
