int x1 = Input("Введите координату x1: ");
int x2 = Input("Введите координату x2: ");
int y1 = Input("Введите координату y1: ");
int y2 = Input("Введите координату y2: ");
int z1 = Input("Введите координату z1: ");
int z2 = Input("Введите координату z2: ");

int distanceX = CalculateDistance(x1,x2);
int distanceY = CalculateDistance(y1,y2);
int distanceZ = CalculateDistance(z1,z2);

Console.WriteLine(Math.Sqrt(Quadro(distanceX) + Quadro(distanceY) + Quadro(distanceZ)));

int Quadro(int a) 
{
    return a * a;
}

int CalculateDistance(int a, int b) 
{
    return a-b;
}


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}