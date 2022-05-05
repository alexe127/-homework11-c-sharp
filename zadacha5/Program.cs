//5 Дано N целых чисел. Требуется выбрать из них максимальное число.
// Вводится сначала число N - количество чисел в последовательности (1<=N<=100).
// Далее записана сама последовательность: N целых чисел, по модулю не превышающих 1000.
// Выведите искомое число.

int MaxNum(int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
         max = numbers[i];
    }
    return max;
}
Console.Write("Введите количество чисел последовательности N = ");
int N = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[N];
Console.Write("Введите числа через пробел: ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
int maxNumber = MaxNum(numbers);
Console.WriteLine(maxNumber);