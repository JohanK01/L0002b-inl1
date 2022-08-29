//Uppgift: Skapa ett kassasytem

//Skapade en  array för valörerna
int[] money = { 500, 200, 100, 50, 20, 10, 5, 1 };

//Indata för pris och betalning
Console.Write("Ange pris: ");
int owe = Int32.Parse(Console.ReadLine());
Console.Write("Betalt: ");
int payed = Int32.Parse(Console.ReadLine());
int afterTrans = payed - owe;

//Kollar om du har tillräkligt med pengar
//om du har tillräkligt med pegnar så körs koden 
if (afterTrans < 0)
{
    Console.WriteLine($"Det saknas: {-afterTrans} kr");
}
else
{
    Console.WriteLine("Växel tillbaka: ");

    foreach (int i in money)
    {
        if (afterTrans >= i)
        {
            Console.WriteLine($"Antal {i} Kr: {(afterTrans - afterTrans % i) / i}");
            afterTrans = afterTrans % i;
        }

    }
}

