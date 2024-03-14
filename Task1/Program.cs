static double GetAverage(int[] numbers)
{
    double sumio = 0.0;
    foreach (var number in numbers)
    {
        sumio += number;
    }

    return sumio / numbers.Length;
}

int[] numbers = { 1, 2, 3, 4 };
double average = GetAverage(numbers);
Console.WriteLine(average);