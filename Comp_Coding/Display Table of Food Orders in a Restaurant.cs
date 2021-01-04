using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp_Coding
{
    class Display_Table_of_Food_Orders_in_a_Restaurant
    {
        public IList<IList<string>> DisplayTable(IList<IList<string>> orders)
        {
            SortedDictionary<int, List<string>> table_orders = new SortedDictionary<int, List<string>>();
            SortedSet<string> items = new SortedSet<String>(StringComparer.Ordinal);
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (IList<string> lst in orders)
            {
                if (table_orders.ContainsKey(Convert.ToInt32(lst[1])))
                {
                    table_orders[Convert.ToInt32(lst[1])].Add(lst[2]);
                }

                else
                {
                    table_orders.Add(Convert.ToInt32(lst[1]), new List<string>() { lst[2] });
                }

                items.Add(lst[2]);
            }

            IEnumerator<string> enumerator = items.GetEnumerator();
            int count = 1;
            List<string> column = new List<string>();
            column.Add("Table");
            while(enumerator.MoveNext())
            {
                map.Add(enumerator.Current, count);
                count += 1;
                column.Add(enumerator.Current);
            }

            IList<IList<string>> result = new List<IList<string>>();
            result.Add(column);
            int n = column.Count;
            foreach(int key in table_orders.Keys)
            {
                string[] temp = new string[n];
                Array.Fill(temp, "0");
                temp[0] = Convert.ToString(key);

                foreach(string item in table_orders[key])
                {
                    int val = Convert.ToInt32(temp[map[item]]);
                    val += 1;
                    temp[map[item]] = Convert.ToString(val);
                }
                List<string> mid = temp.ToList();
                result.Add(mid);
            }

            return result;
        }
    }
}
