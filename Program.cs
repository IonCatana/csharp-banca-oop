using System;

namespace csharp_banca_oop
{
    internal class Program
    {
        /* Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo 
           con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.  */
        static void Main(string[] args)
        {
            Banca MiaBanca = new Banca("Intesa San Paolo");
            Cliente cliente = new Cliente("Ion", "Catana", "CTNIO92C17Z180K", 30);
            Console.WriteLine(cliente.ToString());

        }
    }
}
