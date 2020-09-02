using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace XamarinInglesCriancas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageCores : ContentPage
    {
        

        public PageCores()
        {
            InitializeComponent();            
        }      

        public void OnVoiceBlack(object sender, EventArgs e)
        {
            var configuracoesAudio = new SpeechOptions() { Volume = 1.0f, Pitch = 2.0f };
            TextToSpeech.SpeakAsync("Black", configuracoesAudio);
        }

        public void OnVoiceBrown(object sender, EventArgs e)
        {
            var configuracoesAudio = new SpeechOptions() { Volume = 1.0f, Pitch = 2.0f };
            TextToSpeech.SpeakAsync("Brown", configuracoesAudio);
        }

        public void OnVoiceGray(object sender, EventArgs e)
        {
            var configuracoesAudio = new SpeechOptions() { Volume = 1.0f, Pitch = 2.0f };
            TextToSpeech.SpeakAsync("Gray", configuracoesAudio);
        }

        public void OnVoiceGreen(object sender, EventArgs e)
        {
            var configuracoesAudio = new SpeechOptions() { Volume = 1.0f, Pitch = 2.0f };
            TextToSpeech.SpeakAsync("Green", configuracoesAudio);
        }

        public void OnVoiceYellow(object sender, EventArgs e)
        {
            var configuracoesAudio = new SpeechOptions() { Volume = 1.0f, Pitch = 2.0f };
            TextToSpeech.SpeakAsync("Yellow", configuracoesAudio);
        }

        public void OnVoiceRed(object sender, EventArgs e)
        {
            var configuracoesAudio = new SpeechOptions() { Volume = 1.0f, Pitch = 2.0f };
            TextToSpeech.SpeakAsync("Red", configuracoesAudio);
        }

        public void OnVoiceWhite(object sender, EventArgs e)
        {
            var configuracoesAudio = new SpeechOptions() { Volume = 1.0f, Pitch = 2.0f };
            TextToSpeech.SpeakAsync("White", configuracoesAudio);
        }

        public void OnVoiceBlue(object sender, EventArgs e)
        {
            var configuracoesAudio = new SpeechOptions() { Volume = 1.0f, Pitch = 2.0f };
            TextToSpeech.SpeakAsync("Blue", configuracoesAudio);
        }

    }
}