// Дано N целых чисел. Требуется выбрать из них три таких числа, произведение которых максимально.
// Вводится сначала число N - количество чисел в последовательности (3<=N<=100).
// Далее записана сама последовательность: N целых чисел, по модулю не превышающих 1000.
//  Выведите три искомых числа в любом порядке.
// Если существует несколько различных троек чисел, дающих максимальное произведение, то выведите любую из них.

(int, int, int) findMaxProduct(int[] array)
{
    int maxProduct = array[0] * array[1] * array[2];
    (int, int,int) maxProductThreeNumbers = (array[0], array[1], array[2]);
    for (int i = 0; i < array.Length; i++)
        for (int j = i + 1; j < array.Length; j++)
            for (int k = j + 1; k < array.Length; k++)
                if (array[i] * array[j] * array[k] > maxProduct)
                {
                    maxProduct = array[i] * array[j] * array[k];
                    maxProductThreeNumbers = (array[i], array[j], array[k]);
                }
    return maxProductThreeNumbers;
}

Console.Write("Введите количество чисел последовательности N = ");
int N = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[N];
Console.Write("Введите числа, через пробел: ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
(int, int, int) newfindMaxProduct = findMaxProduct(numbers);
Console.WriteLine(newfindMaxProduct);

