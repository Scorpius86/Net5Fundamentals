using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Net5.ListAndThread.ConsoleList
{
    public class ListAndThread
    {
        public void ArraySample()
        {
            Console.WriteLine("Array");
            Console.WriteLine("=====");
            int[] array = new int[5];

            for (int i = 0; i < 5; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"array[{i}] : {array[i]}");
            }
            Console.WriteLine($"Size : {array.Length}");
            Console.WriteLine("Inicializacion y asignacion");

            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            int[] array3 = { 6,7,8,9,10 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"array3[{i}] : {array3[i]}");
            }

            Console.WriteLine("Arreglo multi dimensional");
            int[,] multidimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"multidimensionalArray[{i},{j}] : {multidimensionalArray[i, j]}");
                }
                
            }

            int[][] matrix = new int[6][];
            matrix[0] = new int[] { 1, 2, 3, 4, 5 };
            matrix[1] = new int[] { 1, 2, 3, 4, 5, 6 };
            matrix[2] = new int[] { 1, 2, 3, 4, 5, 6,7 };

            for (int i = 0; i < 6; i++)
            {
                if (matrix[i] == null) continue;

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.WriteLine($"matrix[{i},{j}] : {matrix[i][j]}");
                }

            }

            Console.WriteLine("Arreglo de String");
            string[] weekDays = new string[] { "Lunes","Martes","Miercoles","Jueves", "Viernes"};
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }

            int[,] array5;
            array5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            //array5 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            int[,] array6 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        }

        public void ListSample()
        {
            Console.WriteLine("List");
            Console.WriteLine("=====");

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);

            numbers.ForEach(num =>
            {
                Console.WriteLine($"Numbers : {num}");
            });

            List<string> cities = new List<string>
            {
                "Lima",
                "Villa el salvador",
                "Rimac",
                "Callao",
                "Jesus Maria",
                "San Juan de Lurigancho",
                "Miraflores",
                "San Isidro",
                "Villa maria del triunfo"
            };

            cities.ForEach(city =>
            {
                Console.WriteLine($"Cities : {city}");
            });

            Console.WriteLine("Ciudades de tamaño menor o igual a 6");
            cities.Where(city => city.Length <= 6).ToList().ForEach( c =>
            {
                Console.WriteLine(c);
            });

            List<Person> people = new List<Person>
            {
                new Person{ Name = "Erick",Age = 39,Sexo="M" },
                new Person{ Name = "Jorge", Age = 30,Sexo="M"},
                new Person{ Name = "Azucena", Age = 22,Sexo="F"},
                new Person{ Name = "Jeniffer", Age = 21,Sexo="F"}
            };

            Console.WriteLine("Mujeres del salon de clase");
            people.Where(person => person.Sexo == "F").ToList().ForEach(p => Console.WriteLine(p.Name));
            Console.WriteLine($"La suma de edades es : {people.Sum(p => p.Age)}");

            
        }
        public void DictionarySample()
        {
            Console.WriteLine("Dictionary");
            Console.WriteLine("==========");

            Dictionary<string, Person> people = new Dictionary<string, Person>();

            people.Add("12345678", new Person { DNI = "12345678", Name = "Erick", Age = 39, Sexo = "M" });
            people.Add("56465136", new Person { DNI = "56465136", Name = "Jorge", Age = 30, Sexo = "M" });
            people.Add("78976521", new Person { DNI = "78976521", Name = "Azucena", Age = 22, Sexo = "M" });
            people.Add("21324846", new Person { DNI = "21324846", Name = "Jeniffer", Age = 21, Sexo = "M" });

            Console.WriteLine($"Azucena : {people.Where(kvp => kvp.Value.Name == "Azucena").Select(s=>s.Key).ToList().First()}");

            Console.WriteLine($"Key : 56465136, Value {people["56465136"].Name}");
        }

        public void SortedListSample()
        {
            Console.WriteLine("SortedList");
            Console.WriteLine("==========");

            SortedList<string, Person> people = new SortedList<string, Person>();

            people.Add("12345678", new Person { DNI = "12345678", Name = "Erick", Age = 39, Sexo = "M" });
            people.Add("56465136", new Person { DNI = "56465136", Name = "Jorge", Age = 30, Sexo = "M" });
            people.Add("78976521", new Person { DNI = "78976521", Name = "Azucena", Age = 22, Sexo = "M" });
            people.Add("21324846", new Person { DNI = "21324846", Name = "Jeniffer", Age = 21, Sexo = "M" });

            Console.WriteLine($"Azucena : {people.Where(kvp => kvp.Value.Name == "Azucena").Select(s => s.Key).ToList().First()}");
            Console.WriteLine($"Key : 56465136, Value {people["56465136"].Name}");

            people.Select(p => p.Key).ToList().ForEach(k => Console.WriteLine($"Key : {k}"));

                        
        }

        public void HashTableSample()
        {
            Console.WriteLine("HashTable");
            Console.WriteLine("==========");

            Dictionary<string, Person> people = new Dictionary<string, Person>();

            people.Add("12345678", new Person { DNI = "12345678", Name = "Erick", Age = 39, Sexo = "M" });
            people.Add("56465136", new Person { DNI = "56465136", Name = "Jorge", Age = 30, Sexo = "M" });
            people.Add("78976521", new Person { DNI = "78976521", Name = "Azucena", Age = 22, Sexo = "M" });
            people.Add("21324846", new Person { DNI = "21324846", Name = "Jeniffer", Age = 21, Sexo = "M" });

            Hashtable ht = new Hashtable(people);

            Console.WriteLine($"Key Hash : 56465136, Nombre : {((Person)ht["56465136"]).Name}");
        }

        public void StackSample()
        {
            Console.WriteLine("Stack (LIFO)");
            Console.WriteLine("============");

            Stack<Person> people = new Stack<Person>();

            people.Push(new Person { DNI = "12345678", Name = "Erick", Age = 39, Sexo = "M" });
            people.Push(new Person { DNI = "56465136", Name = "Jorge", Age = 30, Sexo = "M" });
            people.Push(new Person { DNI = "78976521", Name = "Azucena", Age = 22, Sexo = "M" });
            people.Push(new Person { DNI = "21324846", Name = "Jeniffer", Age = 21, Sexo = "M" });

            int count = people.Count;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Elementos en el stack : {people.Count}");
                Console.WriteLine($"Extraer el elemento del stack : {people.Peek().Name}");
                Console.WriteLine($"Eliminar el elemento del stack : {people.Pop().Name}");
            }
            
        }

        public void QueueSample()
        {
            Console.WriteLine("Queue (FIFO)");
            Console.WriteLine("============");

            Queue<Person> people = new Queue<Person>();

            people.Enqueue(new Person { DNI = "12345678", Name = "Erick", Age = 39, Sexo = "M" });
            people.Enqueue(new Person { DNI = "56465136", Name = "Jorge", Age = 30, Sexo = "M" });
            people.Enqueue(new Person { DNI = "78976521", Name = "Azucena", Age = 22, Sexo = "M" });
            people.Enqueue(new Person { DNI = "21324846", Name = "Jeniffer", Age = 21, Sexo = "M" });

            int count = people.Count;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Elementos en el stack : {people.Count}");
                Console.WriteLine($"Extraer el elemento del stack : {people.Peek().Name}");
                Console.WriteLine($"Eliminar el elemento del stack : {people.Dequeue().Name}");
            }

        }

        public void TupleSample()
        {
            Console.WriteLine("Tuple");
            Console.WriteLine("=====");

            List<Tuple<string, string, Tuple<string, string, int, string>>> people = new List<Tuple<string, string, Tuple<string, string, int, string>>>();

            Tuple<string, string, int, string> erick = new Tuple<string, string, int, string>("12345678", "Erick",39,"M");
            Tuple<string, string, int, string> jorge = new Tuple<string, string, int, string>("56465136", "Jorge", 30, "M");

            Tuple<string, string, Tuple<string, string, int, string>> e = new Tuple<string, string, Tuple<string, string, int, string>>("12345678", "Erick", erick);
            Tuple<string, string, Tuple<string, string, int, string>> j = new Tuple<string, string, Tuple<string, string, int, string>>("56465136", "Jorge", jorge);

            people.Add(e);
            people.Add(j);

            Console.WriteLine(e.Item1);
            Console.WriteLine(e.Item3.Item2);

            Console.WriteLine(people[0].Item1);
            Console.WriteLine(people[0].Item3.Item2);

        }

        public void ValueTupleSample()
        {
            Console.WriteLine("ValueTuple");
            Console.WriteLine("==========");

            (string, string, int, string) person = ("12345678", "Erick", 39, "M");
                        
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);
            Console.WriteLine(person.Item4);
        }

        public void ThreadSample()
        {
            Console.WriteLine("Thread");
            Console.WriteLine("======");
            ParallelProcess parallelProcess = new ParallelProcess();
            
            Thread th1 = new Thread(new ThreadStart(parallelProcess.WriteProcess01));
            Thread th2 = new Thread(new ThreadStart(parallelProcess.WriteProcess02));

            th1.Start();
            th2.Start();

            //parallelProcess.WriteProcess01();
            //parallelProcess.WriteProcess02();
        }

        public void TaskSample()
        {
            Console.WriteLine("Task");
            Console.WriteLine("======");
            ParallelProcess parallelProcess = new ParallelProcess();

            Task[] tasks = new Task[2];
            string taskName01 = "Tarea 01";
            string taskName02 = "Tarea 02";

            tasks[0] = Task.Factory.StartNew((Object obj)=> {
                TaskParameter param = (TaskParameter)obj;
                parallelProcess.WriteProcess01(param.Name);
            },new TaskParameter {Name = taskName01});

            tasks[1] = Task.Factory.StartNew((Object obj) => {
                TaskParameter param = (TaskParameter)obj;
                parallelProcess.WriteProcess02(param.Name);
            }, new TaskParameter { Name = taskName02 });

            Task.WaitAll(tasks);
            //parallelProcess.WriteProcess01();
            //parallelProcess.WriteProcess02();
        }

        public void StreamReaderSample()
        {
            Console.WriteLine("StreamReader");
            Console.WriteLine("============");
            ParallelProcess parallelProcess = new ParallelProcess();

            StreamReader sr = new StreamReader("Sample.txt");

            string line = sr.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }


        }

        public void StreamWriterSample()
        {
            Console.WriteLine("StreamWrite");
            Console.WriteLine("============");
            ParallelProcess parallelProcess = new ParallelProcess();

            StreamWriter sr = new StreamWriter("Writer.txt");
            sr.WriteLine("Texto 01");
            sr.WriteLine("Texto 02");
            sr.WriteLine("Texto 03");
            sr.Close();
        }

    }

    public class TaskParameter
    {
        public string Name { get; set; }
    }

    public class ParallelProcess
    {
        public void WriteProcess01()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Escribiendo desde el proceso 01 (i) -> : {i}");
                Random rnd = new Random();
                int waitTime = rnd.Next(1, 100);
                Thread.Sleep(waitTime * 100);
            }
        }
        public void WriteProcess01(string name)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Escribiendo desde la {name} (i) -> : {i}");
                Random rnd = new Random();
                int waitTime = rnd.Next(1, 100);
                Thread.Sleep(waitTime*100);
            }
        }

        public void WriteProcess02()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Escribiendo desde el proceso 02 (i) -> : {i}");
                Random rnd = new Random();
                int waitTime = rnd.Next(1, 100);
                Thread.Sleep(waitTime * 10);
            }
        }

        public void WriteProcess02(string name)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Escribiendo desde la {name} (i) -> : {i}");
                Random rnd = new Random();
                int waitTime = rnd.Next(1, 100);
                Thread.Sleep(waitTime * 10);
            }
        }
    }
}
