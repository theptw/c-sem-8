//Task 53


int[,] arr = new int[4,4];

int[,] FillArrRand(int[,] array)
{
    Random rand = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(0,30);
        }
    }
    return array;
}


 

void RowSwap(int[,] array)
{
    int row = array.GetLength(0) - 1;
    int col = array.GetLength(1) - 1;
    int helpSwap = 0;
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i==0)
            {
            helpSwap = array[i,j];
            array[i,j] = array[row,j];
            array[row,j] = helpSwap;
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             if (j == 0 ) Console.Write("|"); 
             if (j < array.GetLength(1) - 1 & array[i,j]/10 >= 1) Console.Write(array[i,j] + "|");
             else  if (j < array.GetLength(1) - 1) Console.Write(array[i,j] + " |");
             else if (array[i,j] / 10 >= 1) Console.Write(array[i,j] + "|");
             else Console.Write(array[i,j] + " |");
        }
        Console.WriteLine();
    }

}

FillArrRand(arr);
PrintArray(arr);
Console.WriteLine();
RowSwap(arr);
PrintArray(arr);










