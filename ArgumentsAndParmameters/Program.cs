
Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();
PrintAnyWord(userInput);  // see on sõna mida kasutaja sisestab
static void PrintAnyWord(string anyString) // anyString on lihtsalt seletus
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("hello");
    }
}