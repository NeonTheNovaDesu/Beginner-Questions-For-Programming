//Find Maximum and Minimum:
static void FindMinAndMax() {
    int num1, num2, num3, num4, num5, min, max;

    Console.WriteLine("please enter 5 numbers");

    num1 = Convert.ToInt32( Console.ReadLine());
    num2 = Convert.ToInt32(Console.ReadLine());
    num3 = Convert.ToInt32(Console.ReadLine());
    num4 = Convert.ToInt32(Console.ReadLine());
    num5 = Convert.ToInt32(Console.ReadLine());

    max = num1;
    min = num1;

    if (max < num2) {
        max = num2;
    }
    else
    {
        min = num2;
    }
    if (max < num3) {
        max = num3;
    }
    if (min > num3) {
        min = num3;
    }
    if (max < num4) { 
        max = num4;
    }
    if (min > num4) {
        min = num4;
    }
    if (max < num5) { 
        max = num5;
    }
    if (min > num5){
        min = num5;
    }

    Console.WriteLine("Maxumim is : {0}", max);
    Console.WriteLine("Minimum is : {0}", min);
}
static void FindMinAndMaxWithArray() {
    int length, max, min;

    Console.WriteLine("Enter how many numbers you want: ");
    length = Convert.ToInt32( Console.ReadLine());

    int[] input = new int[length];

    Console.WriteLine("Enter {0} numbers: ", length);
    for (int i = 0; i < length; i++)
    {
        input[i] = Convert.ToInt32( Console.ReadLine());
    }
    min = input[0];
    max = input[0];

    for (int i = 1;i < length; i++) {
        if (max < input[i]) { 
        max = input[i];
        }
        if (min > input[i])
        {
            min = input[i];
        }
    }
    Console.WriteLine("Minimum is {0}", min);
    Console.WriteLine("Maximum is {0}", max);
}
//FindMinAndMax();
FindMinAndMaxWithArray();


