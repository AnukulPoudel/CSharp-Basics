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
                if (i==1)
                {
                    return name[i];
                }
                else
                {
                    throw new Exception("Index out of range!");
                }
            }
            set{
                if(i==0){
                    name[i] = value;
                }
                if(i==1){
                    name[i] = value;
                }
                else{
                    throw new Exception("Index out of rance!");
                }
            }
        }
    }
}