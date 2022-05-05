//6 Задана последовательность из N чисел, необходимо посчитать сумму элементов этой последовательности
// В первой строке входного потока задано число N, не превышающее 1000, - количество элементов этой последовательности,
// во второй строке заданы N чисел, не превышающих 10000
// На выход необходимо вывести одно число - сумму элементов последовательности.

int SumNum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
	sum += numbers[i];
    return sum;
}
Console.Write("Введите количество чисел последовательности N = ");
int N = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[N];
Console.Write("Введите числа через пробел: ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
int sumNumbers = SumNum(numbers);
Console.WriteLine(sumNumbers);