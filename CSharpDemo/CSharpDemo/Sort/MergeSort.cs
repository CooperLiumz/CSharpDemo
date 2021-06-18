using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Sort
{
    /// <summary>
    /// 归并排序
    /// 
    /// 归并排序算法有两个基本的操作，
    /// 一个是分，也就是把原数组划分成两个子数组的过程。
    /// 另一个是治，它将两个有序数组合并成一个更大的有序数组。 
    /// 它将数组平均分成两部分: center = (left + right)/2，
    /// 当数组分得足够小时---数组中只有一个元素时，只有一个元素的数组自然而然地就可以视为是有序的
    /// 此时就可以进行合并操作了。因此，上面讲的合并两个有序的子数组，
    /// 是从 只有一个元素 的两个子数组开始合并的
    /// </summary>
    class MergeSort
    {
        public void Sort (int[] arry , int left , int right)
        {
            if (left < right)
            {
                int mid = ( left + right ) / 2;
                
                // 排左边
                Sort (arry , left , mid);

                // 排右边
                Sort (arry , mid + 1 , right);

                // 合并
                MergeMethid (arry , left , mid , right);
            }
        }
        private void MergeMethid (int[] arry , int inLeft , int inMid , int inRight)
        {
            int[] temp = new int[inRight - inLeft + 1];

            int _left = inLeft;
            int _mid = inMid + 1;
            int _idx = 0;

            // 将两个有序数组合并到临时数组里
            while (_left <= inMid && _mid <= inRight)
            {
                if (arry[_left] > arry[_mid])
                {
                    temp[_idx] = arry[_mid];
                    _mid++;
                }
                else
                {
                    temp[_idx] = arry[_left];
                    _left++;
                }
                _idx++;
            }

            // 将剩的数合并到临时数组里
            // 只会走一个
            while (_mid < inRight + 1)
            {
                temp[_idx] = arry[_mid];
                _idx++;
                _mid++;
            }
            while (_left < inMid + 1)
            {
                temp[_idx] = arry[_left];
                _idx++;
                _left++;
            }            

            // 将临时数据合并到原始数组里
            for (_idx = 0, _left = inLeft; _left < inRight + 1; _idx++, _left++)
            {

                arry[_left] = temp[_idx];
            }
        }
    }
}
