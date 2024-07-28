int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
PrintNumbers("Numbers", numbers);
PrintNumbers("Even Numbers", numbers.Where(x => IsEven(x)));

PrintNumbers("Odd Numbers", numbers.Where(x => IsOdd(x)));
Console.ReadKey();

void PrintNumbers(string title, IEnumerable<int> numbers)
{
    Console.WriteLine();
    Console.WriteLine(title);
    Console.Write("[");
    foreach (int number in numbers)
        Console.Write($" {number} ,");
    Console.Write("]");
    Console.WriteLine();
}
bool IsEven(int number) => (number % 2 == 0);
bool IsOdd(int number) => !IsEven(number);
