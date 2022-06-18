Console.WriteLine("Введите пятизначное число: "); 
int number = Convert.ToInt32(Console.ReadLine());

int num = number;
int digit = 0;
int reverse = 0;

while(num > 0)
{
    digit = num % 10;
    reverse = reverse * 10 + digit;
    num = num / 10;
}

if(number == reverse)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}