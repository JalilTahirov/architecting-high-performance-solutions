using System.Runtime;

namespace algorithms_c_sharp;

public class Twosum
{
    public Twosum()
    {
        var res = CalculateTwo(new int[] {2,3,4,5,9}, 12);
        Console.WriteLine(res[0] + ", "+ res[1]);
    }


    public int[] TwoSumWithHashSet(int[] nums, int target) {

        Dictionary<int,int> tfdict = new Dictionary<int, int>();
        int len = nums.Length;
        for(int i = 0; i<len; i++)
        {   
            int ntf = target - nums[i];
            if(tfdict.ContainsKey(ntf))
            {
                // return value and current index 
                return new int[] {tfdict[ntf], i};
            }
            else
            {
                tfdict.TryAdd(nums[i], i);
            }
        }
        return null;
    }


    int[] CalculateTwo(int[] nums, int target)
    {
        Dictionary<int, int> valueIndex = new Dictionary<int, int>();

        for(int p1 = 0; p1 < nums.Length; p1++)
        {
            int tofind = target - nums[p1];
            if(valueIndex.ContainsKey(nums[p1]))
            {
                return new int[] {p1, valueIndex[nums[p1]]};
            }
            else
            {
                valueIndex.Add(tofind, p1);
            }

        }
        
        return null;
    }

    int[] Calculate(int[] nums, int target)
    {
        for(int p1 = 0; p1 < nums.Length; p1++)
        {
            int tofind = target - nums[p1];
            for(int p2 = p1+1; p2 < nums.Length; p2++)
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
