// See https://aka.ms/new-console-template for more information
string[,,] arr = {
    { {"sara" },{"computer"},{"math"}  },
	{ { "ali"},{ "math"},{"law"} }, 
	{ { "reza"},{ "computer"},{ "law"} }
};

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(2); k++)
        Console.Write(arr[i, j, k]);
        Console.Write(" ");
    }
    Console.WriteLine();
}

