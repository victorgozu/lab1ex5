/*
 * Ex 5
Se citesc doua numere de la tastatura, x,y. Scrieti un program care va afisa cele
doua valori in ordine crescatoare.
• Exemplu: citim 9,0 Afisam : 0 9
*/

Console.WriteLine("Va rugam introduceti numarul intreg x: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Va rugam introduceti numarul intreg y:");
int y = int.Parse(Console.ReadLine());

if (x > y)
{
    Console.WriteLine(y + ", " + x);
}
else 
{ 
    Console.WriteLine(x + ", " + y);
}