using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorthms_c_sharp;

internal class BinarySearch
{
    public BinarySearch()
    {
        Console.WriteLine("doing binary search");
        var input = new int[] { 2, 3, 4, 5 };

        var res = Search(input, 2);
        Console.WriteLine(res);

        var res1 = Search(input, 3);
        Console.WriteLine(res1);

        var res2 = Search(input, 4);
        Console.WriteLine(res2);

        var res3 = Search(input, 5);
        Console.WriteLine(res3);

        var res4 = Search(input, 0);
        Console.WriteLine(res4);

        var res5 = Search(input, 7);
        Console.WriteLine(res5);

    }


    bool Search(int[] inputArray, int item) 
    { 
        // define the half of array
        // minimum 
        // maximum
        //
        // if equal to half return true
        //
        // check if the item is more or less than element in the half
        //          if more update the min to half
        //          if less max is half 

        int max = inputArray.Length-1;
        int min = 0;

        while(max>=min)
        {
            int mid = (max + min) / 2;

            if (inputArray[mid] == item) return true;

            if (inputArray[mid]>item)
            {
                max = mid-1;
                mid = (max + min) / 2;
            }
            else
            {
                min = mid+1;
                mid = (max + min) / 2;
            }
        }

        return false;
    }

}
