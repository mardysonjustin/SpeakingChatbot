using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;


namespace SpeakingChatbot
{
    internal class VoiceDetected
    {
        public static void HandleVoice(Form1 mainForm, string message, string audioFile, string firstWord, string words)
        {
            Console.WriteLine(message);

            if (message == "Voice detected!" && firstWord == words)
            {
                Image detectedImage = Image.FromFile("C:\\Users\\foagr\\source\\repos\\MukaKoJPG\\MukaKoJPG\\assets\\IMG_20240415_195609_317.jpg");
                mainForm.SetPictureBoxImage(detectedImage);

                try
                {
                    using (var waveOut = new WaveOutEvent())
                    {
                        using (var mp3Reader = new Mp3FileReader(audioFile))
                        {
                            waveOut.Init(mp3Reader);
                            waveOut.Play();
                            int remainingTime = (int)(mp3Reader.TotalTime.TotalMilliseconds);

                            Timer timer = new Timer();
                            timer.Interval = remainingTime;
                            timer.Tick += (s, e) =>
                            {
                                Image originalImage = Image.FromFile("C:\\Users\\foagr\\source\\repos\\SpeakingChatbot\\SpeakingChatbot\\assets\\IMG_20240415_195608_239.jpg");
                                mainForm.SetPictureBoxImage(originalImage);
                                timer.Stop();
                            };
                            timer.Start();

                            while (waveOut.PlaybackState == PlaybackState.Playing)
                            {
                                Application.DoEvents();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
            else
            {
                Image originalImage = Image.FromFile("C:\\Users\\foagr\\source\\repos\\SpeakingChatbot\\SpeakingChatbot\\assets\\IMG_20240415_195608_239.jpg");
                mainForm.SetPictureBoxImage(originalImage);
            }

        }
    }            
}
