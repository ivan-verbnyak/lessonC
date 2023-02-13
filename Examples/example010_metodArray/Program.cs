int[] array = { 1, 3, 22, 5, 6, 798, 74, 2, 22 };

int n = array.Length;
int find = 22;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
index++;

}