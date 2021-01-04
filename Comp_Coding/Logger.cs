using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Logger
    {
        Dictionary<string, int> message_map;
        /** Initialize your data structure here. */
        public Logger()
        {
            message_map = new Dictionary<string, int>();
        }

        /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
            If this method returns false, the message will not be printed.
            The timestamp is in seconds granularity. */
        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (message_map.ContainsKey(message))
            {
                if (timestamp - message_map[message] >= 10)
                {
                    message_map[message] = timestamp;
                    return true;
                }

                else
                    return false;
            }
            else
            {
                message_map.Add(message, timestamp);
                return true;
            }
        }
    }
}
