namespace PrimeCheckerLib
{
    public class PrimeChecker
    {
        /// <summary>
        /// Проверяет, является ли число простым.
        /// </summary>
        /// <param name="number">Целое число</param>
        /// <returns>true, если число простое; иначе false</returns>
        public static bool IsPrime(int number)
        {
            // Числа <= 1 не являются простыми
            if (number <= 1) return false;
            // 2 и 3 – простые
            if (number <= 3) return true;
            // Чётные и делящиеся на 3 – не простые
            if (number % 2 == 0 || number % 3 == 0) return false;

            // Проверка делителей от 5 до sqrt(number) с шагом 6
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }
            return true;
        }
    }
}