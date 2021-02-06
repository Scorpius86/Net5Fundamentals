using System;

namespace Net5.Fundamentals.ControlStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt = "0";
            bool exit = false;
            ControlStructure controlStructure = new ControlStructure();

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Control Structures Menu");
                    Console.WriteLine("=======================");
                    Console.WriteLine("1  - If");
                    Console.WriteLine("2  - For");
                    Console.WriteLine("3  - While");
                    Console.WriteLine("4  - DoWhile");
                    Console.WriteLine("5  - Switch");
                    Console.WriteLine("6  - Break");
                    Console.WriteLine("7  - Continue");
                    Console.WriteLine("8  - GoTo");
                    Console.WriteLine("9  - Try Catch");
                    Console.WriteLine("10 - Try Catch Finally");
                    Console.WriteLine("99 - Exit");
                    Console.WriteLine("");
                    Console.Write("Selected option : ");
                    opt = Console.ReadLine();

                    Console.Clear();
                    switch (opt)
                    {
                        case "1":
                            controlStructure.IfStructure();
                            break;
                        case "2":
                            controlStructure.ForStructure();
                            break;
                        case "3":
                            controlStructure.WhileStructure();
                            break;
                        case "4":
                            controlStructure.DoWhileStructure();
                            break;
                        case "5":
                            controlStructure.SwitchStructure();
                            break;
                        case "6":
                            controlStructure.BreakCommand();
                            break;
                        case "7":
                            controlStructure.ContinueCommand();
                            break;
                        case "8":
                            controlStructure.GoToCommand();
                            break;
                        case "9":
                            controlStructure.TryCatchStructure();
                            break;
                        case "10":
                            controlStructure.TryCatchFinallyStructure();
                            break;
                        case "99":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Opción no valida");
                            break;
                    }

                    if (!exit)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine("Ups!!, encontramos un error");    
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                }

            } while (!exit);
        }
    }
}
