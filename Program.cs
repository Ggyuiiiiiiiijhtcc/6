using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine().ToLower(); // переводим строку в нижний регистр

        int vowelsCount = 0, consonantsCount = 0, wordCount = 0, punctuationCount = 0, digitCount = 0, otherCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (char.IsWhiteSpace(ch) || char.IsPunctuation(ch))
            {
                // если символ разделитель (пробел или знак пунктуации)
                if (i > 0 && !char.IsWhiteSpace(input[i - 1]) && !char.IsPunctuation(input[i - 1]))
                {
                    // если перед ним была не разделительная символ, значит это слово
                    wordCount++;
                }
            }
            else if (char.IsLetter(ch))
            {
                // если буква
                if ("aeiouyауоыэяюёие".Contains(ch))
                {
                    vowelsCount++;
                }
                else
                {
                    consonantsCount++;
                }
            }
            else if (char.IsDigit(ch))
            {
                digitCount++;
            }
            else if (char.IsPunctuation(ch))
            {
                punctuationCount++;
            }
            else
            {
                otherCount++;
            }
        }

        // увеличиваем счетчик слов, если последний символ не является разделителем
        if (!char.IsWhiteSpace(input[input.Length - 1]) && !char.IsPunctuation(input[input.Length - 1]))
        {
            wordCount++;
        }

        int totalCharsCount = input.Length;

        Console.WriteLine($"Всего символов - {totalCharsCount}, из них");
        Console.WriteLine($"Слов - {wordCount}");
        Console.WriteLine($"Гласных - {vowelsCount}");
        Console.WriteLine($"Согласных - {consonantsCount}");
        Console.WriteLine($"Знаков пунктуации - {punctuationCount}");
        Console.WriteLine($"Цифр - {digitCount}");
        Console.WriteLine($"Других символов - {otherCount}");
    }
}
