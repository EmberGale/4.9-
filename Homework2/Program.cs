////////////////////////////////////////////////////////
// Задание 2. Программа подсчёта суммы карт в игре «21»
////////////////////////////////////////////////////////

Console.WriteLine("Задание 2.Программа подсчёта суммы карт в игре «21»");
Console.WriteLine("Здравствуйте, введите число карт: ");
int number = int.Parse(Console.ReadLine());
string input;
int value;
int sum = 0;

Console.WriteLine("Вводите номера карт по одной");
for (int i = 0; i < number; i++)
{
    input = Console.ReadLine();
    bool result = Int32.TryParse(input, out value);
    switch (result)
    {
        case true:
            sum += value; break;
        case false:
            sum += 10; break;
    }
}

Console.WriteLine($"Сумма карт: {sum}");