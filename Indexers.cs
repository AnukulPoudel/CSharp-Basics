namespace Programming
{
    class Indexer{
        public string[] name = new string[10];
        public string this[int i]{
            get{
                if (i==0)
                {
                    return name[i];
                }
                else
                {
                    throw new Exception("Index out of range!");
                }
            }
        }
    }
}