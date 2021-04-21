using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    public class LogSystem
    {
        Dictionary<string, List<int>> year_granular;
        Dictionary<string, List<int>> month_granular;
        Dictionary<string, List<int>> day_granular;
        Dictionary<string, List<int>> hour_granular;
        Dictionary<string, List<int>> minute_granular;
        Dictionary<string, List<int>> second_granular;
        public LogSystem()
        {
            year_granular = new Dictionary<string, List<int>>();
            month_granular = new Dictionary<string, List<int>>();
            day_granular = new Dictionary<string, List<int>>();
            hour_granular = new Dictionary<string, List<int>>();
            minute_granular = new Dictionary<string, List<int>>();
            second_granular = new Dictionary<string, List<int>>();
        }

        public void Put(int id, string timestamp)
        {
            string[] partitioned = timestamp.Split(":");
            int n = partitioned.Length;
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < n; i++)
            {
                switch(i)
                {
                    case 0:
                        sb.Append(partitioned[i]);
                        string s = sb.ToString();
                        if (year_granular.ContainsKey(s))
                        {
                            year_granular[s].Add(id);
                        }
                        else
                        {
                            year_granular.Add(s, new List<int>() { id });
                        }
                        break;

                    case 1:
                        sb.Append(":");
                        sb.Append(partitioned[i]);
                        s = sb.ToString();
                        if (month_granular.ContainsKey(s))
                        {
                            month_granular[s].Add(id);
                        }
                        else
                        {
                            month_granular.Add(s, new List<int>() { id });
                        }
                        break;
                    case 2:
                        sb.Append(":");
                        sb.Append(partitioned[i]);
                        s = sb.ToString();
                        if (day_granular.ContainsKey(s))
                        {
                            day_granular[s].Add(id);
                        }
                        else
                        {
                            day_granular.Add(s, new List<int>() { id });
                        }
                        break;
                    case 3:
                        sb.Append(":");
                        sb.Append(partitioned[i]);
                        s = sb.ToString();
                        if (hour_granular.ContainsKey(s))
                        {
                            hour_granular[s].Add(id);
                        }
                        else
                        {
                            hour_granular.Add(s, new List<int>() { id });
                        }
                        break;
                    case 4:
                        sb.Append(":");
                        sb.Append(partitioned[i]);
                        s = sb.ToString();
                        if (minute_granular.ContainsKey(s))
                        {
                            minute_granular[s].Add(id);
                        }
                        else
                        {
                            minute_granular.Add(s, new List<int>() { id });
                        }
                        break;
                    case 5:
                        sb.Append(":");
                        sb.Append(partitioned[i]);
                        s = sb.ToString();
                        if (second_granular.ContainsKey(s))
                        {
                            second_granular[s].Add(id);
                        }
                        else
                        {
                            second_granular.Add(s, new List<int>() { id });
                        }
                        break;
                        
                    default:
                        break;
                }

            }
            
        }

        public IList<int> Retrieve(string start, string end, string granularity)
        {
            IList<int> result = new List<int>();

            switch(granularity)
            {
                case "Year":
                    start = start.Substring(0, 4);
                    end = end.Substring(0, 4);
                    foreach (string key in year_granular.Keys)
                    {    
                        if((key.CompareTo(start) == 0 || key.CompareTo(start) == 1) && (key.CompareTo(end) == -1) || (key.CompareTo(end) == 0))
                        {
                            foreach (int id in year_granular[key])
                                result.Add(id);
                        }
                    }
                    break;
                case "Month":
                    start = start.Substring(0, 7);
                    end = end.Substring(0, 7);
                    foreach (string key in month_granular.Keys)
                    {
                        if ((key.CompareTo(start) == 1 || key.CompareTo(start) == 0) && (key.CompareTo(end) == -1) || (key.CompareTo(end) == 0))
                        {
                            foreach (int id in month_granular[key])
                                result.Add(id);
                        }
                    }
                    break;
                case "Day":
                    start = start.Substring(0, 10);
                    end = end.Substring(0, 10);
                    foreach (string key in day_granular.Keys)
                    {
                        if ((key.CompareTo(start) == 1 || key.CompareTo(start) == 0) && (key.CompareTo(end) == -1) || (key.CompareTo(end) == 0))
                        {
                            foreach (int id in day_granular[key])
                                result.Add(id);
                        }
                    }
                    break;
                case "Hour":
                    start = start.Substring(0, 13);
                    end = end.Substring(0, 13);
                    foreach (string key in hour_granular.Keys)
                    {
                        if ((key.CompareTo(start) == 1 || key.CompareTo(start) == 0) && (key.CompareTo(end) == -1) || (key.CompareTo(end) == 0))
                        {
                            foreach (int id in hour_granular[key])
                                result.Add(id);
                        }
                    }
                    break;
                case "Minute":
                    start = start.Substring(0, 16);
                    end = end.Substring(0, 16);
                    foreach (string key in minute_granular.Keys)
                    {
                        if ((key.CompareTo(start) == 1 || key.CompareTo(start) == 0) && (key.CompareTo(end) == -1) || (key.CompareTo(end) == 0))
                        {
                            foreach (int id in minute_granular[key])
                                result.Add(id);
                        }
                    }
                    break;
                case "Second":
                    start = start.Substring(0, 19);
                    end = end.Substring(0, 19);
                    foreach (string key in second_granular.Keys)
                    {
                        if ((key.CompareTo(start) == 1 || key.CompareTo(start) == 0) && (key.CompareTo(end) == -1) || (key.CompareTo(end) == 0))
                        {
                            foreach (int id in second_granular[key])
                                result.Add(id);
                        }
                    }
                    break;
            }
            return result;
        }
    }
}
