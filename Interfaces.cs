using System.Collections; // Importing the name space for IComparer,IEnumerable interfaces
using System.ComponentModel; // To bring in the INotifyPropertyChanged interface
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace ExampleProj
{
    class Program : IExample, ISecondExample2

    {
        //public static void Main(String[] args)
        //{

        //}

        public void Example()
        {
            System.Diagnostics.Debug.WriteLine("Hello World");
        }

        public int Example2()
        {
            return 1;
        }

        public string Example3(string string1, string string2)
        {
            return string1 + " " + string2;
        }
    }

    interface IExample // It is style recommendation to add capital I to interface name.
                       // Interfaces go inside class or struct that implements them
                       // Interaces need to be implemented by a class
    {
        void Example();
        int Example2();
        string Example3(string string1, string string2);
    }

    interface ISecondExample2
    {

    }

    // INotifyPropertyChanged is used to create a check in case a property changes
    class Program2 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
            }
        }
    }

    // IComparableInterface is used to define a type specific comparison method that
    // our class can implement to order or sort its instances
    class Program3 : IComparable
    {
        public int exampleLength; // Public int field exampleLength
        Program3 ex1 = new Program3() { exampleLength = 2 }; // A new program object with length 2

        //public static void Main(String[] args)
        //{

        //}

        public int CompareTo(object? obj)
        {
            Program3 ex2 = (Program3)obj;
            if (ex1.exampleLength == ex2.exampleLength)
            {
                return 0;
            }
            else if (ex1.exampleLength > ex2.exampleLength)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }

    class Employee
    {
        public int id;
    }

    class Program4 : IComparer
    {

        //public static void Main(String[] args)
        //{

        //}

        public int Compare(object? x, object? y)
        {
            Employee employee1 = (Employee)x;
            Employee employee2 = (Employee)y;
            return employee1.id.CompareTo(employee2.id);
        }
    }

    class Program5 : IEquatable<Program5>
    {
        public string exampleData;

        //public static void Main(String[] args)
        //{ 

        //}

        public bool Equals(Program5? other)
        {
            if (other == null)
            {
                return false;
            }

            // Returns an int for whether or not the program object passed in equals
            // the exampleData object from this class
            return exampleData.GetHashCode().Equals(other.exampleData.GetHashCode());
        }
    }

    public class Officer
    {
        Guid id;

        public Guid Id
        {
            get { return id; }
            set { id = value; }
        }
    }

    class Progam6 : IEqualityComparer<Officer> // Similar to IEquatable but instead of taking in one object and calling on another,
                                               // then checking if two are equal, this interface takes in two objects and checks if two are equal
    {

        //public static void Main(String[] args)
        //{

        //}

        public bool Equals([AllowNull] Officer? x, [AllowNull] Officer? y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Officer obj)
        {
            return obj.Id.GetHashCode();
        }
    }



    class Wallet : IEnumerable  // Reason to use IEnumerable is that we can use a foreach() loop
                                // to iterate over a custom collection that we create in order to keep the order of objects added
                                // Any foreach() loop implements the IEnumerable() interface under the hood
    {
        Money[] bills = null;
        int openIndex = 0; // Keeps track of the next open index in the array money[]

        public Wallet()
        {
            bills = new Money[100]; // bills = new money[] array with length 100. 100 money objects can fit into wallet
        }                           // We will use this constructor when we want to create a new wallet() object in our code

        public void Add(Money bill)
        {
            bills[openIndex] = bill; // Sets the next open Index in bills = a bill
            openIndex++; // Then increments to the next open index
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Money bill in bills)
            {
                if (bill == null)
                {
                    break;
                }

                yield return bill;
            }
        }
    }

    class Money
    {
        public int amount;
    }

    // class Program7  
    //{
    //    public static void Main(string[] args)
    //    {   
    //        Wallet wallet = new Wallet();
    //        wallet.Add(new Money() { amount = 1 });
    //        wallet.Add(new Money() { amount = 5 });
    //        wallet.Add(new Money() { amount = 10 });
    //        wallet.Add(new Money() { amount = 20 });
    //        wallet.Add(new Money() { amount = 50 });
    //        wallet.Add(new Money() { amount = 100 });
    //        wallet.Add(new Money() { amount = 200 });

    //        foreach (Money money in wallet)
    //        {
    //            System.Diagnostics.Debug.WriteLine("Bill: " + money.amount);
    //        }
    //    }
    //}

    // ICollections interface is implemented by all collections in Systems interface. Including IList and IDictionary
    // Using this interface we can create custom collections to use in programs
    class Program8 : ICollection
    {
        // Property for getting count of elements contained in collection (length of collection)
        public int Count => throw new NotImplementedException();

        // Property returns True is access to the collection is thread safe. False otherwise
        public bool IsSynchronized => throw new NotImplementedException();

        // Property get an object that will synchronize access to the collection
        public object SyncRoot => throw new NotImplementedException();

        // Method to copy elements of collection to an array starting at particular index
        // that we specify as 2nd param of this function
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        // Returns an enumerator that iterates over a collection
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }



    //class Program10
    //{
    //    public static void Main(string[] args)
    //    {
    //        BaseClass childclass = new ChildClass();
    //        childclass.PrintMessage();
    //    }
    //}

    class BaseClass
    {
        public virtual void PrintMessage() // Added virtual to the baseclass version of this method
        {
            Debug.WriteLine("Hello World!");
        }
    }

    class ChildClass : BaseClass
    {
        public override void PrintMessage() // Added override to the childclass version of this method
        {
            Debug.WriteLine("Goodbye World!");
            base.PrintMessage(); // Added new
        }
    }
}


// Abstract classes: is a class that must be implemented in any class that derives it

// We cannot instantiate an abstract class

// Used so that we can have a common definition of a base class that multiple other classes can subclass and share.

