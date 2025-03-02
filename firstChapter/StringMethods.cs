namespace Programming{
    class StringMethods{
        string str  = "Hello, exam is near";
        public void ToUpperMethod(){
            Console.WriteLine(str.ToUpper());
        }
        public void ToLowerMethod(){
            Console.WriteLine(str.ToLower());

        }
        public void SubstringMethod(){
            Console.WriteLine(str.Substring(4));
        }
        public void TrimMethod(){
            Console.WriteLine(str.Trim());
        }
    }
}