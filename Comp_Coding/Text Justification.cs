using System;
using System.Collections.Generic;
using System.Text;

namespace Comp_Coding
{
    class Text_Justification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            IList<string> result = new List<string>();

            int current_width = maxWidth;
            int n = words.Length;
            StringBuilder sb = new StringBuilder();

            int start = 0;

            Queue<string> queue = new Queue<string>();

            while(start < n)
            {
                int len = words[start].Length;

                if (start == n - 1)
                {
                    //check if the last word can be fit in the space or needs a  new line
                    if(len <= current_width && queue.Count > 0)
                    {
                        var rem_space = current_width - len;
                        var extra_spaces = queue.Count % rem_space;
                        var right_Spaces = rem_space + extra_spaces;

                        while (queue.Count > 0)
                        {
                            sb.Append(queue.Dequeue());
                            for(int i =0; i <= right_Spaces; i++)
                            {
                                sb.Append(" ");
                            }
                        }
                        sb.Append(words[start]);
                        result.Add(sb.ToString());
                    }
                    //else it has to be fit in a new line
                    else
                    {
                        if(len > current_width && queue.Count > 0)
                        {
                            var spaces = queue.Count / current_width;
                            var extra_spaces = queue.Count % current_width;
                            var right_Spaces = spaces + extra_spaces;

                            while (queue.Count > 1)
                            {
                                sb.Append(queue.Dequeue());
                                for (int i = 0; i <= right_Spaces; i++)
                                {
                                    sb.Append(" ");
                                }
                            }

                            var rem_space = maxWidth - (sb.Length + queue.Peek().Length);
                            while (rem_space > 0)
                            {
                                sb.Append(" ");
                                rem_space--;
                            }
                            sb.Append(queue.Dequeue());
                            result.Add(sb.ToString());

                            //reset sb
                            sb.Clear();

                            //reset current width
                            current_width = maxWidth;

                            //Add the last word
                            sb.Append(words[start]);
                            for (int i = 0; i <= current_width - len; i++)
                            {
                                sb.Append(" ");
                            }
                            
                            result.Add(sb.ToString());
                        }
                        else
                        {
                            sb.Append(words[start]);
                            for (int i = 0; i <= maxWidth - len; i++)
                            {
                                sb.Append(" ");
                            }
                           
                            result.Add(sb.ToString());
                            //Add it on a new line
                        }
                    }
                }

                else
                {
                    if (len + 1 < current_width)
                    {
                        queue.Enqueue(words[start]);
                        current_width -= len + 1;
                    }

                    else if (len == current_width)
                    {
                        //perfect fit on the line
                        while(queue.Count > 0)
                        {
                            sb.Append(queue.Dequeue());
                            sb.Append(" ");
                        }

                        sb.Append(words[start]);
                        result.Add(sb.ToString());
                        sb.Clear();
                        current_width = maxWidth;
                    }
                    else
                    {
                        //length of this word is greater than current_width.

                        //Need to adjust the remaining width as space in between the words.

                        var spaces = queue.Count / current_width;
                        var extra_spaces = queue.Count % current_width;
                        var right_Spaces = spaces + extra_spaces;

                        while(queue.Count > 1)
                        {
                            sb.Append(queue.Dequeue());
                            for (int i = 0; i <= right_Spaces; i++)
                            {
                                sb.Append(" ");
                            }
                        }

                        var rem_space = maxWidth - (sb.Length + queue.Peek().Length);
                        while(rem_space > 0)
                        {
                            sb.Append(" ");
                            rem_space--;
                        }
                        sb.Append(queue.Dequeue());
                        result.Add(sb.ToString());

                        //reset sb
                        sb.Clear();

                        //Enqueue this word
                        queue.Enqueue(words[start]);

                        //reset current width
                        current_width = maxWidth - len;
                    }
                }
                start++;
            }
            return result;
        }
    }
}
