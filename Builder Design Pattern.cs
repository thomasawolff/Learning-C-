// 3 Types of design patterns:
// Creational: Used to create objects
// Structural: Used for relationships between objects
// Behavioral: Used to define how objects interact

// Creational design patterns:
// 2 main ideas with Creational Design Patterns: Encapsulation and hiding how instances of
// these classes are created and combined

// Strives to seperate a system for creating, composing, and representing objects 


// Builder pattern is used to design a complex object
// Goal of builder pattern is for different objects to be built by the same process

// Used when we want to avoid the telescopic constructor: with 10 params, for example
// Or when we want to create different representations of the same object

// Builder design process:
// 1. Define all steps
// 2. Build base-builder interface
// 3. Build a concrete builder class for each object representations and implement their construction steps
// 4. Build the builder and director objects then build the object

// Need 4 things in builder design pattern: Builder interface, concrete builder class, product class, director class

//

namespace computerBuilder
{
    public interface IComputerBuilder
    {
        void SetMonitor();
        void SetMouse();
        void SetKeyboard();
        void SetTower();
        void SetPrinter();

        Computer GetComputer();
    }

    public class Computer
    {
        public string Monitor { get; set; }
        public string Mouse { get; set; }
        public string Keyboard { get; set; }
        public string Tower { get; set; }
        public string Printer { get; set; }

    }

    // Public concrete class
    public class ComputerABuilder : IComputerBuilder
    {
        Computer computer = new Computer();

        public void SetMonitor()
        {
            computer.Monitor = "Single";
        }

        public void SetMouse()
        {
            computer.Mouse = "Regular";
        }

        public void SetKeyboard()
        {
            computer.Keyboard = "Standard";
        }

        public void SetTower()
        {
            computer.Tower = "16 GB RAM";
        }

        public void SetPrinter()
        {
            computer.Printer = "HP Laserjet 5000";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }

    public class ComputerBBuilder : IComputerBuilder
    {
        Computer computer = new Computer();

        public void SetMonitor()
        {
            computer.Monitor = "Dual";
        }

        public void SetMouse()
        {
            computer.Mouse = "Gaming";
        }

        public void SetKeyboard()
        {
            computer.Keyboard = "Standard";
        }

        public void SetTower()
        {
            computer.Tower = "64 GB RAM";
        }

        public void SetPrinter()
        {
            computer.Printer = "HP Laserjet 7000";
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }

    // Director class
    public class ComputerCreator
    {
        // Private IComputerBuilder named computerBuilder
        private IComputerBuilder computerBuilder;

        // Constructor that takes in one variable of type IComputer builder
        public ComputerCreator(IComputerBuilder computerBuilder)
        {
            // Member variable of class set to variable computerBuilder
            this.computerBuilder = computerBuilder;
        }

        public void CreateComputer()
        {
            computerBuilder.SetMonitor();
            computerBuilder.SetMouse();
            computerBuilder.SetKeyboard();
            computerBuilder.SetTower();
            computerBuilder.SetPrinter();
        }

        public Computer GetComputer()
        {
            return computerBuilder.GetComputer();
        }
    }

    //class MainClass
    //{
    //    public static void Main(string[] args)
    //    {
    //        ComputerCreator computerACreator = new ComputerCreator(new ComputerABuilder());
    //        computerACreator.CreateComputer();

    //        ComputerCreator computerBCreator = new ComputerCreator(new ComputerBBuilder());
    //        computerBCreator.CreateComputer();
    //    }
    //}
}