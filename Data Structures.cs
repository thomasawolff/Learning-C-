 //Two kinds of collections in C#: Linear and Non-linear
 //Linear: Values stored as a sequence
 //Non-linear: values not stored as a sequence

namespace DataStructures

{
    class Arrays
    {
        static string[] array1 = new string[] { "c", "a", "b" };  //Do it this way since this has the declaration and assignment of array
        static int[] array2 = new int[3] { 3, 1, 2 };

        // public static void Main(string[] args)
        // {
        //     Array.Sort(array1);
        //     foreach(string s in array1)
        //     {
        //         Debug.WriteLine(s);
        //     }

        //     array2[0] = 5;
        //     Array.Sort(array2);
        //     Debug.WriteLine(array2.Length);
        //     foreach(int i in array2)
        //     {
        //         Debug.WriteLine(i);
        //     }
        // }
    }


     Lists automatically resize as the list grows
     Lives in the systems.Collections.Generic namespace
    class Lists
    {
        static List<int> numbers = new List<int>() { 1, 3, 5, 4, 2 };
        // public static void Main(string[] args)
        // {
        //     numbers.Capacity = 10;  Setting the capacity of list numbers
        //     numbers.Add(6);  Adding the number 6 to the list
        //     System.Diagnostics.Debug.WriteLine(numbers.Count);
        //     List<int> subList = new List<int>() { 7,8};
        //     numbers.AddRange(subList);
        //     numbers.Sort();  Sorting elements for binary search
        //     System.Diagnostics.Debug.WriteLine("Index of element 5 is: " + numbers.BinarySearch(5));  //Implementing binary search on sorted list

        //     numbers.Insert(0, 9);  //Inserting 9 into index position 0 in list
        //     List<int> subList2 = new List<int>() { 10, 12 };
        //     numbers.InsertRange(1, subList2);  //Adding elements from subList2 into index 1
        //     numbers.Remove(8);  //Removing a value: If value occurs more than once, this will only remove first occurance
        //     numbers.RemoveAt(9);  //Removing a value from list by index position
        //     numbers.RemoveRange(0, 2);  //Removing a range of values
        //     numbers.Sort();

        //     foreach (int i in numbers)
        //     {
        //         System.Diagnostics.Debug.WriteLine(i);
        //     }

        //     bool areNumbersLessThan6 = numbers.TrueForAll(x => x < 6);
        //     Debug.WriteLine(areNumbersLessThan6);
        //     Debug.WriteLine(numbers.IndexOf(12));  //Printing the index of value 12 in list
        // }
    }

    public class Stacks
     //Stacks operate on the principal of LIFO: Last In First Out
     //Operations on a stack: Push(), Pop(), Peek(), Clear()
    {
        // public static void Main(string[] args)
        // {
        //      Initializing a new stack
        //     Stack<string> s = new Stack<string>();
        //     s.Push("a");  Pushing the letter "a" to the stack
        //     s.Push("b");
        //     Debug.WriteLine("The stack contains " + s.Count + " elements");
        // }

        // public static void Main(string[] args)
        // {
        //     Debug.WriteLine(IsBalanced("{{[]}}").ToString());
        //     Debug.WriteLine(IsBalanced("((]").ToString());
        // }

        private static bool IsBalanced(string inputString)
        {
            Stack<char> stackOfClosingBraces = new Stack<char>();
            Stack<char> stackOfOpeningBraces = new Stack<char>();

            foreach (char c in inputString)
            {
                if (c == '}' || c == ']' || c == ')')  //Pushing closing braces to the stack of closing braces
                {
                    stackOfClosingBraces.Push(c);
                }
            }

            for (int i = inputString.Length - 1; i >= 0; i--)  //Going backwards through inputString for opening braces
            {
                if (inputString[i] == '{' || inputString[i] == '[' || inputString[i] == '(')
                {
                    stackOfOpeningBraces.Push(inputString[i]);  //Pushing opening braces into stack for opening braces
                }
            }
             //The number of opening brackets should equal the number of closing brackets
            if ((stackOfClosingBraces.Count + stackOfOpeningBraces.Count) % 2 != 0)
            {
                return false;
            }

            while (stackOfClosingBraces.Count != 0)
            {
                 //Pop returns the last char in the stack and removes that char
                char currentClosingBrace = stackOfClosingBraces.Pop();
                char currentOpeningBrace = stackOfOpeningBraces.Pop();

                if ((currentClosingBrace == '}' && currentOpeningBrace == '{') ||
                    (currentClosingBrace == ']' && currentOpeningBrace == '[') ||
                    (currentClosingBrace == ')' && currentOpeningBrace == '('))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }

    public class Stack

     //Best use for a stack is when we want to access data in the reverse order

    {
        // public static void Main(string[] args)
        // {
        //     Stack stack = new Stack();

        //     stack.Push(1);
        //     stack.Push(2);
        //     stack.Push(3);
        //     stack.Push(4);

        //     Debug.WriteLine(stack.Pop());
        //     Debug.WriteLine(stack.Pop());
        //     Debug.WriteLine(stack.Pop());
        //     Debug.WriteLine(stack.Pop());
        // }

        const int MAX = 1000;
        int top;
        object[] stack = new object[MAX];

        public Stack()
        {
            top = -1;
        }

        public void Push(object obj)  Push function
        {
            if (top < MAX)  //To ensure that the stack has capacity to hold an object
            {
                stack[++top] = obj;  //Setting stack equal to top incremented by 1 to object
            }
        }

        public object Pop()  Pop function
        {
            if (top >= 0)  //Check if stack is not empty
            {
                object o = stack[top];
                top--;
                return o;
            }
            else
            {
                return -1;
            }
        }

        public object Peek()
        {
            return stack[top];
        }
    }

     //Queues operate on FIFO: First In First Out
     //Objects in a Queue are inserted in one end and removed on the other end

    public class Queue
    {
        // public static void Main(string[] args)
        // {
        //     Queue<string> queue = new Queue<string>();
        //      //Enqueue operation adds object to end of the queue
        //     queue.Enqueue("a");
        //     queue.Enqueue("b");
        //     queue.Enqueue("c");

        //      Dequeue operation removes oldest object from start of queue
        //     Debug.WriteLine(queue.Dequeue());
        //     Debug.WriteLine(queue.Peek());

        //      //Best use for a queue is when we need to access the data in the same order it is stored in the collection
        // }
    }

    public class Dictionary
    {
        // public static void Main(string[] args)
        // {
        //     Dictionary<string, string> dictionary = new Dictionary<string, string>();
        //     dictionary.Add("key1", "value1");
        //     dictionary.Add("key2", "value2");
        //     dictionary.Add("key3", "value3");
        //     dictionary.Add("key4", "value4");

        //     dictionary.Remove("key4");

        //     if(!dictionary.ContainsKey("key5"))  //Checking to make sure this key is not already in dictionary
        //     {
        //         dictionary.Add("key5", "value5");
        //     }

        //     if(dictionary.ContainsKey("key5"))  //Checking to make sure the key exists so that we can see actual value
        //     {
        //         Debug.WriteLine(dictionary["key5"]);
        //     }

        //      //A better way to get the value if it exists is to use the TryGetValue method
        //     string value1 = "";
        //     dictionary.TryGetValue("key2",out value1);

        //     Debug.WriteLine(dictionary.Count());
        //     foreach (string value in dictionary.Values)
        //     {
        //         Debug.WriteLine(value);
        //     }

        // }
    }

    public class HashSets
    {
        // public static void Main(string[] args)
        // {
        //     HashSet<string> letter1 = new HashSet<string> { "a", "b", "c" };
        //     HashSet<string> letter2 = new HashSet<string> { "d", "e", "f", "a", "b" };

        //     letter1.UnionWith(letter2);
        //     foreach (string s in letter1)
        //     {
        //         Debug.WriteLine(s);
        //     }

        //     letter1.IntersectWith(letter2);
        //     foreach (string s in letter1)
        //     {
        //         Debug.WriteLine(s);
        //     }

        //     letter1.ExceptWith(letter2);
        //     foreach (string s in letter1)
        //     {
        //         Debug.WriteLine(s);
        //     }

        //     letter1.SymmetricExceptWith(letter2);
        //     foreach (string s in letter1)
        //     {
        //         Debug.WriteLine(s);
        //     }
        // }
    }

    public class SortedLists_
    {
         //Sorted lists combine features of both lists and dictionarys
         //Collection of key value pairs sorted by keys
         //Implement both the iDictionary and iCollection interfaces
         //If access the elements by index, takes on functionality of array list
         //If access the elements by key, takes on functionality of dictionary
         //Sorted list is faster than sorted dictionary if list is populated all at once with sorted data
         //Sorted list uses less memory that sorted dictionary

        static SortedList<string, int> sortedList = new SortedList<string, int>() { { "key1", 1 }, { "key2", 2 }, { "key3", 3 } };
        // public static void Main(string[] args)
        // {
        //     sortedList.Add("key4", 4);

        //     sortedList.Capacity = 6;
        //     System.Diagnostics.Debug.WriteLine("The sorted list's capacity is: " + sortedList.Capacity);
        //     System.Diagnostics.Debug.WriteLine("The sorted list's count is: " + sortedList.Count());

        //     System.Diagnostics.Debug.WriteLine("Index of key1: " + sortedList.IndexOfKey("key1"));  //Getting the index of keys 1,2,3
        //     System.Diagnostics.Debug.WriteLine("Index of key2: " + sortedList.IndexOfKey("key2"));
        //     System.Diagnostics.Debug.WriteLine("Index of key3: " + sortedList.IndexOfKey("key3"));

        //     System.Diagnostics.Debug.WriteLine("Index of value 1: " + sortedList.IndexOfValue(1));  //Getting the index of values 1,2,3
        //     System.Diagnostics.Debug.WriteLine("Index of value 2: " + sortedList.IndexOfValue(2));
        //     System.Diagnostics.Debug.WriteLine("Index of value 3: " + sortedList.IndexOfValue(3));

        //     foreach (string key in sortedList.Keys)
        //     {
        //         System.Diagnostics.Debug.WriteLine(key);
        //     }

        //     foreach (int value in sortedList.Values)
        //     {
        //         System.Diagnostics.Debug.WriteLine(value);
        //     }
        // }
    }

    public class SortedDictionary_
    {
         //Very similar to sorted list but has faster insertion and removal for unsorted data
        static SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>()
        {
            { "key1","value1" },
            { "key2","value2" },
            { "key3","value3" }
        };

        // public static void Main(string[] args)
        // {
        //     sortedDictionary.Add("key4", "value4");
        // }

    }

    public class SortedSets_
    {
        static SortedSet<int> sortedSet = new SortedSet<int>();

        // public static void Main(string[] args)
        // {
        //     sortedSet.Add(3);
        //     sortedSet.Add(1);
        //     sortedSet.Add(6);
        //     sortedSet.Add(9);
        //     sortedSet.Add(2);

        //     sortedSet.Remove(3);
        //     sortedSet.RemoveWhere(x => x > 6);

        //     foreach (int i in sortedSet) .Reverse())  //Reversing order of set
        //     {
        //         System.Diagnostics.Debug.WriteLine(i);
        //     }

        //     if (sortedSet.IsSubsetOf(new List<int>() { 1, 2, 3 }));

        //     List<int > list = new List<int>() {6,7,8};
        //     sortedSet.UnionWith(list);  //Also does the set operations of sorted lists
        //     foreach(int i in sortedSet)
        //     {
        //         System.Diagnostics.Debug.WriteLine(i);
        //     }
        // }
    }

    public class SingularLinkedList
     //Sequence of data structures connected by links
     //Each data structure contains a connection to another
     
    {
        public class Node
        {
            public Node next;
            public object data;
        }

        private Node root;

        public Node First { get { return root; } }  //Enable us to obtain the first node in the list

        public Node Last  //Enable us to obtain the last node in the list
        {
            get
            {
                Node currentNode = root;
                if (currentNode == null)
                {
                    return null;
                }

                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                return currentNode;
            }
        }

        public void Append(object value)
        {
            Node node = new Node { data = value };
            if (root == null)
            {
                root = node;
            }
            else
            {
                Last.next = node;
            }
        }

        public void Delete(Node node)
        {
            if (root == node)
            {
                root = node.next;
                node.next = null;
            }
            else
            {
                Node current = root;
                while (current.next != null)
                {
                    if (current.next == node)
                    {
                        current.next = node.next;
                        node.next = null;
                        break;
                    }
                    current = current.next;
                }
            }
        }
    }

    class doubleLinkedList
    {
        static LinkedList<string> linkedList = new LinkedList<string>();  //A static list so that it can be referenced by main method

        // public static void Main(string[] args)
        // {
        //     linkedList.AddFirst("root");  //Add a new node or value at start of linked list
        //     linkedList.AddAfter(linkedList.First, "element");  //Add a new node or value after an existing node
        //     linkedList.AddBefore(linkedList.First, "new root");  //Add a new node or value before an existing node
        //     linkedList.AddLast("last element");  //Add a new node or value at end of linked list

        //     System.Diagnostics.Debug.WriteLine(linkedList.Count());
        //     LinkedListNode<string> nodeFirst = linkedList.Find("root");  //Find the first node that contains specified value
        //     LinkedListNode<string> nodeLast = linkedList.FindLast("last element");  //Find last node that contains specified value

        //      To remove nodes from linked list
        //     linkedList.Remove("root");  //Remove the first occurence of a specified value from linked list
        //     linkedList.RemoveFirst();  //Remove the root node from a linked list
        //     linkedList.RemoveLast();  //Remove the last node from a linked list
        // }
    }

    class Trees_
    {
         //Main rules of trees that all trees must follow
         //Starting from any node, any other node in the tree can be reached
         //There are no cycles
         //The number of edges is one less than the number of nodes


    }
}

