// Calculate sum of an array

void SumOfAnArray()
{
    int sum = 0;
    int[] input = new int[5];

    Console.WriteLine("Enter 5 numbers");

    for (int i = 0; i < 5; i++)
    {
        input[i] = Convert.ToInt32(Console.ReadLine());
        sum += input[i];
    }
    Console.WriteLine("Sum of the array is : {0}", sum);
}
SumOfAnArray();