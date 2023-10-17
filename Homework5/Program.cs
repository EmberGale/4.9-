/////////////////////////////////
// Задание 5. Игра «Угадай число»
/////////////////////////////////

Console.WriteLine("Задание 5. Игра «Угадай число»");
Console.WriteLine("Введите максимальное число диапазона: ");
int number = int.Parse(Console.ReadLine());

Random rand = new Random();
int numberToGuess = rand.Next(number);

int guess;
bool guessed = false;
string input;

Console.WriteLine("Угадайте число");
while (!guessed)
{
    Console.WriteLine("Введите число: ");
    input = Console.ReadLine();
    bool result = Int32.TryParse(input, out guess);
    if (result == false) break;

    if (guess > numberToGuess) Console.WriteLine("Слишком много");
    if (guess < numberToGuess) Console.WriteLine("Слишком мало"); 
    if (guess == numberToGuess)
    {
        Console.WriteLine("!!! Правильно !!!");
        guessed = true;
    }
}