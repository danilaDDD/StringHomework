/*
Задайте строку, содержащую латинские буквы
в обоих регистрах. Сформируйте строку, в которой все
заглавные буквы заменены на строчные. 
*/

void Main()
{
    System.Console.Write("Введите строку из латинских символов:");
    string inputString = System.Console.ReadLine();
    System.Console.WriteLine(inputString.ToLower());
}

Main();