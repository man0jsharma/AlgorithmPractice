using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solutions
    {
        //617. Merge Two Binary Trees

        //Given two binary trees and imagine that when you put one of them to cover the other, 
        //some nodes of the two trees are overlapped while the others are not.
        //You need to merge them into a new binary tree.The merge rule is that if two nodes overlap,
        //then sum node values up as the new value of the merged node.Otherwise, the NOT null node will be used as the node of new tree.
        //Input: 
        // Tree 1                     Tree 2                  
        //          1                         2                             
        //         / \                       / \                            
        //        3   2                     1   3                        
        //       /                           \   \                      
        //      5                             4   7                  
        //Output: 
        //Merged tree:
        //      3
        //     / \
        //    4   5
        //   / \   \ 
        //  5   4   7
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null)
                return null;

            if (t1 != null && t2 == null)
                t2 = new TreeNode(0);

            if (t2 != null && t1 == null)
                t1 = new TreeNode(0);

            var mergedBinaryTree = new TreeNode((t1 != null ? t1.val : 0) + (t2 != null ? t2.val : 0))
            {
                left = MergeTrees(t1.left, t2.left),
                right = MergeTrees(t1.right, t2.right)
            };
            return mergedBinaryTree;
        }




        /// <summary>
        /// 461. Hamming Distance
        /// The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

        //        Given two integers x and y, calculate the Hamming distance.

        //        Note:
        //0 ≤ x, y< 231.

        //Example:

        //Input: x = 1, y = 4

        //Output: 2

        //Explanation:
        //1   (0 0 0 1)
        //4   (0 1 0 0)
        //       ↑   ↑

        //The above arrows point to positions where the corresponding bits are different.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int HammingDistance(int x, int y)
        {
            var count = 0;
            for (var c = x ^ y; c != 0; c = c >> 1)
            {
                if ((c & 1) == 1) count++;
            }
            return count;
        }

        /// <summary>
        /// 561. Array Partition I
        /// 
        /// Given an array of 2n integers, your task is to group these integers into n pairs of integer, say (a1, b1), (a2, b2), ..., (an, bn) which makes sum of min(ai, bi) for all i from 1 to n as large as possible.
        //Example 1:
        //Input: [1,4,3,2]

        //        Output: 4
        //Explanation: n is 2, and the maximum sum of pairs is 4 = min(1, 2) + min(3, 4).
        //Note:
        //n is a positive integer, which is in the range of[1, 10000].
        //All the integers in the array will be in the range of[-10000, 10000].
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            var sum = 0;
            for (var i = 0; i < nums.Length; i = i + 2)
            {
                sum += nums[i];
            }
            return sum;
        }


        /// <summary>
        /// 476. Number Complement
        /// Given a positive integer, output its complement number. The complement strategy is to flip the bits of its binary representation.

        //        Note:
        //The given integer is guaranteed to fit within the range of a 32-bit signed integer.
        //You could assume no leading zero bit in the integer’s binary representation.
        //Example 1:
        //Input: 5
        //Output: 2
        //Explanation: The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.
        //Example 2:
        //Input: 1
        //Output: 0
        //Explanation: The binary representation of 1 is 1 (no leading zero bits), and its complement is 0. So you need to output 0.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int FindComplement(int num)
        {
            var complement = 0;
            for (int i = 0; num != 0; i++)
            {
                complement |= ((num & 1) == 1 ? 0 : 1) << i;
                num = num >> 1;
            }
            return complement;
        }

        /// <summary>
        ///  557. Reverse Words in a String III
        //   
        //  Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

        //Example 1:
        //Input: "Let's take LeetCode contest"
        //Output: "s'teL ekat edoCteeL tsetnoc"
        //Note: In the string, each word is separated by single space and there will not be any extra space in the string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseWords(string s)
        {
            var wordList = s.Split(' ');
            if (s == "") return "";
            var result = new StringBuilder();

            for (int i = 0; i < wordList.Length; i++)
            {
                result.Append(ReverseWord(wordList[i]));
                result.Append((i < wordList.Length - 1) ? " " : "");
            }
            return result.ToString();
        }

        private StringBuilder ReverseWord(string s)
        {
            if (s.Length == 0) return null;
            var sb = new StringBuilder();
            var result = sb.Append(ReverseWord(s.Substring(1)) + s.Substring(0, 1));
            return result;
        }



        /// <summary>
        /// 500. Keyboard Row
        /// Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.


        //        Example 1:
        //Input: ["Hello", "Alaska", "Dad", "Peace"]
        //        Output: ["Alaska", "Dad"]


        //        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public string[] FindWords(string[] words)
        {

            var firstRow = "qwertyuiop";
            var secondRow = "asdfghjkl";
            var thirdRow = "zxcvbnm";
            var result = new List<string>();

            foreach (var word in words)
            {
                int r1 = 1, r2 = 1, r3 = 1;
                var wordArray = word.ToCharArray();
                foreach (var c in wordArray)
                {
                    r1 &= firstRow.Contains(char.ToLower(c)) ? 1 : 0;
                    r2 &= secondRow.Contains(char.ToLower(c)) ? 1 : 0;
                    r3 &= thirdRow.Contains(char.ToLower(c)) ? 1 : 0;
                }

                if (r1 + r2 + r3 == 1)
                    result.Add(word);
            }
            return result.ToArray();
        }
    }
}
