namespace Programming{
        class Loops{
        int[] intArray = new int[5] {9,8,1,5,9};


        public void forEachMethod(){
            intArray[0] = 9;
            intArray[1] = 9;
            intArray[2] = 9;
            intArray[3] = 9;
            intArray[4] = 9;
            foreach(int number in intArray){
                Console.WriteLine(number);
            }
        }
        public void forMethod(){
            for(int i=0;i<intArray.Length;i++){
                Console.WriteLine(intArray[i]);
            }
        }
    }
}