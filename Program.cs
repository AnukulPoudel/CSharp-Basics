namespace Programming
{

    class DefaultConstructor
    {
        public DefaultConstructor()
        {
            Console.WriteLine("Default Constructor is executed!!");
        }

        ~DefaultConstructor()
        {
            Console.WriteLine("This is message from Destructor.");
        }
    }

    class StaticClass
    {
        static int i;
        static StaticClass()
        {
            Console.WriteLine("Static Constructor Called!!");
            i = 2;
        }

        public StaticClass()
        {
            Console.WriteLine("Default Constructor for Static Class Called!!");
        }
        public void Display()
        {
            Console.WriteLine(i);
        }
    }

    class CopyConstructor
    {
        readonly int i;
        public CopyConstructor(CopyConstructor obj)
        {
            i = obj.i;
        }
        public CopyConstructor(int no)
        {
            i = no;
        }
        public void Display()
        {
            Console.WriteLine("The number of Copy Constructor is : " + i);
        }
    }

    class ParamitizedConstructor
    {
        int no;
        public ParamitizedConstructor(int i)
        {
            no = i;
            Console.WriteLine("The number of ParamitizedConstructr is: " + no);
        }
    }

    class Program
    {
        // int i = 2;
        public async static Task Main()
        {
            // DefaultConstructor obj = new DefaultConstructor();
            // Console.WriteLine(i);
            // ParamitizedConstructor obj6 = new ParamitizedConstructor(5);
            // StaticClass obj2 = new StaticClass();
            // StaticClass obj3 = new StaticClass();
            // obj2.Display();
            // obj3.Display();
            //     CopyConstructor obj4 = new CopyConstructor(3);
            //     obj4.Display();
            //     CopyConstructor obj5 = new CopyConstructor(obj4);
            //     obj5.Display();

            // ForEach obj7 = new ForEach();
            // obj7.forEachMethod();
            // Loops obj8 = new Loops();
            // // obj8.forEachMethod();
            // obj8.forMethod();
            // RectangularArray obj9 = new RectangularArray();
            // obj9.Display();
            // JaggedArray obj0 = new JaggedArray();
            // obj0.Display();
            // ProgramResult rj = new ProgramResult();
            // rj.Result(8);
            // StringMethods strMethodsObj = new StringMethods();
            // strMethodsObj.SubstringMethod();
            // strMethodsObj.ToLowerMethod();
            // strMethodsObj.ToUpperMethod();
            // strMethodsObj.TrimMethod();
            // Indexer indexer = new Indexer();
            // indexer.name[0] = "Hello ";
            // indexer.name[1] = "Hi";
            // Console.Write(indexer[0]);
            // Console.WriteLine(indexer[1]);
            // B b = new B();
            // b.display();
            // Calculate clc = new Calculate();
            // clc.l = 2;
            // clc.b = 3;
            // int area = clc.CalculateArea();
            // int perimeter = clc.CalculatePerimeter();
            // Console.WriteLine("Area is "+area);
            // Console.WriteLine("Perimeter is "+perimeter);
            // AsyncAwait aa = new AsyncAwait();
            int sum = await AsyncAwait.Sum(5,8);
            Console.WriteLine("The sum is: {0}",sum);

        }

    }
}