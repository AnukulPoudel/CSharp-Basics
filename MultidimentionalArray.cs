namespace Programming{
    class JaggedArray{
        int[][] jaggedArray = new int[3][];
        
        public void Display(){
            jaggedArray[0] = new int[] {1,2};
            jaggedArray[1] = new int[] {3,4,5};
            jaggedArray[2] = new int[] {6,7,8,9};
            for(int i=0;i<jaggedArray.Length;i++){
                for(int j=0;j<jaggedArray[i].Length;j++){
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine("");
            }
        } 
    }
    class RectangularArray{
        int[,] rectangularArray = {
            {1,2},
            {2,3},
            {3,4}
        };
        public void Display(){
            foreach(int numbers in rectangularArray){
                Console.WriteLine(numbers);
            }
        } 
    }
}