//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
string Input(string text)
{
    Console.WriteLine(text);
    return Console.ReadLine();
}
string a = Input("Enter the number");
char[] charArray = a.ToCharArray();
Array.Reverse(charArray);
string reverseString = new string(charArray);

Console.WriteLine(reverseString);



if(a == reverseString)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не Палиндром");
}
Console.ReadLine();