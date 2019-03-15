using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioClase
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int num;
            Console.WriteLine("DIGITE UNA OPCION");
            Console.WriteLine("1 , 2  , 3");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1: eje1 obj1 = new eje1();
                    Console.WriteLine("DIGITE UN COLOR PARA LA LUZ DEL SEMAFORO");
                    Console.WriteLine("VERDE   ,  AMARILLO  , ROJO  ");
                    String opcion = Console.ReadLine();
                    Console.WriteLine(obj1.Estados(opcion));
                    Console.ReadKey();
                    break;

                case 2:
                    eje2 obj2 = new eje2();
                    String nombre1 = "LIGIA";
                    String nombre2 = "LIZETH";
                    String nombre3 = "GISELLA ";
                    String nombre4 = "JOSE";
                    Console.WriteLine("DIGITE UN COLOR PARA LA LUZ DEL SEMAFORO");
                    String color2 = Console.ReadLine();
                    Console.WriteLine(obj2.Estados(color2, nombre1));
                    Console.WriteLine(obj2.Estados(color2, nombre2));
                    Console.WriteLine(obj2.Estados(color2, nombre3));
                    Console.WriteLine(obj2.Estados(color2, nombre4));
                    Console.ReadKey();
                    break;
                case 3: eje3 obj3 = new eje3();

                    break;

            }
        }
    }
}
