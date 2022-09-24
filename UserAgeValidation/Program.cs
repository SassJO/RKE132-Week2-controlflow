// See https://aka.ms/new-console-template for more information


//rakendus kysib kasutajal valida tema sugu (M/F)
//rakendus kysib kasutajal sisestada tema perekonnanime
//l2htudes kasutaja valikust, rakenuds tervitab kasutajat j2rgmiselt
//Welcome, Mr [Name] /Welcome Ms. [Name]
Console.WriteLine("Please select your gender (m/f):");

char userGender =Char.Parse(Console.ReadLine()); //loeb konsoolits maga andmeid string (s6ne) formaadis
Console.WriteLine("Please, enter your name");

string userLastname = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastname}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome Ms.{userLastname}!");
}
else
{
    Console.WriteLine($"Welcome {userLastname}!");
}

