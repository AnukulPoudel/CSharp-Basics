using System.Collections;

namespace Programming
{
    /// <summary>
    ///  contains HashTable, arrayList, Stack and Queue 
    /// </summary>
    class NonGenericClass
    {
        public static void ArrayList()
        {
            ArrayList arrayList = [2, 3, "4"];
            _ = arrayList.Add(2);
            _ = arrayList.Add(5);
            _ = arrayList.Add(3);
            // arrayList.

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("{0}", arrayList[i]);
            }
        }
        public static void Queue()
        {
            Queue queue = new Queue();
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(8);

            // Console.WriteLine("Removed the last object: {0}", );
            Console.WriteLine("Removed the last object: {0}", queue.Dequeue());

            // foreach(int i in queue){
                // Console.WriteLine("{0}");
            // }
        }
        public static void Stack()
        {
            Stack stack = new Stack();
            stack.Push(2);
            stack.Push("k");
            stack.Push(4);
            _ = stack.Peek();
        }
        public static void Dictionary()
        {
            // Hashtable hashtable = new Hashtable();
            Hashtable hashtable = new Hashtable(){
                {1,"hello"},
                {"hello","helloooww"},
            };
            // hashtable.Add(1,"hello");
            // hashtable.Add("helo","helooo");
            int i = hashtable.Count;
            Console.WriteLine("{0}", hashtable["helo"]);        
            Console.WriteLine("{0}", hashtable[1]);                       
        }
    }
}