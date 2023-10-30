using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {//
            //TODO: write code for the ternary search algorithm and return the index of the element
            int mid1 = start + (end - start) / 3;
            int mid2 = end - (end - start) / 3;

            if (arr[mid1] == key)
            {
                return mid1;
            }
            if (arr[mid2] == key)
            {
                return mid2;
            }
            if (start > end)
            {
                return -1;
            }
            if (arr[mid1] > key)
            {
                return TernarySearch(arr, key, start, mid1 - 1);
            }
            if (arr[mid2] < key)
            {
                return TernarySearch(arr, key, mid2 + 1, end);
            }
            else { return TernarySearch(arr, key, mid1 + 1, mid2 - 1); }


        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            //int first = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length);
            //int last = BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length);
            int count_num = 0;
            int mid = start + (end - start) / 2;
            if (start > end)
            {
                return -1;
            }
            if (arr[mid] != key)
            {
                return BinarySearchForCalculatingRepeated(arr, key, false, start, mid - 1);
            }
            if (arr[mid] == key)
            {

                for (int i = start; i <= end; i++)
                {
                    if (arr[i] == key)
                    {
                        count_num = count_num + 1;
                    }

                }
                return count_num;
            }
            return count_num;
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method

            int k = 0;


            for (int i = 0; i <= arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    k = BinarySearchForCalculatingRepeated(arr, key, true, i, arr.Length);
                    return k;
                }
            }
            //**********************************************************************************************************
            //this is easy way
            //int count = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]==key)
            //    {
            //        count =count+1;
            //    }
            //}
            //return count;
            return k;
        }
    }
}
