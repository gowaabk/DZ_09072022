/* Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/


int Prompt(string message) //Ввод с приглашением.
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int SumPlusNum(int number)  //функция поиска чисел больше 0
{
    int count = 0;
    for (int i = 1; i <= number; i++)
    {
        int numberA = Prompt($"Введите {i}-е число ->");
        if (numberA > 0) count++;
    }
    return count;
}

int numberM = Prompt("Сколько чисел будете вводить? ->");
System.Console.WriteLine($"Количество чисел больше нуля равно {SumPlusNum(numberM)}");
