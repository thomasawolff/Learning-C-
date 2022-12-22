// 3 Types of design patterns:
// Creational: Used to create objects
// Structural: Used for relationships between objects
// Behavioral: Used to define how objects interact

// Creational design patterns:
// 2 main ideas with Creational Design Patterns: Encapsulation and hiding how instances of
// these classes are created and combined

// Strives to seperate a system for creating, composing, and representing objects 



// Abstract Factory design pattern:

// Creates a super factory that creates other factories

// Use this pattern when our code needs to work with various families of related objects
// but dont want it to depend on concrete objects of those classes

// To implement the Abstract Factory design:

// 1. Map out the objects and variance of objects
// 2. Declare abstract object interfaces for all object types
// 3. Make concrete object classes  and implement those interfaces
// 4. Declare the abstract factory interfaces with set of creation methods for all abstract objects
// 5. Implement set of concrete classes one for each object varient
// 6. Write factory initialization code
// Anywhere we call the factory constructors, call the appropriate creation factory instead


// 5 things to create for abstract factory: abstract factory, concrete factory, abstract products, concrete products, and client

namespace Dp1
{
    interface Imobile // abstract factory: the interface used to create an abstract product
    {
        // Two methods
        IAndroid GetAndroidPhone();
        IiOS GetiOSPhone();

    }

    // Concrete factory: a class that implements the abstract factory interface operations in order to create concrete products
    class Samsung : Imobile
    {
        public IAndroid GetAndroidPhone()
        {
            return new SamsungGalaxy();
        }

        public IiOS GetiOSPhone()
        {
            return new SamsungGuru();
        }

    }

    // Abstract products: interfaces for a type of product object
    interface IAndroid
    {
        string GetModelDetails();
    }

    interface IiOS
    {
        string GetModelDetails();
    }

    // Concrete products: an object that will implement one of the abstract product interfaces
    class SamsungGalaxy : IAndroid
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Galaxy - RAM: 2GB - Camera: 13MP";
        }
    }

    class SamsungGuru : IiOS
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru - RAM: N/A - Camera: N/A";
        }
    }
    // Client: uses the abstract factory and abstract product interfaces to create a family of related objects

    class MobileClient
    {
        // Two member variables
        IAndroid androidPhone;
        IiOS iOSPhone;

        // Constructor
        public MobileClient(Imobile factory)
        {
            androidPhone = factory.GetAndroidPhone();
            iOSPhone = factory.GetiOSPhone();
        }

        // Public string method to return phone details
        public string GetAndroidPhoneDetails()
        {
            return androidPhone.GetModelDetails();
        }

        public string GetiOSPhoneDetails()
        {
            return iOSPhone.GetModelDetails();
        }
    }


    //class Example1
    //{
    //    public static void Main(string[] args)
    //    {
    //        Imobile MobilePhone = new Samsung();
    //        MobileClient phoneClient = new MobileClient(MobilePhone);

    //        Debug.WriteLine(phoneClient.GetAndroidPhoneDetails());
    //        Debug.WriteLine(phoneClient.GetiOSPhoneDetails());
    //    }
    //}
}

// Objects created with a factory are compatible with eachother. It avoids tight coupling
// Code using this patter follows a pattern where each class does one thing and does it well
// Using this pattern we can create new varients of products without breaking existing code
// On the downside, code may become more complicated with many new interfaces and classes.