// See https://aka.ms/new-console-template for more information


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            Solution sol = new Solution();
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };

            IList<IList<int>> ans = sol.ThreeSum(nums);
            for (int i = 0; i < ans.Count; i++)
            {
                for (int j = 0; j < ans[i].Count; j++)
                {
                    Console.Write("  " + ans[i][j]);
                }
                Console.WriteLine(" ");
            }
        }
    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            
            if(nums.Length < 3)
            {
                return ans;
            }
            // 資料排序
            Array.Sort(nums);
            if (nums[0] > 0)
            {
                return ans;
            }
            if (nums[nums.Length - 1] < 0) 
            { 
                return ans; 
            }

            for(int i = 0; i <  nums.Length-2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;
                if(i > 0 && nums[i] == nums[i-1])
                {
                    continue;
                }
                while(left < right)
                {
                    // 計算總和
                    int reg = nums[i] + nums[left] + nums[right];

                    // 判斷總和
                    if (reg == 0)
                    {
                        ans.Add(new List<int>() { nums[i], nums[left], nums[right] });
                    }

                    // 更改旗標位置
                    if(reg <= 0)
                    {
                        do
                        {
                            left++;
                        } while (left < nums.Length && nums[left] == nums[left - 1]);
                    }
                    if(reg >= 0)
                    {
                        do
                        {
                            right--;
                        } while (right > 0 && nums[right] == nums[right + 1]);
                    }
                }
            }
            return ans;
        }
    }
}




