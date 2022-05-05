//7 Задана последовательность из N чисел и задано еще одно число, необходимо найти позицию этого числа в последовательности
// или выдать, что такого числа нет на вход подается в первой строке число N - количество чисел в последовательности,
// в следующей строке написано N чисел - сама последовательность, а в последней строке входного файла написано число, 
//которое нужно найти в последовательности в выходной поток необходимо выдать, номер этого числа в последовательности
// или -1 если заданного числа в последовательности нет.

int Number(int[] numbers, int findNumber)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == findNumber)
		return i+1;       
    }
    return -1;
}
Console.Write("Введите количество чисел последовательности N = ");
int N = int.Parse(Console.ReadLine() ?? "0");
int[] numbers = new int[N];
Console.Write("Введите числа через пробел:  ");
numbers = (Console.ReadLine() ?? "0").Split(" ").Select(e => int.Parse(e)).ToArray();
Console.Write("Введите число, которое нужно найти: ");
int numberFind = int.Parse(Console.ReadLine() ?? "0");
int indexNumber = Number(numbers, numberFind);
Console.WriteLine(indexNumber);