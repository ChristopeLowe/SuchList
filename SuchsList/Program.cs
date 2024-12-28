// See https://aka.ms/new-console-template for more information
Console.WriteLine("Wie heißt du bitte?");
string Name = Console.ReadLine();
Console.WriteLine("");
if (!string.IsNullOrEmpty(Name))
{
    Console.WriteLine($"Du bist Willkommen bei uns {Name}");

}
else
{
    Console.WriteLine("Tragen sie bitte eine gültige Name ein !");
    return;
}
Console.WriteLine("");

//List<int> SuchsList = new List<int>();
int[] SuchsList = {1,5,3,78,6,20,15,10,8};
bool MyNumber = false;

while (!MyNumber)
{
    Console.WriteLine($"{Name} Trägt einen Nummer ein !");
    Console.WriteLine("");
    if (int.TryParse(Console.ReadLine(),out int YouNumber))
    {
        if (Array.Exists(SuchsList, Element => Element == YouNumber))
        {
        Console.WriteLine($"{Name} Super! deine Wahl stellt in unser Liste ");
        MyNumber = true;
        }
        else
        {
            Console.WriteLine("Sorry");
        }
    }
    else
    {
        Console.WriteLine("ungültigen Nummer ! Bitte Versuchen sie noch !");
    }    
    
}