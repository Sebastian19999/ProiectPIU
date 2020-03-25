using System;

namespace ProiectMasini
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMasini masiniMan;
            Masina masina;

            string c;

            Test();

            do
            {
                Console.Clear();
                Console.WriteLine("1. Adaugare masina");
                Console.WriteLine("2. Editare masina");
                Console.WriteLine("3. Stergere masina");
                Console.WriteLine("4. Cea mai cautata masina");
                Console.WriteLine("5. Grafic al preturilor");
                Console.WriteLine("6. Tranzactii");
                Console.WriteLine("7. Afisare lista masini");
                Console.WriteLine("8. Exit");

                switch (Convert.ToChar(c=(Console.ReadLine())))
                {
                    case '1':   Console.WriteLine("ADAUGARE MASINA");
                                Console.WriteLine();
                                Console.Write("Introduceti numele complet al vanzatorului: ");
                                string numev = Console.ReadLine();
                                Console.Write("Introduceti numele complet al cumparatorului: ");
                                string numec = Console.ReadLine();
                                Console.Write("Introduceti firma masinii: ");
                                string numef = Console.ReadLine();
                                Console.Write("Introduceti modelul masinii: ");
                                string numem = Console.ReadLine();
                                Console.Write("Introduceti anul fabricatiei: ");
                                int anf = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Introduceti culoarea masinii: ");
                                string culoare = Console.ReadLine();
                                Console.Write("Introduceti optiunile masinii, separate printr-o virgula in cazul in care sunt mai multe: ");
                                string optiuni = Console.ReadLine();
                                Console.Write("Introduceti data tranzactiei [dd.mm.aaaa]: ");
                                string datat = Console.ReadLine();
                                Console.Write("Introduceti pretul masinii: ");
                                double pret = Convert.ToDouble(Console.ReadLine());

                                //masina = new Masina(numev, numec, numef, numem, anf, culoare, optiuni, datat, pret);
                                ManagerMasini.addMasina(new Masina(numev, numec, numef, numem, anf, culoare, optiuni, datat, pret));
                                Console.ReadLine();
                                break;
                    case '2':   Console.WriteLine("Optiunea 2");
                                Console.ReadLine();
                                break;
                    case '3':   Console.WriteLine("STERGERE MASINA \n");
                                Console.WriteLine("Lista disponibila cu masini este: \n");
                                ManagerMasini.getMasini();
                                Console.Write("\n Introduceti ID-ul masinii pe care doriti sa o stergeti: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                ManagerMasini.removeMasina(id);
                                Console.ReadLine();
                                break;
                    case '4':   Console.WriteLine("Optiunea 4");
                                Console.ReadLine();
                                break;
                    case '5':   Console.WriteLine("Optiunea 5");
                                Console.ReadLine();
                                break;
                    case '6':   Console.WriteLine("Optiunea 6");
                                Console.ReadLine();
                                break;
                    case '7':   Console.WriteLine("Lista masini: ");
                                ManagerMasini.getMasini();
                                Console.ReadLine();
                                break;
                    case '8':   return;

                }
            } while (true);
        }
        private static void Test()
        {
            ManagerMasini.addMasina(new Masina("Popescu, Ionescu, Ford, Mondeo, 2008, rosu, 16.02.2019, 6500"));
        }

    }
    
}
