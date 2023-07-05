using SlackAPI;
using job_coaching_blazor_server.Data;
using Newtonsoft.Json;

namespace job_coaching_blazor_server.Services
{
    public class SlackAPICalls
    {
        string channel = "C01M62SGTL6"; // Replace with your desired channel ID
        string token = Secrets.token; // Replace with your bot's access token
        string url = "https://slack.com/api/chat.postMessage";
        string url2 = "https://slack.com/api/reactions.add";



        public static IBlock[] SomeBlocks(string _text)
        {
            IBlock[] iblocks = new IBlock[]
            {
                new ContextBlock
                {
                    elements = new IElement[]{
                        new Text
                        {
                            type = TextTypes.Markdown,
                            text = "Someone asks for your help!"

                        }
                    }
                },
                new SectionBlock
                {
                    text = new Text
                    {
                        type = TextTypes.Markdown,
                        text = _text
                    },
                },
            };
            return iblocks;
        }

        public async Task<PostMessageResponse> MakePost(string channelID, string text)
        {
            var slackClient = new SlackTaskClient(token);

            return await slackClient.PostMessageAsync(channelID, string.Empty, blocks: SomeBlocks(text));
        }

        public async void DeletePost(string channelId, DateTime ts)
        {
            var slackClient = new SlackTaskClient(token);

            DeletedResponse deleteResponse = await slackClient.DeleteMessageAsync(channelId, ts);
            Console.WriteLine(JsonConvert.SerializeObject(deleteResponse, Formatting.Indented));
        }

    }
}
