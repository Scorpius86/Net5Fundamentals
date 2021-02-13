using Net5.AttributesAndClasses.LibraryClasses;

namespace Net5.AttributesAndClasses.ConsoleClass
{
    public interface IPerson
    {
        Address Address { get; set; }
        string Name { get; set; }

        void Run();
        void Run(int i);
        void Run(string s);
    }
}