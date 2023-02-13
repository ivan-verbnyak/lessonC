//Naxodim maximum v massive

int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
//               0   1   2   3   4   5   6   7   8
int[] array = { 11, 95, 64, 43, 56, 66, 65, 78, 46 };
array[0] = 12;

int result = Max ( 
    Max(array[0], array[1], array[3]),
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8]) 
);

Console.WriteLine(result);