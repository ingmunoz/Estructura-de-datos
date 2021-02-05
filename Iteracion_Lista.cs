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
            string nombres;
            string posicion = " ";

            //Agregar Elementos en una lista vacia
           listanombres .Add("Jonathan");
           listanombres.Add ("Amelia");
           listanombres.Add ("Hugo");
           listanombres.Add ("Pedro");

             // Agregar elemento en la primera posicion
            listanombres.Insert (0, "Andres");

            // recorrer la lista e imprimir en pantalla
            foreach (string listname in listanombres)
            {
                Console.WriteLine(listname);
            }
            
            Console.WriteLine("....................................");
            Console.WriteLine("lista despues de agregar y eliminar elemento");
            Console.WriteLine(".....................................");
           

             /*Insertar un elemento en la ultima posicion de una lista
             Elemento insertado en la posicion 5 porque la lista constaba de 4 elementos */
             listanombres.Insert(5, "Nicoll"); 

            //Insertar un elemento a continuacion de otro dado
            listanombres.Insert(2, "Chantal");

            // eliminar el primer elemento de una lista
            listanombres.RemoveRange(0,1);

             //Eliminar un elemento dada la posicion
            listanombres.RemoveAt(3);

            // Eliminar elemento dado de una lista
            listanombres.Remove("Pedro");

            // Recorrer e imprimir lista despues de agregar y eliminar
            foreach(string listname in listanombres)
            {
                Console.WriteLine(listname);
            }
            // pedir al usuario digite un nombre de la lista 
            Console.WriteLine("Ingrese el nombre de la lista que busca: ");

            nombres = Console.ReadLine();// leyendo los datos que digito el usuario

            for (int i = 0; i<listanombres.Count(); i++) //recorrer la lista y hacer un conteo
            {
                if (listanombres[i]==nombres)// preguntando si existe el nombre que usuario digito
                {
                    for (int a = 0; a<listanombres.Count(); a++)
                    {
                        if (listanombres[a] == nombres)
                        {
                            posicion = posicion + " " + (a+1);
                        }
                       
                    }
                }
                
            }
            Console.WriteLine("el nombre que busca esta en la posicion: {0} ",posicion);
                                                            //metodo para buscar un elemento en el indixe
            Console.WriteLine("el nombre que busca esta en la posicion: " + listanombres.IndexOf("Amelia"));
            Console.ReadKey ();
        }
    }
}
