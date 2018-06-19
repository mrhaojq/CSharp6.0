using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSorter
{
    class BubbleSorter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">可遍历的数据集合</typeparam>
        /// <param name="sortArray"></param>
        /// <param name="comparison">委托 用于传递对应于T的具体比较算法</param>
        static public void Sort<T>(IList<T> sortArray, Func<T, T, bool> comparison)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Count - 1; i++)
                {
                    if (comparison(sortArray[i + 1], sortArray[i]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i+1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
    }
}
