﻿// массив 
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}
int a1 = 34;
int a2 = 21;
int a3 = 23;
int b1 = 12;
int b2 = 699;
int b3 = 65;
int c1 = 65;
int c2 = 46;
int c3 = 23;

// int max1 = Max(a1 , b1, c1);
// int max2 = Max(a2 , b2, c2);
// int max3 = Max(a3 , b3, c3);

int max = Max
(Max(a1 , b1, c1),
Max(a2 , b2, c2),
Max(a3 , b3, c3)); 

Console.WriteLine(max);

