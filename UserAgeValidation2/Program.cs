// See https://aka.ms/new-console-template for more information
//rakendus kusib kasutajal sisestada tema vanuse
//kui kasutaja vanus on v2iksem kui 12 siis konsoolis kuvatakse:
//"you are too young for IG"
//konsoolis kuvatakse "Welcome to IG"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); // "13"- heap 13 - stack

if (userAge >= 13)
{
    Console.WriteLine("Welcome to IG");
}
else
{
    Console.WriteLine("You are too young for IG");
}
    
