using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HighestPairCard
{
    public class HighestCard :IHighestCard
    {
        public dynamic highestPair(string[] card)
        {
            Dictionary<string, int> DicPairCount = new Dictionary<string, int>();
            foreach (var item in card)
            {
                if (!DicPairCount.ContainsKey(item))
                {
                    DicPairCount.Add(item, 1);
                }
                else
                    DicPairCount[item]++;
            }
            var maxValue = DicPairCount.Max(x => x.Value);
            var keyOfMaxValue = DicPairCount.OrderByDescending(x => x.Value).First().Key;
            if (maxValue > 1)
            {
                Dictionary<bool, string> result = new Dictionary<bool, string>();
                result.Add(true, keyOfMaxValue);
                return result;
            }
            else return false;
        }
    }
}
