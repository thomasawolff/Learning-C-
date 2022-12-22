//using System;
//using System.Text;

//{
//    class Program2
//    {
//        public static void Main(String[] args)
//        {
//            Type sType = typeof(string);
//            System.Diagnostics.Debug.WriteLine(sType.FullName);

//        }
//    }
//}

//{
//    class Program3
//    {
//        public static void Main(String[] args)
//        {
//            int i = 0;
//            i = 5;
//            //System.Diagnostics.Debug.WriteLine(++i); // With prefix operator, ++i, the addition happened before the value was logged to the console
//            //System.Diagnostics.Debug.WriteLine(--i);
//            System.Diagnostics.Debug.WriteLine(3*2);
//        }
//    }

//}

//{
//    class ProgramMathClass
//    {
//        public static void Main(String[] args)
//        {
//            System.Diagnostics.Debug.WriteLine(Math.Abs(-3.5f));
//            System.Diagnostics.Debug.WriteLine(Math.Round(3.7f));
//            System.Diagnostics.Debug.WriteLine(Math.Ceiling(3.1f));
//            System.Diagnostics.Debug.WriteLine(Math.Floor(3.9f));

//        }
//    }


//}

//{
//    public static class FehrenheitToCelsius
//    {
//        public static int MathChallenge(int Fehrenheit)
//        {
//            return (Fehrenheit - 32 * (5/9));
//        }
//    }
//}

//{
//    class Program
//    {
//        public static void Main()
//        {
//            int price = 100;
//            int price1 = 50;
//            int price2 = 150;
//            int price3 = 200;
//            float percent = 0.8f;
//            string name = "Thomas";
//            string example = "abc";
//            System.Diagnostics.Debug.WriteLine($"Hi my name is {name}.");
//            System.Diagnostics.Debug.WriteLine(example.Contains("bc"));
//            System.Diagnostics.Debug.WriteLine(example.Substring(1));
//            System.Diagnostics.Debug.WriteLine("Thelma said \"Go write some code\"");
//            System.Diagnostics.Debug.WriteLine("Hello \t World!");
//            System.Diagnostics.Debug.WriteLine(String.Format("The item costs {0:C}", price));
//            System.Diagnostics.Debug.WriteLine(String.Format("The price of item 1 is {0:C}, the price of item 2 is {1:C} , the price of item 3 is {2:C}", price1, price2, price3));
//            System.Diagnostics.Debug.WriteLine(String.Format("This percent of all people are not that smart: {0:P}", percent));
//        }
//    }

//}

namespace ExampleProj2

//{
//    class Program
//    {
//        public static void Main(String[] args)
//        {
//            StringBuilder stringbuilder = new StringBuilder();
//            stringbuilder.AppendLine("Hello World!");
//            stringbuilder.AppendLine("Hello World!");
//            stringbuilder.Append("Hello World!");
//            for(int i = 0; i < 4; i++)
//            {
//                stringbuilder.Append(" nice to see you");
//            }
//            string s = stringbuilder.ToString();
//            System.Diagnostics.Debug.WriteLine(s);
//        }
//    }
//}

//{
//    class Program
//    {
//        public static void Main(String[] args)
//        {
//            StringBuilder sb = new StringBuilder("Hello World");
//            StringBuilder sb2 = new StringBuilder("This is a string with some spaces");
//            sb2.Replace(" ", "_");
//            sb.Remove(6, 5);
//            System.Diagnostics.Debug.WriteLine(sb.ToString());
//            System.Diagnostics.Debug.WriteLine(sb2.ToString());
//        }
//    }
//}

//{
//    class Program
//    {
//        public static void Main(String[] args)
//        {
//            string s = "abc";
//            string a = string.Empty;
//            System.Diagnostics.Debug.WriteLine(s.IndexOf("b"));
//            System.Diagnostics.Debug.WriteLine(s.ToUpper());
//            System.Diagnostics.Debug.WriteLine(s.ToLower());
//            a = s.Insert(3, "d");
//            System.Diagnostics.Debug.WriteLine(a);
//            a = s.Remove(3);
//            System.Diagnostics.Debug.WriteLine(a);
//            a = a.Trim('a');
//            a = a.Replace("bc","cd");
//            System.Diagnostics.Debug.WriteLine(a);
//        }
//    }
//}

//{
//    class Program
//    {
//        public static void Main(String[] args)
//        {
//            string s = null;
//            System.Diagnostics.Debug.WriteLine(string.IsNullOrEmpty(s));
//        }
//    }
//}

//{
//    class Program
//    {
//        public static void Main(String[] args)
//        {
//            bool example = true;
//            example &= false;

//            bool completed = false;

//            System.Diagnostics.Debug.WriteLine(!completed); // Bool check will return True is completed is false and false if completed is true
//            System.Diagnostics.Debug.WriteLine(true && true); // short circuting operators
//            System.Diagnostics.Debug.WriteLine(false && true);
//            System.Diagnostics.Debug.WriteLine(example);
//        }
//    }
//}


//{
//    class Program
//    {
//        public static void Main(String[] args)
//        {
//            bool flag = false;
//            List<int> intList = new List<int>() { 1, 2, 3 };
//            foreach (int i in intList)
//            {
//                if (i == 3)
//                {
//                    flag = true;
//                }
//            }

//            if(flag)
//            {
//                System.Diagnostics.Debug.WriteLine("3 was found!");
//            }
//        }
//    }
//}


{
    class Program
    {
        //public static void Main(String[] args)
        //{
        //    int i = 200;
        //    System.Diagnostics.Debug.WriteLine(i);
        //    ChangeValue(i);
        //    System.Diagnostics.Debug.WriteLine(i); // i kept its value of 200 even after the changevalue() function was called on that variable
        //                                           // This is because it is a value type and a copy of it was made by the computer to preserve its value

        //    Person p = new Person();
        //    p.Name = "Old Person";
        //    ChangeReferenceType(p);
        //    System.Diagnostics.Debug.WriteLine(p.Name); // in the memory address can be changed by methods
        //}

        static void ChangeValue(int num)
        {
            num = 500;
            System.Diagnostics.Debug.WriteLine(num);
        }

        public class Person
        {
            public string Name;
        }

        static void ChangeReferenceType(Person person)
        {
            person.Name = "New Name";
        }

    }
}