int Message(string text) { 
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetDoubleMass(int r, int c) { // заполнение двумерного массива
    int[,] MyArray = new int[r,c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            Random rnd = new Random();
            MyArray[i,j] = rnd.Next(1,99);
        }
    }
    return MyArray;
}

void PrintDoubleMass(int[,] arr) { // вывод двумерного массива
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
   
}

int[] DoubleToSingleMass(int[,] arr) { // Запись элементов двумерного массива в одномерный массив
    int count = 0;
    int[] SingleArr = new int[arr.GetLength(0) * arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                
                SingleArr[count] = arr[i,j];
                count++;
    
            }
        }
    return SingleArr;
}

void PrintSingleMass(int[] arr) { // вывод одномерного массива
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int rows = Message("Введите количество строк матрицы");
int columns = Message("Введите количество столбцов матрицы");
int[,] Matrix = GetDoubleMass(rows,columns);
Console.WriteLine();
PrintDoubleMass(Matrix);
int[] SingleArray = DoubleToSingleMass(Matrix);
Console.WriteLine();
PrintSingleMass(SingleArray);