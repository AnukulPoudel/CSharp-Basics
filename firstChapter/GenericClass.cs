using System.Collections.Generic;
namespace Programming{
    class GenericClass<T>{
        static T[] member = new T[4];
        public static void AddItems(int index, T item){
            if (index>=4)
            {
                member[index] = item;
            }
        }
        public static void Display(){
            foreach (var item in member)
            {
                Console.WriteLine("{0}", item);
            }
        }
    }
}