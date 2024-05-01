using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using NAudio.Wave;
using Timer = System.Windows.Forms.Timer;

namespace SpeakingChatbot
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Form1 mainForm = new Form1();
            AudioDetector audioDetector = new AudioDetector();
            Task.Run(() =>
            {
                audioDetector.SoundDetected += (sender, message) =>
                {
                    VoiceDetected.HandleVoice(mainForm, message);
                };

                // audioDetector.AnalyzeAudio("C:\\Users\\foagr\\Downloads\\ElevenLabs_2024-04-16T05_27_35_Daniel.mp3");

                audioDetector.Dispose();
            });
            Application.Run(mainForm);
        }
    }
}