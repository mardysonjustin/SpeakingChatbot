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
        public static void HandleVoice(Form1 mainForm, string message)
        {
            Console.WriteLine(message);

            if (message == "Voice detected!")
            {
                Image detectedImage = Image.FromFile("C:\\Users\\foagr\\source\\repos\\MukaKoJPG\\MukaKoJPG\\assets\\IMG_20240415_195609_317.jpg");
                mainForm.SetPictureBoxImage(detectedImage);

                try
                {
                    using (var waveOut = new WaveOutEvent())
                    {
                        using (var mp3Reader = new Mp3FileReader("C:\\Users\\foagr\\Downloads\\ElevenLabs_2024-04-16T05_27_35_Daniel.mp3"))
                        {
                            waveOut.Init(mp3Reader);
                            waveOut.Play();

                            // Calculate the time to change the image
                            int remainingTime = (int)(mp3Reader.TotalTime.TotalMilliseconds - 400); // 1 second before the end

                            // Set a timer to change the image 1 second before the audio ends
                            Timer timer = new Timer();
                            timer.Interval = remainingTime;
                            timer.Tick += (s, e) =>
                            {
                                // Load and set the original image
                                Image originalImage = Image.FromFile("C:\\Users\\foagr\\source\\repos\\SpeakingChatbot\\SpeakingChatbot\\assets\\IMG_20240415_195608_239.jpg");
                                mainForm.SetPictureBoxImage(originalImage);
                            };
                            timer.Start();

                            while (waveOut.PlaybackState == PlaybackState.Playing)
                            {
                                Application.DoEvents();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error playing audio: " + ex.Message);
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
