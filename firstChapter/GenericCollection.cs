using System.Collections.Generic;
namespace Programming{
    class GenericCollectionsClass{
        public static void Queue(){
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(2);
            queue.Enqueue(5);
            queue.Enqueue(3);
            queue.Enqueue(7);
            queue.Dequeue();
            queue.Peek();
        }
        public static void Stack(){
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Pop();
            stack.Peek();
        }
        public static void Dictionary(){
            Dictionary<int, string> dictionary = new Dictionary<int, string>() {
                {2,"Whatttt!!"}
            };
            dictionary.Add(1,"Hello");
            dictionary.Remove(1);
            dictionary.Clear();

        }

    }
}