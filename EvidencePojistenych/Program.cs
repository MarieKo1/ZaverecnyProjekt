// See https://aka.ms/new-console-template for more information
using EvidencePojistenych;
using System.ComponentModel.Design;

List<Pojisteny> list = new List<Pojisteny>();
list.Add(new Pojisteny { Jmeno = "Jan", Prijmeni = "Novák", TelefonniCislo = "123456", Vek = 12 });
list.Add(new Pojisteny { Jmeno = "Jaroslav", Prijmeni = "Novotný", TelefonniCislo = "852147", Vek = 21 });
list.Add(new Pojisteny { Jmeno = "Jiří", Prijmeni = "Nový", TelefonniCislo = "654321", Vek = 35 });
bool pokracuj = true;
while (pokracuj)
{
    Console.WriteLine("_________________________");
    Console.WriteLine("Evidence pojištěných");
    Console.WriteLine("_________________________");
    Console.WriteLine("Vyber si akci:");
    Console.WriteLine("1 - Přidat nového pojištěného");
    Console.WriteLine("2 - Vypsat všechny pojištěné");
    Console.WriteLine("3 - Vyhledat pojištěného");
    Console.WriteLine("4 - Konec");
    bool pretypovano = int.TryParse(Console.ReadLine(), out int volba);
    

    if (volba == 1)
    {
        Pojisteny pojisteny = new Pojisteny();
        Console.WriteLine("Zadejte jméno pojištěného:");
        pojisteny.Jmeno = Console.ReadLine();
        Console.WriteLine("Zadejte příjmení:");
        pojisteny.Prijmeni = Console.ReadLine();
        Console.WriteLine("Zadejte telefonní číslo:");
        pojisteny.TelefonniCislo = Console.ReadLine();
        Console.WriteLine("Zadejte věk:");
        pojisteny.Vek = int.Parse(Console.ReadLine());


        list.Add(pojisteny);
        Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou.." );
        Console.ReadKey();
    }

    else if (volba == 2)
    {
        foreach (var pojisteny in list)
        {
            Console.WriteLine(pojisteny.ToString());
        }

        Console.WriteLine("Pokračujte libovolnou klávesou...");
        Console.ReadKey();
    }
    else if (volba == 3)
    {

        Console.WriteLine("Zadej jméno pojištěného:");
        string jmeno = Console.ReadLine();

        Console.WriteLine("Zadej příjmení:");
        string prijmeni = Console.ReadLine();

        foreach (var pojisteny in list)
        {
            if (jmeno == pojisteny.Jmeno && prijmeni == pojisteny.Prijmeni)
            {
                Console.WriteLine(pojisteny.ToString());

            }
        }

        Console.WriteLine("Pokračujte libovolnou klávesou...");
        Console.ReadKey();
    }
    else if (volba == 4)
    {
        pokracuj = false;
    }

    else { Console.WriteLine("Zadejte čísla od 1 - 4"); }

}






