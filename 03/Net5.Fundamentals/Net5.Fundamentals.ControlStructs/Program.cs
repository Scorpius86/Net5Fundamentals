using System;

namespace Net5.Fundamentals.ControlStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            //PriceByFOR();
            //PriceByWHILE();
            //PriceByDO_WHILE();
            //PriceBySWITCH();
            //PriceByBREAK();
            //CONTINUE();
            //PriceGOTO();
            //PriceTRY_CATCH();
            PriceTRY_CATCH_FINALLY();

        }

        static void PriceTRY_CATCH_FINALLY()
        {
            int precio = 0;
            string rptaKey = "SI";


            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese Precio");
                    Console.WriteLine("==============");
                    precio = int.Parse(Console.ReadLine());

                    switch (precio)
                    {
                        case 500:
                            Console.WriteLine("El precio es 500");
                            break;
                        case 400:
                            Console.WriteLine("El precio es 400");
                            break;
                        case 300:
                            goto case 500;
                        default:
                            Console.WriteLine("El precio no es ni 400 ni 500");
                            break;
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }
                finally
                {
                    Console.WriteLine("¿Desea continuar?");
                    rptaKey = Console.ReadLine();
                }

                if (rptaKey.ToUpper() == "NO")
                {
                    break;
                }

            } while (true);
        }

        static void PriceTRY_CATCH()
        {
            int precio = 0;
            string rptaKey = "SI";


            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese Precio");
                    Console.WriteLine("==============");
                    precio = int.Parse(Console.ReadLine());

                    switch (precio)
                    {
                        case 500:
                            Console.WriteLine("El precio es 500");
                            break;
                        case 400:
                            Console.WriteLine("El precio es 400");
                            break;
                        case 300:
                            goto case 500;
                        default:
                            Console.WriteLine("El precio no es ni 400 ni 500");
                            break;
                    }
                    Console.WriteLine("¿Desea continuar?");
                    rptaKey = Console.ReadLine();

                    if (rptaKey.ToUpper() == "NO")
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }

            } while (true);            
        }

        static void PriceGOTO()
        {
            int precio = 0;
            string rptaKey = "SI";

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese Precio");
                Console.WriteLine("==============");
                precio = Convert.ToInt32(Console.ReadLine());

                switch (precio)
                {
                    case 500:
                        Console.WriteLine("El precio es 500");
                        break;
                    case 400:
                        Console.WriteLine("El precio es 400");
                        break;
                    case 300:
                        goto case 500;                        
                    default:
                        Console.WriteLine("El precio no es ni 400 ni 500");
                        break;
                }
                Console.WriteLine("¿Desea continuar?");
                rptaKey = Console.ReadLine();

                if (rptaKey.ToUpper() == "NO")
                {
                    break;
                }

            } while (true);
        }

        static void CONTINUE()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) { 
                    continue; 
                }                
                
                Console.WriteLine(i);
            }
        }

        static void PriceByBREAK()
        {
            int precio = 0;
            string rptaKey = "SI";

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese Precio");
                Console.WriteLine("==============");
                precio = Convert.ToInt32(Console.ReadLine());

                switch (precio)
                {
                    case 500:
                        Console.WriteLine("El precio es 500");
                        break;
                    case 400:
                        Console.WriteLine("El precio es 400");
                        break;
                    default:
                        Console.WriteLine("El precio no es ni 400 ni 500");
                        break;
                }
                Console.WriteLine("¿Desea continuar?");
                rptaKey = Console.ReadLine();

                if(rptaKey.ToUpper() == "NO") {
                    break;
                }

            } while (true);
        }

        static void PriceBySWITCH()
        {
            int precio = 0;
            string rptaKey = "SI";

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese Precio");
                Console.WriteLine("==============");
                precio = Convert.ToInt32(Console.ReadLine());

                switch (precio)
                {
                    case 500:
                        Console.WriteLine("El precio es 500");
                        break;
                    case 400:
                        Console.WriteLine("El precio es 400");
                        break;
                    default:
                        Console.WriteLine("El precio no es ni 400 ni 500");
                        break;
                }
                Console.WriteLine("¿Desea continuar?");
                rptaKey = Console.ReadLine();
            } while (rptaKey.ToUpper() == "SI");
        }

        static void PriceByDO_WHILE()
        {
            int precio = 0;
            string rptaKey = "SI";


            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese Precio");
                Console.WriteLine("==============");
                precio = Convert.ToInt32(Console.ReadLine());

                if (precio == 500)
                {
                    Console.WriteLine("El precio es 500");
                }
                else if (precio == 400)
                {
                    Console.WriteLine("El precio es 400");
                }
                else
                {
                    Console.WriteLine("El precio no es ni 400 ni 500");
                }

                Console.WriteLine("¿Desea continuar?");
                rptaKey = Console.ReadLine();
            } while (rptaKey.ToUpper() == "SI");
        }

        static void PriceByWHILE()
        {
            int precio = 0;            
            string rptaKey = "SI";

            while (rptaKey.ToUpper() == "SI")
            {
                Console.Clear();
                Console.WriteLine("Ingrese Precio");
                Console.WriteLine("==============");
                precio = Convert.ToInt32(Console.ReadLine());

                if (precio == 500)
                {
                    Console.WriteLine("El precio es 500");
                }
                else if (precio == 400)
                {
                    Console.WriteLine("El precio es 400");
                }
                else
                {
                    Console.WriteLine("El precio no es ni 400 ni 500");
                }

                Console.WriteLine("¿Desea continuar?");
                rptaKey = Console.ReadLine();
            }              
        }

        static void PriceByFOR()
        {
            int precio = 0;
            int limite = 3;

            for (int i = 0; i < limite; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese Precio");
                Console.WriteLine("==============");
                precio = Convert.ToInt32(Console.ReadLine());

                if (precio == 500)
                {
                    Console.WriteLine("El precio es 500");
                }
                else if (precio == 400)
                {
                    Console.WriteLine("El precio es 400");
                }
                else
                {
                    Console.WriteLine("El precio no es ni 400 ni 500");
                }

                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}

