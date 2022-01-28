using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace GetActivityIdeas
{
    public static class FetchActivities
    {
        public static async Task<Activity> Fetch()
        {
            Activity newAct = new Activity();
            try
            {
                Stream res = await Program.wrClient.GetStreamAsync("https://www.boredapi.com/api/activity");
                JsonNode parsed = JsonNode.Parse(res);

                newAct.name = parsed["activity"].ToString();
                newAct.type = parsed["type"].ToString();
                newAct.participants = (int)parsed["participants"];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return newAct;
        }
    }

    public class Activity
    {
        public string name = "";
        public string type = "";
        public int participants = 0;
    }
}
