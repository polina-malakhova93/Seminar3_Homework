Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while(count < n)
{
    int result = Cube(count);
    count++;
    Console.Write($"{result}, ");
}
Console.WriteLine(Cube (n));

int Cube(int a)
{
    return a * a * a;
}

