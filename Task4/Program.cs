/*
 Задайте строку, состоящую из слов, разделенных пробелами. 
 Сформировать строку, в которой слова расположены в обратном порядке. 
 В полученной строке слова должны быть также разделены пробелами.
*/

void Main()
{
    System.Console.Write("Введите слова разделенные пробелом:");
    string inputString = System.Console.ReadLine();
    string[] words = inputString.Split(" ");
    string[] reversedWords = ReverseWords(words);
    string joinedWords = string.Join(" ", reversedWords);
    System.Console.WriteLine(joinedWords);
}

string[] ReverseWords(string[] words)
{
    int length = words.Length;
    string[] reversedWords = new string[length];
    for (int i = 0; i < length; i++)
    {
        int lastIndex = length - 1 - i;
        reversedWords[i] = words[lastIndex];
    }

    return reversedWords;
}

Main();
