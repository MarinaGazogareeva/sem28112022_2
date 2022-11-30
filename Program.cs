// Task 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.WriteLine("Ведите пятизначное число: ");
string n = Console.ReadLine();
char[] arr = n.ToCharArray();
Array.Reverse(arr);
string n2 = new String(arr);

if ( n == n2)
{
    Console.Write("yes");
}
else
{
     Console.Write("no");
}
