//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int a = Input("Pleas enter the number ");
int count = 1;
while(count <= a)
{
    Console.WriteLine(count * count * count);
    count++;
}
