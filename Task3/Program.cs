/*
Задайте произвольную строку. 
Выясните, является ли она палиндромом.
*/

void Main()
{
   System.Console.Write("Введите произвольную строку:");
   string inputString = System.Console.ReadLine();
   string reverseString = ReverseString(inputString);

   if(inputString == reverseString)
        System.Console.WriteLine("Да");
    else
        System.Console.WriteLine("Нет");
    
}

string ReverseString(string inputString)
{   
    int strLength = inputString.Length;
    char[] charArray = new char[strLength];

    for(int i = 0; i < strLength; i++)
    {
        charArray[i] = inputString[strLength - 1 - i];
    }

    return string.Join("", charArray);
}

Main();
