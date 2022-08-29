//Uppgift: Skapa ett kassasytem

int[] money = { 500, 200, 100, 50, 20, 10, 5, 1 };

Console.Write("Ange pris: ");
int owe = Int32.Parse(Console.ReadLine());
Console.Write("Betalt: ");
int payed = Int32.Parse(Console.ReadLine());

int afterTrans = payed - owe;

Console.WriteLine("Växel tillbaka: ");

foreach (int i in money)
{
	if (afterTrans >= i)
	{
		Console.WriteLine($"Antal {i} Lappar: {(afterTrans - afterTrans% i)/i}");
		afterTrans = afterTrans % i;
	}
}