﻿using System;
using System.Collections.Generic;

namespace Answer
{
    public class Solution
    {
        /*
        Given an array of integers, find if the array contains any duplicates.

        Your function should return true if any value appears at least twice in
        the array, and it should return false if every element is distinct.
         */
        public bool ContainsDuplicate(int[] nums)
        {
            var hashSet = new HashSet<int>();

            foreach (var num in nums)
            {
                if (hashSet.Contains(num))
                {
                    return true;
                }
                hashSet.Add(num);
            }

            return false;
        }
    }
}
