//1 Вводится последовательность чисел. Посчитать в ней количество чётных чисел, стоящих на чётных местах.
//  Вводится сначала число N, а затем N чисел - члены последовательности.
// Выведите количество чётных чисел, стоящих на чётных местах в последовательности.

int sumNumbers(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i += 2)
        if (array[i] % 2 == 0) count++;
    return count;
}

Console.Write("Введите количество чисел последовательности N = ");
int N = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[N];
Console.Write("Введите числа, через пробел: ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
int newSumNumbers = sumNumbers(numbers);
Console.WriteLine(newSumNumbers);
