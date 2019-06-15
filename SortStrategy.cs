using System.Collections.Generic;

namespace B19_Ex01_Matan_311116313_Moshe_305097453
{
    public class SortStrategy<T>
    {
        //private orderByStrategy<T> m_strategy;
        public delegate bool CompereElements(T i_first, T i_second);
        public CompereElements elementsComperer;

        public List<T> Sort(List<T> i_list)
        {
            if (elementsComperer == null)
            {
                return i_list;
            }
            if (i_list.Count <= 1)
                return i_list;
            List<T> left = new List<T>();
            List<T> right = new List<T>();

            int middle = i_list.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(i_list[i]);
            }
            for (int i = middle; i < i_list.Count; i++)
            {
                right.Add(i_list[i]);
            }

            left = Sort(left);
            right = Sort(right);
            return Merge(left, right);
        }

        public void SetComperElements(CompereElements i_comperer)
        {
            elementsComperer = i_comperer;
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            List<T> result = new List<T>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (elementsComperer(left[0], right[0]))  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left[0]);
                        left.Remove(left[0]);      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right[0]);
                        right.Remove(right[0]);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left[0]);
                    left.Remove(left[0]);
                }
                else if (right.Count > 0)
                {
                    result.Add(right[0]);

                    right.Remove(right[0]);
                }
            }
            return result;
        }
    }
}