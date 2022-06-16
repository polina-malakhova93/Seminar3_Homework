Console.WriteLine("Введите пятизначное число: "); // 23432
int number = Convert.ToInt32(Console.ReadLine());

int digit = 0;
int reverse = 0;

while(number > 0)
{
    digit = number % 10;
    reverse = reverse * 10 + digit;
    number = number / 10;
}

if(number == reverse)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}