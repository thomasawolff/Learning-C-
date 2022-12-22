// 3 Types of design patterns:
// Creational: Used to create objects
// Structural: Used for relationships between objects
// Behavioral: Used to define how objects interact

// Creational design patterns:
// 2 main ideas with Creational Design Patterns: Encapsulation and hiding how instances of
// these classes are created and combined

// Strives to seperate a system for creating, composing, and representing objects 

// used to create an interface for creating an object

// Lets subclasses decide which class to instantiate

// Factory method: promotes loose coupling

// Used when we dont know the exact types and dependencies of the objects your code works with
// and when you want to give users of its libraries and components the ability to extend its internal components
// or save system resources by reusing existing objects instead of rebuilding them each time

namespace FactoryMethod
{
    class Factory1
    {
        abstract class PlayingCard
        {
            public abstract string Type { get; set; }
            public abstract int Value { get; set; }
            public abstract string Suit { get; set; }
        }

        class HoylePlayingCard : PlayingCard
        {
            private string type;
            private int value;
            private string suit;

            public HoylePlayingCard(int value, string suit)
            {
                type = "Hoyle";
                this.value = value;
                this.suit = suit;
            }

            public override string Type
            {
                get { return type; }
                set { type = value; }
            }

            public override int Value
            {
                get { return value; }
                set { this.value = value; }
            }

            public override string Suit
            {
                get { return suit; }
                set { this.suit = value; }
            }
        }

        class CongressPlayingCard : PlayingCard
        {
            private string type;
            private int value;
            private string suit;

            public CongressPlayingCard(int value, string suit)
            {
                type = "Congress";
                this.value = value;
                this.suit = suit;
            }

            public override string Type
            {
                get { return type; }
                set { type = value; }
            }

            public override int Value
            {
                get { return value; }
                set { this.value = value; }
            }

            public override string Suit
            {
                get { return suit; }
                set { this.suit = value; }
            }
        }

        // Abstract factory class will be implemented for Hoyle and Congress
        abstract class CardFactory
        {
            public abstract PlayingCard GetPlayingCard();
        }

        class HoyleFactory : CardFactory
        {
            //private string type;
            private int value;
            private string suit;

            public HoyleFactory(int value, string suit)
            {
                this.value = value;
                this.suit = suit;
            }

            public override PlayingCard GetPlayingCard()
            {
                return new HoylePlayingCard(value, suit);
            }
        }

        class CongressFactory : CardFactory
        {
            //private string type;
            private int value;
            private string suit;

            public CongressFactory(int value, string suit)
            {
                this.value = value;
                this.suit = suit;
            }

            public override PlayingCard GetPlayingCard()
            {
                return new CongressPlayingCard(value, suit);
            }
        }

        public static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.WriteLine("Enter the card type you would like to create: ");
            string card = Console.ReadLine();

            switch (card.ToLower())
            {
                case "hoyle":
                    factory = new HoyleFactory(5, "spades");
                    break;
                case "congress":
                    factory = new CongressFactory(10, "hearts");
                    break;
                default:
                    break;
            }

            PlayingCard playingCard = factory.GetPlayingCard();
            Console.WriteLine("Card Type: {0} \n Card Value: {1} \n Suit: {2}", playingCard.Type, playingCard.Value, playingCard.Suit);
            Console.ReadKey();
        }
    }
}