///////////////////////////////////////////////////////////////////
// Задание 1. Приложение по определению чётного или нечётного числа
///////////////////////////////////////////////////////////////////

Console.WriteLine("Задание 1. Приложение по определению чётного или нечётного числа");
Console.WriteLine("Введите число");
int number;
number = int.Parse(Console.ReadLine());

string oddness;
if (number % 2 == 0) oddness = "Четное";
else oddness = "Нечетное";
Console.WriteLine("Число {0}: {1}", number, oddness);

////////////////////////////////////////////////////////
// Задание 2. Программа подсчёта суммы карт в игре «21»
////////////////////////////////////////////////////////

Console.WriteLine("Задание 2.Программа подсчёта суммы карт в игре «21»");
Console.WriteLine("Здравствуйте, введите число карт: ");
number = int.Parse(Console.ReadLine());
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

//////////////////////////////////////
// Задание 3. Проверка простого числа
//////////////////////////////////////

Console.WriteLine("Задание 3. Проверка простого числа");
Console.WriteLine("Введите число для проверки простоты: ");
number = int.Parse(Console.ReadLine());
bool odd = false;
int counter = 1;
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

/////////////////////////////////////////////////////
// Задание 4. Наименьший элемент в последовательности
/////////////////////////////////////////////////////

Console.WriteLine("Задание 4. Наименьший элемент в последовательности");
int min = int.MaxValue;
Console.WriteLine("Введите длину последовательности: ");
int length = Console.ReadLine();
Console.WriteLine("Введите целые числа по одному");
for(int i = 0; i<length; i++)
{
    number = int.Parse(Console.ReadLine());
    if (number < min) min = number;
}

Console.WriteLine($"Наимегьшее число: {min}");

/////////////////////////////////
// Задание 5. Игра «Угадай число»
/////////////////////////////////

Console.WriteLine("Задание 5. Игра «Угадай число»");
Console.WriteLine("Введите максимальное число диапазона: ")
number = int.Parse(Console.ReadLine());
Random rand = new Random;
int numberToGuess = rand.Next(number);
int guess;
bool guessed = false;

Console.WriteLine("Угадайте число");
while (!guessed)
{
    bool result = Int32.TryParse(input, out guess);
    if (result == false) break;

    switch (guess)
    {
        case guess > numberToGuess: Console.WriteLine("Слишком много"); break;
        case guess < numberToGuess: Console.WriteLine("Слишком мало"); break;
        case guess == numberToGuess: Console.WriteLine("!!! Правильно !!!"); guessed = true; break;
    }
}