// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь

int[] GetArr(string stringArr)
{
    string[] num = stringArr.Split("", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[num.Length];
    
    for (int i = 0; i < num.Length; i++)
    {
        result[i] = int.Parse(num[i]);
    }
    return result;
}

int CountPos(int[] arr)
{
    int count = 0;
    foreach (int element in arr)
    {
        if (element > 0) count++;
        
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите числа: ");
string input = Console.ReadLine()!;
int[] numArr = GetArr(input);
int count = CountPos(numArr);
Console.WriteLine($"Чисел > 0: {count}");