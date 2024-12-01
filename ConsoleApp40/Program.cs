int enteredNumber;
int reversedNumber = 0;
int remainder;

Console.Write("Введите число: ");
enteredNumber = Convert.ToInt32(Console.ReadLine());

while (enteredNumber != 0)
{
    remainder = enteredNumber % 10;
    reversedNumber = reversedNumber * 10 + remainder;
    enteredNumber /= 10;
}

Console.WriteLine($"Обратное число = {reversedNumber}");
Console.ReadLine();