// See https://aka.ms/new-console-template for more information
using algorthms_c_sharp;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

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

int[] myInput = { 3, 4, 5, 6,7,8};
var res = Reverse(myInput);
//Array.ForEach(res, Console.WriteLine);

#endregion

#region reverseplace
void ReverseInPlace(int[] input)
{
    // 0 1 2 3 4
    int len = input.Length;
    int mid = len / 2;
    for(int i = 0; i < mid; i++)
    {
        int temp = input[i];
        input[i] = input[len - 1 - i];
        input[len - 1 - i] = temp;
    }
}

//Array.ForEach(myInput,Console.Write);

ReverseInPlace(myInput);

//Console.WriteLine("  ");

//Array.ForEach(myInput, Console.Write);

#endregion

#region rotateanarray
void RotateArray(int[] arr)
{
    // update the value at index by 1 for example
    //123456 -> 234561
    var temp = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        arr[i-1] = arr[i];
    }
    arr[arr.Length - 1] = temp;

}

int[] input = {1,2,3,4,5,6,7,8};

RotateArray(input);
//Array.ForEach(input, Console.Write);
//Console.WriteLine();

RotateArray(input);
//Array.ForEach(input, Console.Write);
//Console.WriteLine();

RotateArray(input);
//Array.ForEach(input, Console.Write);
//Console.WriteLine();

#endregion

void DisplayFreqElements(int[] arr)
{

    Dictionary<int, int> dict = new Dictionary<int, int>();
    foreach(int value in arr)
    {
        if(dict.ContainsKey(value))
        {
            dict[value]++;
        }
        else
        {
            dict[value] = 1;
        }
    }

    foreach(KeyValuePair<int,int> x in dict)
    {
        Console.WriteLine(x.Key + " " + x.Value); 
    }

}

DisplayFreqElements(new int[] {2,2,3});

