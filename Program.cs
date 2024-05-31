using System;

namespace ElementFrequencyCounter
{
    class Program
    {
        static Dictionary<int, int> _selectionCount = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            int[] elementsArray = { 10, 12, 13, 12, 10 };

            foreach (int e in elementsArray)
            {
                AddElements(e);
            }

            foreach (KeyValuePair<int, int> pair in _selectionCount)
            {
                Console.WriteLine(format: "{0} occurs {1} times", pair.Key, pair.Value);
            }

        }

        static public void AddElement(int element)
        {
            if (_selectionCount.ContainsKey(element))
            {
                _selectionCount[element]++;
            }
            else
            {
                _selectionCount.Add(element, 1);
            }
        }
    }
}
        
                    
