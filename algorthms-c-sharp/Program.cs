// See https://aka.ms/new-console-template for more information
using algorthms_c_sharp;
using System.Collections;

Console.WriteLine("Hello, World!");

//BinarySearch bs = new BinarySearch();

int[] FindEvenNumbers(int[] arr1, int[] arr2)
{
    ArrayList res = new ArrayList();

    foreach(int i in arr1)
        if(i % 2 == 0)
            res.Add(i);

    foreach (int i in arr2)
        if (i % 2 == 0)
            res.Add(i);

    return (int[])res.ToArray(typeof(int));
}


int[] ints = { -8, 2, 3, -9, 11, 20};
int[] ints2 = { -81, 2, 3, -90, 12, 21};
var tt = FindEvenNumbers(ints,ints2);

Array.ForEach(tt,Console.WriteLine);

foreach (var item in tt)
{
    Console.Write(item);
    Console.Write(" ");
}



