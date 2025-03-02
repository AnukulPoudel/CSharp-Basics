using System;
namespace Programming{
    class ForEach{
    string[] stringArray = new string[3] {"Ram","Shyam","Hari"};
    public void forEachMethod(){
        foreach(string name in stringArray){
            Console.WriteLine(name);
        }
    }
}
}