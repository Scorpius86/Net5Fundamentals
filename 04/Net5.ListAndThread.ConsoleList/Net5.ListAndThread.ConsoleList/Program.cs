using System;

namespace Net5.ListAndThread.ConsoleList
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt;
            bool exit = false;
            ListAndThread listAndThread = new ListAndThread();

            do
            {
                Console.Clear();
                Console.WriteLine("List And Thread");
                Console.WriteLine("===============");
                Console.WriteLine("1  - Array");
                Console.WriteLine("2  - List");
                Console.WriteLine("3  - Dinctionary");
                Console.WriteLine("4  - SortedList");
                Console.WriteLine("5  - SortedList");
                Console.WriteLine("6  - Stack");
                Console.WriteLine("7  - Queue");
                Console.WriteLine("8  - Tuple");
                Console.WriteLine("9  - ValueTuple");
                Console.WriteLine("10 - Thread");
                Console.WriteLine("11 - Task");
                Console.WriteLine("12 - StreamReader");
                Console.WriteLine("13 - StreamWriter");
                Console.WriteLine("99 - Exit");
                Console.Write("Seleccione una opcion : ");
                opt = Console.ReadLine();
                Console.Clear();

                switch (opt)
                {
                    case "1":
                        listAndThread.ArraySample();
                        break;
                    case "2":
                        listAndThread.ListSample();
                        break;
                    case "3":
                        listAndThread.DictionarySample();
                        break;
                    case "4":
                        listAndThread.SortedListSample();
                        break;
                    case "5":
                        listAndThread.HashTableSample();
                        break;
                    case "6":
                        listAndThread.StackSample();
                        break;
                    case "7":
                        listAndThread.QueueSample();
                        break;
                    case "8":
                        listAndThread.TupleSample();
                        break;
                    case "9":
                        listAndThread.ValueTupleSample();
                        break;
                    case "10":
                        listAndThread.ThreadSample();
                        break;
                    case "11":
                        listAndThread.TaskSample();
                        break;
                    case "12":
                        listAndThread.StreamReaderSample();
                        break;
                    case "13":
                        listAndThread.StreamWriterSample();
                        break;
                    case "99":
                        exit = true;
                        break;
                    default:
                        break;
                }
                if (!exit)
                {
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }
            } while (!exit);
        }
    }
}
