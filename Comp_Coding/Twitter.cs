using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Comp_Coding
{
    public class Twitter
    {
        /** Initialize your data structure here. */

        Dictionary<int, List<(int,int)>> userid_tweetid_map;
        Dictionary<int, HashSet<int>> user_id_followerids;
        int timestamp;
        public Twitter()
        {
            userid_tweetid_map = new Dictionary<int, List<(int,int)>>();
            user_id_followerids = new Dictionary<int, HashSet<int>>();
            timestamp = 0;
        }

        /** Compose a new tweet. */
        public void PostTweet(int userId, int tweetId)
        {
            timestamp += 1;
            if(userid_tweetid_map.ContainsKey(userId))
            {
                userid_tweetid_map[userId].Insert(0,(tweetId,timestamp));
            }
            else
            {
                userid_tweetid_map.Add(userId, new List<(int,int)>() { (tweetId, timestamp) });
            }

            foreach(int key in user_id_followerids.Keys)
            {
                if(userId != key)
                {
                    if (user_id_followerids[key].Contains(userId))
                    {
                        if (userid_tweetid_map.ContainsKey(key))
                        {
                            userid_tweetid_map[key].Insert(0, (tweetId, timestamp));
                        }
                        else
                        {
                            userid_tweetid_map.Add(key, new List<(int, int)>() { (tweetId, timestamp) });
                        }
                    }
                }
                
            }

        }

        /** Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent. */
        public IList<int> GetNewsFeed(int userId)
        {
            if(userid_tweetid_map.ContainsKey(userId))
            {
                IList<(int,int)> list = userid_tweetid_map[userId].Take(Math.Min(10, userid_tweetid_map[userId].Count)).ToList();
                List<int> result = new List<int>();
                foreach((int,int) item in list)
                {
                    result.Add(item.Item1);
                }
                return result;
            }
            else
            {
                return new List<int>();
            }
        }

        /** Follower follows a followee. If the operation is invalid, it should be a no-op. */
        public void Follow(int followerId, int followeeId)
        {
            bool already_follows = false;
            if(followerId != followeeId)
            {
                if (user_id_followerids.ContainsKey(followerId))
                {
                    if(!user_id_followerids[followerId].Contains(followeeId))
                    {
                        user_id_followerids[followerId].Add(followeeId);
                    }
                    else
                    {
                        already_follows = true;
                    }
                }
                else
                {
                    user_id_followerids.Add(followerId, new HashSet<int>() { followeeId });
                }

                if (userid_tweetid_map.ContainsKey(followeeId) && !already_follows)
                {
                    if (userid_tweetid_map.ContainsKey(followerId))
                    {
                        List<(int, int)> follower = userid_tweetid_map[followerId].Take(Math.Min(10, userid_tweetid_map[followerId].Count)).ToList();
                        List<(int, int)> followee = userid_tweetid_map[followeeId].Take(Math.Min(10, userid_tweetid_map[followeeId].Count)).ToList();
                        follower = merge_lists(follower, followee);
                        userid_tweetid_map[followerId] = follower;
                    }
                    else
                    {
                        var new_list = userid_tweetid_map[followeeId].ToList();
                        userid_tweetid_map.Add(followerId, new_list);
                    }
                }
            }
        }

        /** Follower unfollows a followee. If the operation is invalid, it should be a no-op. */
        public void Unfollow(int followerId, int followeeId)
        {
            if(followerId != followeeId)
            {
                if (user_id_followerids.ContainsKey(followerId))
                {
                    if (user_id_followerids[followerId].Contains(followeeId))
                    {
                        user_id_followerids[followerId].Remove(followeeId);

                        if (userid_tweetid_map.ContainsKey(followeeId))
                        {
                            if (userid_tweetid_map.ContainsKey(followerId))
                            {
                                var list_of_tweets = userid_tweetid_map[followeeId];
                                var follower_list = userid_tweetid_map[followerId];
                                follower_list = remove_tweets(follower_list, list_of_tweets);
                                userid_tweetid_map[followerId] = follower_list;
                            }
                        }
                    }
                }
            }
        }

        public List<(int,int)> remove_tweets(List<(int, int)> follower, List<(int, int)> followee)
        {
            foreach(var pair in followee)
            {
                follower.Remove(pair);
            }
            return follower;
        }

        public List<(int,int)> merge_lists(List<(int,int)> follower, List<(int,int)> followee)
        {
            int l1 = follower.Count(); int l2 = followee.Count(); int count = 0; int limit = 10;
            int start1 = 0; int start2 = 0;
            while(start1< l1 && start2 < l2 && count < limit)
            {
                if(followee[start2].Item2 > follower[start1].Item2)
                {
                    follower.Insert(start1, followee[start2]);
                    start2++; start1++;
                }
                else
                {
                    start1++;
                }
                count++;
            }

            while(count < limit && start2 < l2)
            {
                follower.Add(followee[start2]);
                start2++; count++;

            }

            return follower;
        }
    }
}
