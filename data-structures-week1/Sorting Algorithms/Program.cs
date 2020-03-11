using System;

namespace Sorting_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting Algorithms

#region bubblenotes            //Bubble Sort
                // 1. look at each consecutive pair, swap them if they are not in order
                // 2. repeat this whole process until you go a whole pass without making changes

            //Given an array
                // 1. what initial order would bubble sort handle the fastest
                    //starting out lowest to highest
                // 2. what initial order would bubble sort handle the slowest
                    //starting out highest to lowest
#endregion
            int[] data = {1, 5, 7, 3, 9, 6, 7};
            System.Console.WriteLine("Before sent: {" + string.Join(", ", data) + "}");

            BubbleSort2(data);
            //MergeSort(data);
            System.Console.WriteLine("After sort: {" + string.Join(", ", data) + "}");

        }


        #region unused // 
        static bool BubbleSort2(int[] array)
        {
            bool changed = false;
            
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        changed = true;
                        (array[i + 1], array[i]) = (array[i], array[i + 1]);
                    }
                } 

            return changed;
        }
        #endregion 

        static bool BubbleSortOnePass(int[] array)
        {
            //iterate pair by pair
            //first pair: (0 and 1)
            //last pair: (length-2 and length-1)
            //therefore i should start at 0 and stop before length-1

            //returns true if the array was modified (it wasnt sorted when we started the pass)

            bool changed = false;

            for(int i = 0; i < array.Length - 1; i++)
            {
                
                if(array[i] > array[i + 1])
                {
                    changed = true;
                    int swap = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = swap;
                }
            }
            return changed;

        }

        static void BubbleSort(int[] array)
        {
            bool changed = BubbleSortOnePass(array);
            while (changed)
            {
                changed = BubbleSortOnePass(array);
            }
        }


        // 1. divide the whole array into half (left and right)
        // 2. divide each of these sections in half until each section is down to 1 value (start with 1x8 > 2x4 > 4x2 > 8x1)
        // 3. once you get down to sets of 2, compare the 2 arrays and set the lower one to the left
        // 4. after these lower comparisons are organized, go up step by step comparing the values within starting at the left of each one only filling in the smallest value between the two 

        static void MergeSort(int[] array)
        {
            // base case, if size 0 or 1, stop here, it is already sorted
            if(array.Length < 2)
            {
                return;
            }

            // recursive case
            int middle = array.Length / 2;

            int[] left = SubArray(array, 0, middle);
            int[] right = SubArray(array, middle, array.Length);

            MergeSort(left);
            MergeSort(right);

            //combine them...
            int l = 0;
            int r = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //if we have reached the end of one of the arrays....
                if(l >= left.Length)
                {
                    array[i] = right[r];
                    r++;
                }
                else if(r >= right.Length)
                {
                    array[i] = left[l];
                    l++;
                }

                // if we havent reached the end....               
                else if (left[l] <= right[r])
                {
                    array[i] = left[l];
                    l++;
                }
                else
                {
                    array[i] = right[r];
                    r++;
                }
            }
        }

        static int[] SubArray(int[] array, int start, int end)
        {
            int length = end - start;
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = array[start + i];
            }
            return result;
        }

    }
}
