static double GetAverage(int[] numbers)
{
    double summary = 0.0;
    foreach (var number in numbers)
    {
        summary += number;
    }

    return summary / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4 };
double average = GetAverage(numbers);
Console.WriteLine(average);