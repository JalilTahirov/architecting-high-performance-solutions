// See https://aka.ms/new-console-template for more information
using algorthms_c_sharp;
using System.Collections;

Console.WriteLine("Hello, World!");

//BinarySearch bs = new BinarySearch();
#region findeven
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

//Array.ForEach(tt,Console.WriteLine);

//foreach (var item in tt)
//{
//    Console.Write(item);
//    Console.Write(" ");
//}

#endregion

#region reverse
int[] Reverse(int[] input)
{
    int[] res = new int[input.Length];
    for (int i=res.Length-1; i>=0;  i=i-1)
    {
        res[i] = input[input.Length-1 - i];
    }
    return res;
}

int[] myInput = { 3, 4, 5 };
var res = Reverse(myInput);
//Array.ForEach(res, Console.WriteLine);

#endregion

#region reverseplace


#endregion




