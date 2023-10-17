/////////////////////////////////////////////////////
// Задание 4. Наименьший элемент в последовательности
/////////////////////////////////////////////////////

Console.WriteLine("Задание 4. Наименьший элемент в последовательности");
int min = int.MaxValue;
int number;

Console.WriteLine("Введите длину последовательности: ");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Введите целые числа по одному");
for (int i = 0; i < length; i++)
{
    number = int.Parse(Console.ReadLine());
    if (number < min) min = number;
}

Console.WriteLine($"Наимегьшее число: {min}");