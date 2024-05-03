using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace YourNamespace
{
    public class OpenAIIntegration
    {
        private readonly OpenAIService _service;

        public OpenAIIntegration(string apiKey)
        {
            _service = new OpenAIService(new OpenAiOptions
            {
                ApiKey = apiKey
            });
            _service.SetDefaultModelId(Models.ChatGpt3_5Turbo);
        }

        public async Task<string> GetResponseAsync(List<ChatMessage> messages)
        {
            var req = new ChatCompletionCreateRequest
            {
                Messages = messages,
                N = 1
            };

            var res = await _service.ChatCompletion.CreateCompletion(req);

            if (res.Successful)
            {
                return res.Choices.First().Message.Content;
            }
            else
            {
                return "Failed to get response from OpenAI API.";
            }
        }
    }
}
