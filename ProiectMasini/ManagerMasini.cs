using System;
using System.Collections.Generic;
using System.Text;

namespace ProiectMasini
{
    class ManagerMasini
    {
        private static List<Masina> listaMasini = new List<Masina>();

        public static void addMasina(Masina masina)
        {
            listaMasini.Add(masina);
        }

        public static void removeMasina(int id)
        {
            int ok = 0;
            foreach (var mas in listaMasini)
                if (mas.getIdMasina() == id)
                { listaMasini.Remove(mas); ok = 1; break; }
            if (ok == 0)
                Console.WriteLine("Id-ul este incorect... ");
        }

        public static void getMasini()
        {
            foreach(var mas in listaMasini)
            {
                Console.WriteLine(mas.toString());
            }
        }
    }
}
