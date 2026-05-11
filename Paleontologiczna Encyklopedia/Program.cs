using System.Runtime.InteropServices;

class program
{
    class Dinozaury
    {
        public string nazwa;
        public string dieta;
        public string okres;
        public string opis;
        
        public Dinozaury(string nazwa, string dieta, string okres, string opis)
        {
            this.nazwa = nazwa;
            this.dieta = dieta;
            this.okres = okres;
            
            this.opis = opis;
        }

    }
    static void Main(string[] args)
    {
        
        string[] linie = File.ReadAllLines("Dinozaury.txt");
        
        List<Dinozaury> lista = new List<Dinozaury>();
        while (true)
        {
            
           
            int wybor;
            int wybor2;
            int wybor3;
            Console.WriteLine("== Paleontologiczna baza danych ==");
            Console.WriteLine("1. Dodaj Gatunek");
            Console.WriteLine("2. Wyświetl wszystkie gatunki bez podziału");
            Console.WriteLine("3. Encyklopedia");
            Console.WriteLine("4. Okresy geologiczne");
            Console.WriteLine("5. Wyjście");
            wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                

                    
                case 1:
                    Console.WriteLine("Nazwa: ");
                    string nazwa = Console.ReadLine();
                    Console.WriteLine("Dieta: ");
                    string dieta = Console.ReadLine();
                    Console.WriteLine("Okres: ");
                    string okres = Console.ReadLine();
                    
                    Console.WriteLine("Opis: ");
                    string opis = Console.ReadLine();
                    
                    File.AppendAllText("Dinozaury.txt", nazwa + ";" + dieta + ";" + okres + ";" + opis + ";");
                    lista.Add(new Dinozaury(nazwa, dieta, okres, opis));
                    Console.WriteLine("Dodano: " + nazwa);
                    break;
                case 2:
                    
                    foreach (Dinozaury wyswietl in lista)
                    {
                        Console.WriteLine(wyswietl.nazwa);
                        Console.WriteLine(wyswietl.dieta);
                        Console.WriteLine(wyswietl.okres);
                        Console.WriteLine(wyswietl.opis);
                    }
                    
                    
                    break;

                case 3:
                    Console.WriteLine("== Encyklopedia ==");
                    Console.WriteLine("Kategoria: ");
                    Console.WriteLine("1. Dinozaury");
                    wybor2 = int.Parse(Console.ReadLine());
                    switch (wybor2)
                    {
                        case 1:
                            Console.WriteLine("== Dinozaury ==");
                            Console.WriteLine("Opis: Dinozaury to grupa gadów, która dominowała na Ziemi przez około 160 milionów lat, od późnego triasu do końca kredy. Charakteryzowały się różnorodnością form, rozmiarów i trybów życia. Niektóre były dwunożne, inne czworonożne, a jeszcze inne potrafiły latać. Dinozaury były roślinożerne, mięsożerne lub wszystkożerne. Wymarły około 66 milionów lat temu, prawdopodobnie w wyniku katastrofy kosmicznej.");
                            Console.WriteLine("1. Mięsożerne");
                            Console.WriteLine("2. Roślinożerne");
                            Console.WriteLine("3. Wróć");
                            wybor3 = int.Parse(Console.ReadLine());
                            switch (wybor3)
                            {
                                case 1:
                                    Console.WriteLine("=== Mięsożercy ===");
                                    return;
                                case 2:
                                    Console.WriteLine("=== Roślinożercy ===");
                                    return;
                                case 3:
                                    
                                    break;
                            }
                            break;
                    }
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
            }
        }

    }
}