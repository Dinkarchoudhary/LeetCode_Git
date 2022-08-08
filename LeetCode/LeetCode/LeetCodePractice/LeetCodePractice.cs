using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode
{
    class LeetCodePractice2
    {
        public static void Problems()
        {
            //int[,] nums = new int[,] { { 1,3 }, { 2, 6 }, { 8, 10},{ 15, 18 } };
            int[] nums = { 1, 3, 4, 2, 2 };
            int len = nums.Length;
            int[] n = new int[len - 1];

            for (int i = 0; i < len; i++)
            {
                if (n[nums[i] - 1] > 0)
                    Console.WriteLine(nums[i]);

                n[nums[i] - 1] = 1;
            }

            Console.WriteLine(-1);
            FindKthLargest();
            RotateArray();
            ContigiousSubArray();
            FindSubArray();
            MergeArray();
            ForLoopTest();
            Maximum_SubArray();
            Intersection_Of_3SortedArray();
            PythogonalTriplets();
            LongestConsecutive();
            IsSubsetArray();
            FindMedianSortedArrays();
            Candy();
            minSwaps();
            SingleNumberIII();
            SingleNumberII();
            SingleNumberII_V2();
            Subsets();
            Permutataion();
            RotateMatrix_90();
            ValidPalindromeInstring();
            NextGreaterElement();
        }
        public static void NextGreaterElement()
        {
            int[] nums1 = { 4, 1, 2 };
            int[] nums2 = { 1, 3, 4, 2 };
            // Time COmplexity = O(n^2).
            /*
            int[] result = new int[nums1.Length];
            int z = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                Boolean temp = false;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        temp = true;
                    }
                    if (nums1[i] < nums2[j] && temp == true)
                    {
                        result[z] = nums2[j];
                        break;
                    }
                    else
                    {
                        result[z] = -1;
                    }
                }
                z++;
            }
            Console.WriteLine(result);
            */
            // Time Complexity is O(m+n).
            Dictionary<int, int> dic = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            foreach (var num in nums2)
            {
                while (stack.Count > 0 && num > stack.Peek())
                    dic.Add(stack.Pop(), num);

                stack.Push(num);
            }

            int[] res = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
                res[i] = dic.ContainsKey(nums1[i]) ? dic[nums1[i]] : -1;

            Console.WriteLine(res);
        }
        public static bool ValidPalindromeInstring()
        {
            string s = "A man, a plan, a canal: Panama";
            string result = "";
            foreach (char c in s)
            {
                if (char.IsLetterOrDigit(c))
                {
                    result = result + c.ToString();
                }
            }
            result = result.ToLower();
            for (int i = 0; i < result.Length / 2; i++)
            {
                if (result[i] != result[result.Length -i- 1])
                {
                    return false;
                }
            }
            return true;
        }
        public static void RotateMatrix_90()
        {
            int[,] arr = {{1, 2, 3, 4},
                  {5, 6, 7, 8},
                  {9, 10, 11, 12},
                  {13, 14, 15, 16}};

            for(int i =0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void Permutataion()
        {
            Console.WriteLine("-----------------------Permutation Backtracking Subsets----------------------");
            string data = "abc";
            Permutation_of_String(data, 0, data.Length);
        }
        public static void Permutation_of_String(string s, int l, int r)
        {
            if(l ==r)
            {
                Console.WriteLine(s);
                return;
            }
            for(int i =l;i<r;i++)
            {
                s = SwapNum(s, l, i);
                Permutation_of_String(s, l + 1, r);
                // Here again we swapped because after backtracking again we need a string as a abc to computer 
                s = SwapNum(s, l, i);
            }
        }
        public static string SwapNum(string s,int l , int i)
        {
            char[] array = s.ToCharArray();
            char tempswap = array[l];
            array[l]= array[i];
            array[i] = tempswap;
            string str = new string(array);
            return str;
        }
        public static IList<IList<int>> Subsets()
        {
            int[] nums = { 1, 2, 3 };
            string data = "";
            foreach (var item in nums)
            {
                data = data + item.ToString();
            }
            IList<IList<int>> ans = new List<IList<int>>();
            List<int> ob = new List<int>();
            string result = Subsets(data, 0, "");
            ob.Add(Convert.ToInt32(result));
            ans.Add(ob);
            return ans;
        }
        public static string Subsets(string s, int i, string cur)
        {
            //Complexity of this soln is 2^n
            if (i == s.Length)
            {
                return cur;
            }
            Subsets(s, i + 1, cur + s[i]);
            Subsets(s, i + 1, cur);
            return null;
        }
        public static void SingleNumberII_V2()
        {
            int[] nums = { 2, 2, 1, 5, 1, 1, 2 };
            int[] bitsCount = new int[32];

            foreach (var num in nums)
            {
                for (int i = 0; i < 32; i++)
                {
                    if ((num & (1 << i)) != 0)
                    {
                        bitsCount[i]++;
                    }
                }
            }

            int res = 0;

            for (int i = 0; i < 32; i++)
            {
                if ((bitsCount[i] % 3) == 1)
                {
                    res = res | (1 << i);
                }
            }

            Console.WriteLine(res);
        }
        public static void SingleNumberII()
        {
            //int[] nums = { 2, 2, 3, 2 };
            int[] nums = { 2, 2, 1, 5,1,1,2 };
            int n = nums.Length;
            int[] freq = new int[32];

            foreach(int num in nums)
            {
                for (int i = 0; i < 32; i++)
                {
                    int bit = (1 << i) & num;
                    if (bit ==0)
                    {
                        freq[i]++;
                    }
                }
            }
            int ans = 0;

            for (int i = 0; i < 32; i++)
            {
                if (freq[i] % 3 == 0)
                    ans += 1 << i;
            }
            Console.WriteLine(ans);
        }
        public static void SingleNumberIII()
        {
            int[] nums = { 1, 2, 1, 3, 2, 5 };
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
                res = res ^ nums[i];

            int lsb = res & ~(res - 1);
            int x = 0;
            int y = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                int check = nums[i] &lsb;
                if (check == 0)
                {
                    x ^= nums[i];
                }
                else
                {
                    y ^= nums[i];
                }
            }
            Console.WriteLine( x + " "+  y );
        }
        public static void minSwaps()
        {
            //Minimum Swaps required to group all 1’s together
            //geeksforgeeks.org/minimum-swaps-required-group-1s-together/
            int[] arr = { 1, 0, 1, 0, 1 };
            int n = arr.Length;
            int numberOfOnes = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == 1)
                    numberOfOnes++;
            }
            int x = numberOfOnes;

            int count_ones = 0, maxOnes;
            for (int i = 0; i < x; i++)
            {
                if (arr[i] == 1)
                    count_ones++;
            }

            maxOnes = count_ones;
            for (int i = 1; i <= n - x; i++)
            {
                if (arr[i - 1] == 1)
                    count_ones--;
                if (arr[i + x - 1] == 1)
                    count_ones++;
                if (maxOnes < count_ones)
                    maxOnes = count_ones;
            }
            int numberOfZeroes = x - maxOnes;
            Console.WriteLine(numberOfZeroes);
        }
        public static void Candy()
        {
            //Chocolate Distribution Problem , Candy Problem
            int[] ratings = { 1, 0, 2 };
            int n = ratings.Length;
            int[] nums = new int[n];
            for (int i = 0; i < n; i++) nums[i] = 1;

            for (int i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1]) nums[i] = nums[i - 1] + 1;
            }

            for (int i = n - 1; i > 0; i--)
            {
                if (ratings[i - 1] > ratings[i]) nums[i - 1] = Math.Max(nums[i - 1], nums[i] + 1);
            }

            Console.WriteLine(nums.Sum());
        }
        public static double FindMedianSortedArrays()
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };
            // Median of Two Sorted Array
            int[] arr = new int[nums1.Length + nums2.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                arr[i] = nums1[i];
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                arr[nums1.Length + i] = nums2[i];
            }
            Array.Sort(arr);
            if (arr.Length % 2 != 0)
            {
                int middle = arr.Length / 2;
                return arr[middle];
            }
            else
            {
                int middle = arr.Length / 2;
                double sum = arr[middle - 1] + arr[middle];
                double result = sum/ 2;
                return result;
            }
            return 0;
        }
        public static void IsSubsetArray()
        {
            //Find whether an array is subset of another array
            //https://www.geeksforgeeks.org/find-whether-an-array-is-subset-of-another-array-set-1/
            int[] arr1 = { 11, 1, 13, 21, 3, 7 };
            int[] arr2 = { 11, 3, 7, 1};
            bool result = true;
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            int i = 0;
            int j = 0;
            for(i =0;i<arr2.Length;i++)
            {
                for(j =0;j<arr1.Length;j++)
                {
                    if(arr2[i] == arr1[j])
                    {
                        break;
                    }
                }
                if(j == arr1.Length)
                {
                    result = false;
                }
            }
            Console.WriteLine(result);
        }
        public static void LongestConsecutive()
        {
            //int[] nums = {0,3,7,2,5,8,4,6,0,1};
            //int[] nums = { 100, 4, 200, 1, 3, 2 };
            int[] nums = { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
            }
            Array.Sort(nums);
            int count = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] + 1 == nums[i + 1])
                {
                    count++;
                }
                /*
                if (min == nums[i])
                {
                    min++;
                    count++;
                }
                else
                {
                    min = nums[i+1];
                    count = 0;
                }
                */
            }
            Console.WriteLine(count+1);
        }
        public static void PythogonalTriplets()
        {
            int n = 5;
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    int c = (int)Math.Sqrt(j * j + i * i);
                    if (c * c == i * i + j * j && c <= n)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }
        public static void Intersection_Of_3SortedArray()
        {
            Console.WriteLine("----------------------ARRAY INTERSECTION PROGRAM-------------------------");
            int[] num1 = { 1, 5, 10, 20, 40, 80 };
            int[] num2 = { 6, 7, 20, 80, 100 };
            int[] num3 = { 3, 4, 15, 20, 30, 70, 80, 120 };
            int i = 0, j = 0, k = 0;
            while(i<num1.Length && j<num2.Length && k<num3.Length)
            {
                if(num1[i] == num2[j] && num2[j] == num2[k])
                {
                    Console.WriteLine(num1[i]);
                    i++;
                    j++;
                    k++;
                }
                else if(num1[i] < num2[j])
                {
                    i++;
                }
                else if(num2[j] < num3[k])
                {
                    j++;
                }
                else if(num3[k] < num1[i])
                {
                    k++;
                }
            }
            
        }

        public static void Maximum_SubArray()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
            }
            int high = nums.Length - 1;
            int result = DnCSubarray(nums, 0, high);
            Console.WriteLine(result);
        }
        public static int DnCSubarray(int[] nums, int low, int high)
        {
            if (low == high)
            {
                return nums[low];
            }
            int middle = (low + high) / 2;
            return Math.Max(Math.Max(DnCSubarray(nums, low, middle), DnCSubarray(nums, middle + 1, high)), maxCrossingSum(nums, low, middle, high));
        }
        public static int maxCrossingSum(int[] nums, int low, int mid, int high)
        {
            int leftsum = int.MinValue;
            int sum = 0;
            /*
            for(int i =low;i<=mid;i++)
            {
                sum = sum +nums[i];
                if(sum > leftsum)
                {
                    leftsum = sum;
                }
            }
            */
            for (int i = mid; i >= low; i--)
            {
                sum = sum + nums[i];
                if (sum > leftsum)
                {
                    leftsum = sum;
                }
            }
            int rightsum = int.MinValue;
            sum = 0;
            for (int i = mid + 1; i <= high; i++)
            {
                sum = sum + nums[i];
                if (sum > rightsum)
                {
                    rightsum = sum;
                }
            }
            return Math.Max(leftsum + rightsum, Math.Max(leftsum, rightsum));
        }
        public static void ForLoopTest()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int low = 0;
            int high = arr.Length - 1;
            int sum = 0;
            for(int i=low;i<=high;i++)
            {
                sum = sum + arr[i];
            }
            int sum2 = 0;
            for(int i=high;i>= low;i--)
            {
                sum2 = sum2 + arr[i];
            }
            Console.WriteLine(sum+" " +sum2);
        }
        public static void TestRegrex()
        {
            //var data = "99/resume_228940.pdf";
            //data.ToString().Replace("/", "\\");
            //Console.WriteLine(data);

            //var data2 = "99\resume_228940.pdf";
            //data2.Replace(@"\", @"\\");
            //Console.WriteLine(data2);

            ////var result = Regex.Replace(@"afd\tas\asfd\", @"\\", @"\\");
            //var result = Regex.Replace(data, @"/", @"\");
        }
        public static void MergeArray()
        {
            int[] nums1 = { 4, 0, 0, 0, 0, 0 };
            int[] nums2 = { 1, 2, 3, 5, 6 };
            int m = 1;
            int n = 5;
            int num2Length = nums2.Length - 1;
            int num1Length = nums1.Length - 1;
            int num1End = m - 1;
            int num2End = n - 1;

            while (num1End >= 0 && num2End >= 0)
            {
                if (nums2[num2End] >= nums1[num1End])
                {
                    nums1[num1Length] = nums2[num2End];
                    num2End--;
                }
                else
                {
                    nums1[num1Length] = nums1[num1End];
                    num1End--;
                }
                num1Length--;
            }

            while (num2End >= 0 && num1End < 0)
            {
                nums1[num1Length] = nums2[num2End];
                num1Length--;
                num2End--;
            }
        }

        public static void FindSubArray()
        {
            //int[] nums = { 1, 2, 3 };
            int[] nums = { 1, 2, 6, 3, 4 };
            int k = 9;
            Dictionary<int, int> preSum = new Dictionary<int, int>();
            preSum.Add(0, 1);
            int count = 0, sum = 0;
            for(int i =0;i<nums.Length;i++)
            {
                sum += nums[i];

                if (preSum.ContainsKey(sum - k))
                    count += preSum[sum - k];

                if (preSum.ContainsKey(sum))
                    preSum[sum]++;
                else
                    preSum.Add(sum, 1);
            }
        }
        public static void ContigiousSubArray()
        {
            int[] nums = { 2, 3, -2, 4 };
            int prod = 1;
            int ret = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                prod *= nums[i];
                ret = Math.Max(ret, prod);
                if (prod == 0)
                    prod = 1;
            }
            prod = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                prod *= nums[i];
                ret = Math.Max(ret, prod);
                if (prod == 0)
                    prod = 1;
            }
            Console.WriteLine(ret);
        }
        public static void RotateArray()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            int lp = 0;
            while (lp < k)
            {
                int len = nums.Length;
                int[] result = new int[len];
                int z = 0;
                for (int i = 0; i < len - 1; i++)
                {
                    if (i == 0)
                    {
                        result[z] = nums[len - 1];
                        z++;
                        result[z] = nums[i];
                        z++;
                    }
                    else
                    {
                        result[z] = nums[i];
                        z++;
                    }
                }
                nums = result;
                lp++;
            }
        }
        public static int FindKthLargest()
            {
            int[] nums = { 3, 2, 3, 1, 2, 4, 5, 5, 6 };
            int k = 4;
                var sd = new SortedDictionary<int, int>(new Comparer<int>());
                foreach (var item in nums)
                {
                    if (sd.ContainsKey(item))
                    {
                        sd[item] = sd[item] + 1;
                    }
                    else
                    {
                        sd.Add(item, 1);
                    }
                }

                int res = -1;
                foreach (var it in sd)
                {
                    k -= it.Value;
                    if (k <= 0)
                    {
                        res = it.Key;
                        break;
                    }
                }
                return res;
            }

        }
    public class Comparer<T> : IComparer<int>
    {
        public int Compare(int a, int b)
        {
            return b - a;
        }
    }

}

