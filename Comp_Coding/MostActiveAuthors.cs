using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Comp_Coding
{
    class MostActiveAuthors
    {
       
        public static List<string> getUsernames(int threshold)
        {
           
            List<string> result = new List<string>();
            FetchData(result, threshold);

            return result;
        }


        public static void FetchData(List<string> list, int threshold)
        {
            int pageNumber = 1;
            
            var client = new HttpClient();
            while (true)
            {
                string url = $"https://jsonmock.hackerrank.com/api/article_users?page={pageNumber}";
                var response = client.GetAsync(url).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode && response != null)
                {
                    var body = response.Content.ReadAsStringAsync().GetAwaiter();

                    var result = JsonConvert.DeserializeObject<Response>(body.GetResult());

                    var newList = filter(result, threshold);
                    list.AddRange(newList);

                    if (result.Data.Count == 0)
                        break;
                }
               
                pageNumber++;
            }


        }

        public static List<string> filter(Response res, int threshold)
        {
            var listOfData = res.Data;

            List<string> filterList = new List<string>();

            foreach(var item in listOfData)
            {
                if (item.SubmissionCount > threshold)
                    filterList.Add(item.UserName);
            }

            return filterList;
        }

        public class Response
        {
            [JsonProperty("data")]
            public ICollection<Data> Data {get; set;}
        }

        public class Data
        {
            [JsonProperty("username")]
            public string UserName { get; set; }

            [JsonProperty("submission_count")]
            public int SubmissionCount { get; set; }
        }
    }
   
}
