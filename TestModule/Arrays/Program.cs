int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
array[0] = 1;
array[1] = 2;

int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 2, 3, 4 } };

int[][] jagged = new int[5][];
jagged[0] = new int[5];
jagged[1] = new int[10] { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9 };
jagged[2] = new int[2];
jagged[3] = new int[10];
jagged[4] = new int[20];

jagged[1][2];


foreach(int tmp in array)
{
    Console.WriteLine(tmp);
}

for(int i = 0; i < array.Length; i++)
{
    int tmp = array[i];
    Console.WriteLine(tmp);
}