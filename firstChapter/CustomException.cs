namespace Programming
{
    class ProgramResult
    {
        public void Result(int i)
        {
            try
            {
                CheckNumber(i);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught exception: " + ex.Message);
            }
        }

        static void CheckNumber(int number)
        {
            if (number > 5)
            {
                throw new Exception("Number is greater than 5");
            }
        }
    }

}