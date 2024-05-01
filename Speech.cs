using Cure_WPF;
using OpenAI_API;
using OpenAI_API.Audio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Resources;

namespace Cure_2._0
{
    internal class Speech:Openai
    {
        public string Text { get; set; }
        public async Task GetSpeech() 
        {
            var location = new Uri(@"/audio.wav");
            var makeFile=File.Create(location.ToString());
            TextToSpeechRequest request = new TextToSpeechRequest() { Voice="alloy",Input=Text};
            var audioFile =await openai.TextToSpeech.SaveSpeechToFileAsync(request,makeFile.Name);
            audioFile.Create();
            
        }
    }
}
