﻿// Задача по нахождению четных чисел массива и вывод их на экран

//int n = 10;
int [] arr = {2,5,4,7,8,35,1,3,8,5};
int i = 0;
while (i < arr.Length) // или можно создать переменную int n = 10 и производить сравнение.
{
    if(arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
       
    }
    i++;
}