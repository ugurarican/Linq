Random rnd = new Random();

List<int> numbers = Enumerable.Range(0, 10).Select(i => rnd.Next(-50, 50)).ToList();
Console.WriteLine("Oluşturulan Liste:");
foreach (var number in numbers)
{
    Console.WriteLine(number +" ");
}
Console.WriteLine("\n");


//Çift olan sayılar
var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
Console.WriteLine("Çift olan sayılar:");
foreach (var number in evenNumbers)
{
    Console.WriteLine(number + " ");
}
Console.WriteLine("\n");

//Tek olan sayılar
var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
Console.WriteLine("Tek olan sayılar:");
foreach(var number in oddNumbers)
{
    Console.WriteLine(number + " ");
}
Console.WriteLine("\n");

//Negatif sayılar
var negativeNumbers = numbers.Where(n => n < 0).ToList();
Console.WriteLine("Negatif sayılar:");
foreach (var number in negativeNumbers)
{
    Console.WriteLine(number + " ");
}
Console.WriteLine("\n");

//Pozitif sayılar
var positiveNumbers = numbers.Where(n => n > 0).ToList();
Console.WriteLine("Pozitif sayılar:");
foreach (var number in positiveNumbers)
{
    Console.WriteLine(number + " ");
}
Console.WriteLine("\n");


//15'den büyük ve 22 den küçük sayılar
var between15And22 = numbers.Where(n => n > 15 && n < 22).ToList();
Console.WriteLine("15 - 22 arasındaki sayılar:");
foreach (var number in between15And22)
{
    Console.WriteLine(number + " ");
}
Console.WriteLine("\n");

var squareNumbers = numbers.Select(n=>n*n).ToList();
Console.WriteLine("Listedeki her bir sayının karesi:");
foreach (var number in squareNumbers)
{
    Console.WriteLine(number + " ");
}
Console.WriteLine();