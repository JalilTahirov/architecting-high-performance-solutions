using System.Runtime;

namespace algorithms_c_sharp;

public class Twosum
{
    public Twosum()
    {
        var res = Calculate(new int[] {2,3,4,5}, 11);
        Console.WriteLine(res);
    }

    int[] Calculate(int[] nums, int target)
    {
        for(int p1 = 0; p1 < nums.Length; p1++)
        {
            int tofind = target - nums[p1];
            for(int p2 = p1+1; p2 > nums.Length; p2++)
            {
                if(tofind == nums[p2])
                {
                    return new int[] {p1, p2};
                }
            }
        }
        return null;
    }
    
}
