//4  Дана последовательность чисел. Найти в ней наименьшее число.
// Сначала задано число N - количество чисел в последовательности, а затем N чисел (1 <  = N <  = 100).
// Выведите наименьшее число.

int MinNum(int[] numbers)
{
    int minNumber = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < minNumber) minNumber = numbers[i];
    }
    return minNumber;
}
Console.Write("Введите количество чисел последовательности N = ");
int N = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[N];
Console.Write("Введите числа через пробел: ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
int minNumber = MinNum(numbers);
Console.WriteLine(minNumber);