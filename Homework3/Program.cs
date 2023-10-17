//////////////////////////////////////
// Задание 3. Проверка простого числа
//////////////////////////////////////

Console.WriteLine("Задание 3. Проверка простого числа");
Console.WriteLine("Введите целое число для проверки простоты: ");

int number = int.Parse(Console.ReadLine());
bool odd = false;
int counter = 2;

while (!odd & counter < number)
{
    if (number % counter == 0) odd = true; break;
    counter++;
}

switch (odd)
{
    case true: Console.WriteLine($"Число {number} - не является простым"); break;
    case false: Console.WriteLine($"Число {number} - является простым"); break;
}