// Замена строк на столбцы

int[,] arr = new int[4,4]; 

void IsItPossible(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1)) 
    Console.WriteLine("Произвести замену невозможно");
    return;

}

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

    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    int[,] resArray = new int[row,col];

int[,] RowColSwap(int[,] array)
{
    
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resArray[i,j] = array[j,i];
        }
    }
    return resArray;
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

IsItPossible(arr);
FillArrRand(arr);
PrintArray(arr);
Console.WriteLine();
RowColSwap(arr);
PrintArray(resArray);