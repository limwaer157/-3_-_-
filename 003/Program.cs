// See https://aka.ms/new-console-template for more information
// int[] array = {1, 2, 43, 23, 455, 123, 12, 23,43,};

// int n = array.Length;
// int find = 43;
// int index = 0;

// while (index < n )
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     index = index + 1;
// }

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index = index + 1;
    }
}


void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position = position + 1;
    } 
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
           position = index;
        }
        index = index + 1;
    }
    return  position;
}

int[] array = new int [10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = indexOf(array,  4);

Console.WriteLine(pos);
