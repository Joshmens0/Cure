using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media.Animation;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Images;
using OpenAI_API.Models;
namespace Cure_WPF
{
    internal class Openai
    {
        public static string apikey = "sk-proj-bPKdFDTZEuH3PEIp7BvcT3BlbkFJYKHBaYQfbnqCdaiMu7XG";
        public static OpenAIAPI openai = new OpenAIAPI(apikey);
        public static OpenAI_API.Chat.Conversation chatgpt = openai.Chat.CreateConversation();
        public string SystemMessage { get; set; }
        public string UserRequest {  get; set; }
        public async Task<string> MakeRequest()
        {
            chatgpt.Model=Model.ChatGPTTurbo_1106;
            chatgpt.AppendSystemMessage(SystemMessage);
            chatgpt.AppendUserInput(UserRequest);
            var respond=await chatgpt.GetResponseFromChatbotAsync();
            return respond;
        }
        
       
    }
}
