static int GetMax(int[] numbers)
{
    int max = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }

    return max;
}

int[] numbers = { 1, 2, 3, 4 };
double average = GetMax(numbers);
Console.WriteLine(average);