using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listanombres = new List<string>(); // crear lista vacias

            //Agregar Elementos en una lista vacia
           listanombres .Add("Jonathan");
           listanombres.Add ("Amelia");
           listanombres.Add ("Hugo");
           listanombres.Add ("Pedro");
             // Agregar elemento en la primera posicion
            listanombres.Insert (0, "Andres");

            for (int contador = 0; contador < listanombres.Count (); contador++)
                    
                    {
                Console.WriteLine (listanombres [contador]);
            }
            Console.ReadKey ();
        }
    }
}
