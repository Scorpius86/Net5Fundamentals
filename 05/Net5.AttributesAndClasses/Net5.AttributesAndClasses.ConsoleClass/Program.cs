using System;

namespace Net5.AttributesAndClasses.ConsoleClass
{
    class Program
    {
        public delegate void MyDelegate(int i);

        static void Main(string[] args)
        {
            ProcessPearson processPearson = new ProcessPearson();
            
            IPerson person = new Person() { Name = "Erick"};
            person.Run();

            StaticPerson.Run();

            processPearson.ProcessNameWithoutReference(person);

            Console.WriteLine(person.Name);

            RunDelegate(new MyDelegate(processPearson.MyMethodOne),2);
            RunDelegate(new MyDelegate(processPearson.MyMethodTwo), 33);

            person = new Humman();
            person.Run();
        }

        static public void RunDelegate(MyDelegate myDelegate,int i)
        {
            myDelegate(i);
        }
    }
}
