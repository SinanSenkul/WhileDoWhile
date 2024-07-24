Console.Write("Bir limit değer giriniz:");
int limit = Convert.ToInt32(Console.ReadLine());
int counter = 0;

//with do-while loop, iterated code will run at least once when we enter a negative number:
Console.Write("do-while döngüsü ile:");
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    counter++;
} while (counter <= limit);

Console.Write("---------------------------------");
//with while loop, iterated code will never run when we enter a negative number, as the required condition is not met from the very
//beginning:
Console.Write("while döngüsü ile:");
while (counter <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    counter++;
}
