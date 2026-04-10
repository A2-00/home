using PrimeCheckerLib;

Console.Write("Введите целое число: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    bool result = PrimeChecker.IsPrime(number);
    Console.WriteLine($"{number} {(result ? "является" : "не является")} простым.");
}
else Console.WriteLine("Некорректный ввод.");