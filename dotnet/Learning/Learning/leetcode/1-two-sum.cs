using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.leetcode
{
    public class _1_two_sum
    {
        public int[] Start(int[] nums, int target) {
            int[] result = new int[2];
            bool found = false;

            for (int i = 0; i < nums.Length; i++) {
                for (int j = i + 1; j < nums.Length; j++) {
                    if(found)
                    {
                        break;
                    }

                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        found = true;
                    }
                }
            }

            return result;
        }


       public void _Start()
        {
            Console.WriteLine("1. Two Sum");
            Console.WriteLine("Given an array of integers, return indices of the two numbers such that they add up to a specific target.");
            Console.WriteLine("You may assume that each input would have exactly one solution, and you may not use the same element twice.");
            Console.WriteLine("Example:");
            Console.WriteLine("Given nums = [2, 7, 11, 15], target = 9,");
            Console.WriteLine("Because nums[0] + nums[1] = 2 + 7 = 9,");
            Console.WriteLine("return [0, 1].");
            Console.WriteLine("*************************************");
            Console.WriteLine();

            Console.WriteLine("Enter the array of integers:");
            string[] nums = Console.ReadLine().Split(' ');
            int[] numsInt = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                numsInt[i] = Convert.ToInt32(nums[i]);
            }

            Console.WriteLine("Enter the target:");
            int target = Convert.ToInt32(Console.ReadLine());

            int[] result = _TwoSum(numsInt, target);
            Console.WriteLine("Result: [{0}, {1}]", result[0], result[1]);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
            Console.Clear();
        }

        public int[] _TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            bool found = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (found)
                {
                    break;
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        found = true;
                        break;
                    }
                }
            }
            return result;
        }       
    }
}
