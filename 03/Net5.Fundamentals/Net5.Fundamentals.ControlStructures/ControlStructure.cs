using System;
using System.Collections.Generic;
using System.Text;

namespace Net5.Fundamentals.ControlStructures
{
    public class ControlStructure
    {
        public void IfStructure()
        {
            int price = 0;            
            Console.WriteLine("If - Structure");
            Console.WriteLine("============");
            Console.Write("Ingrese precio : ");
            price = int.Parse(Console.ReadLine());

            if (price > 100)
            {
                Console.WriteLine("El precio es mayor que 100");
            }
            else if (price == 100)
            {
                Console.WriteLine("El precio igual a 100");
            }
            else if (price < 100 && price > 90)
            {
                if(price > 95)
                {
                    Console.WriteLine("El precio es mayor a 95");
                }
                else
                {
                    Console.WriteLine("El precio es menor o igual que 95");
                }                
            }
            else
            {
                Console.WriteLine("El precio no es mayor a 100 o es menor o igual que 90");
            }
        }                
        public void ForStructure()
        {            
            Console.WriteLine("For - Structure");
            Console.WriteLine("===============");
            Console.WriteLine("Imprime numeros del 1 al 10");

            for (int count = 1; count <= 10; count++)
            {
                Console.WriteLine(count);
            }
        }
        public void WhileStructure()
        {
            int stock;
            int peopleCount = 0;
            int deliveryCount;

            Console.WriteLine("While - Structure");
            Console.WriteLine("=================");
            Console.Write("Ingrese Stock inicial : ");
            stock = int.Parse(Console.ReadLine());

            while (stock >= 10)
            {
                Console.Write("Ingrese cantidad a entregar : ");
                deliveryCount = int.Parse(Console.ReadLine());

                if(stock>= deliveryCount)
                {
                    stock = stock - deliveryCount;
                    peopleCount++;
                }
            }

            Console.WriteLine("Stock final : " + stock);
            Console.WriteLine("Cantidad de personas : " + peopleCount);
        }
        public void DoWhileStructure()
        {
            int stock;
            int peopleCount = 0;
            int deliveryCount;

            Console.WriteLine("Do While - Structure");
            Console.WriteLine("=================");
            Console.Write("Ingrese Stock inicial : ");
            stock = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Ingrese cantidad a entregar : ");
                deliveryCount = int.Parse(Console.ReadLine());

                if (stock >= deliveryCount)
                {
                    stock = stock - deliveryCount;
                    peopleCount++;
                }
            } while (stock >= 10);

            Console.WriteLine("Stock final : " + stock);
            Console.WriteLine("Cantidad de personas : " + peopleCount);
        }
        public void SwitchStructure()
        {
            byte numero;
            string dia;
                        
            Console.WriteLine("Switch - Structure");
            Console.WriteLine("==================");
            Console.Write("Ingrese numero del dia laborable : ");
            numero = byte.Parse(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miercoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                default:
                    dia = "No es día laborable";
                    break;
            }

            Console.WriteLine(dia);
        }
        public void BreakCommand()
        {
            Console.WriteLine("Break - Command");
            Console.WriteLine("===============");
            Console.WriteLine("Imprime numeros del 1 al 10");
            Console.WriteLine("Interrumpe en el numero 4");

            for (int count = 1; count <= 10; count++)
            {
                if(count == 4)
                {
                    break;
                }
                Console.WriteLine(count);
            }
        }
        public void ContinueCommand()
        {
            Console.WriteLine("Continue - Command");
            Console.WriteLine("==================");
            Console.WriteLine("Imprime numeros del 1 al 10");
            Console.WriteLine("A exepción del número 5");

            for (int count = 1; count <= 10; count++)
            {
                if (count == 5)
                {
                    continue;
                }
                Console.WriteLine(count);
            }
        }
        public void GoToCommand()
        {
            int opt;
            int cost = 0;

            Console.WriteLine("GoTo - Command");
            Console.WriteLine("==============");
            Console.WriteLine("Tamaños de cafe : 1=pequeño, 2=mediano, 3=grande");
            Console.Write("Por favor ingrese su seleción : ");
            opt = int.Parse(Console.ReadLine());
            
            switch (opt)
            {
                case 1:
                    cost += 25;
                    break;
                case 2:
                    cost += 50;
                    break;
                case 3:
                    cost += 50;
                    goto case 1;                    
                default:
                    Console.WriteLine("La selección es inválida");
                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine($"Por favor inserte {cost} centavos.");
            }

        }
        public void TryCatchStructure()
        {
            int opt;
            int cost = 0;

            Console.WriteLine("Try Catch - Structure");
            Console.WriteLine("=====================");
            Console.WriteLine("Tamaños de cafe : 1=pequeño, 2=mediano, 3=grande");
            Console.Write("Por favor ingrese su seleción : ");

            try
            {
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        cost += 25;
                        break;
                    case 2:
                        cost += 50;
                        break;
                    case 3:
                        cost += 50;
                        goto case 1;
                    default:
                        Console.WriteLine("La selección es inválida");
                        break;
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Ups!!, hubo un error");
            }


            if (cost != 0)
            {
                Console.WriteLine($"Por favor inserte {cost} centavos.");
            }

        }
        public void TryCatchFinallyStructure()
        {
            int dividendo;
            int divisor;
            double result; 

            try
            {
                Console.WriteLine("Try Catch Finally - Structure");
                Console.WriteLine("=============================");
                Console.Write("Ingrese dividendo : ");
                dividendo = int.Parse(Console.ReadLine());
                Console.Write("Ingrese divisor : ");
                divisor = int.Parse(Console.ReadLine());
                
                result = dividendo / divisor;

                Console.WriteLine($"El resultado de dividir {dividendo} entre el {divisor} es {result}");

                if (dividendo == 99999999)
                {
                    //throw new Exception("My cutom exception");                    
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Debe escribir 2 numeros enteros");
            }catch(DivideByZeroException dze)
            {
                Console.WriteLine("No es permitida la division por cero");
            }catch(Exception ex)
            {
                Console.WriteLine("Cheat Code");
            }
            finally
            {
                Console.WriteLine("Final de la división");
            }
        }
    }
}
