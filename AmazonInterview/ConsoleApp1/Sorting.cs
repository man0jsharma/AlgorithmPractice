using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmzMain
{
    public class Sorting
    {
        public List<int> SimpleSorting(List<int> list)
        {
            for (var i = 0; i < list.Count; i++)
            {
                for (var j = 0; j < list.Count; j++)
                {
                    if (list.ElementAt(i) < list.ElementAt(j))
                    {
                        var temp = list.ElementAt(j);
                        list[j] = list.ElementAt(i);
                        list[i] = temp;
                    }
                }
            }
            return list;
        }

        public void QuickSort(List<int> list, int start, int end)
        {

            var pIndex = Partition(list, start, end);
            if (start < pIndex - 1)
                QuickSort(list, start, pIndex - 1);
            if (pIndex < end)
                QuickSort(list, pIndex, end);
            //return list;
        }

        private int Partition(List<int> list, int start, int end)
        {
            var pivot = (start + end) / 2;

            while (start <= end)
            {

                while (list[start] < list[pivot]) start++;

                while (list[end] > list[pivot]) end--;

                if (start <= end)
                {
                    var temp = list[start];
                    list[start] = list[end];
                    list[end] = temp;
                    start++;
                    end--;

                }
            }
            return start;
        }

        public void MergeTwoSortedArray(List<int> A, List<int> B)
        {
            foreach(int b in B.ToList())
            {
                foreach(int a in A.ToList())
                {
                    if(b <= a)
                    {
                        A.Insert(A.IndexOf(a) , b);
                        break;
                    }
                }
            }
        }
    }
}
