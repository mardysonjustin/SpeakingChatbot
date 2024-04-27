using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using NAudio.Wave;
using NAudio.Lame;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;
using Timer = System.Windows.Forms.Timer;
using SpeakingChatbot;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Form1 mainForm = new Form1();
        AudioDetector audioDetector = new AudioDetector();

        mainForm.UserInputEntered += (sender, userInput) =>
        {
            string wavFilePath = @"C:\Users\foagr\source\repos\SpeakingChatbot\SpeakingChatbot\assets\" + userInput + ".wav";
            SynthesizeTextToSpeech(userInput, wavFilePath);

            string mp3FilePath = @"C:\Users\foagr\source\repos\SpeakingChatbot\SpeakingChatbot\assets\" + userInput + ".mp3";
            Converter.ConvertWavToMp3(wavFilePath, mp3FilePath);

            Task.Run(() =>
            {
                audioDetector.SoundDetected += (sender, message) =>
                {
                    VoiceDetected.HandleVoice(mainForm, message, mp3FilePath);
                };

                audioDetector.AnalyzeAudio(mp3FilePath, mainForm);

                File.Delete(wavFilePath);
                File.Delete(mp3FilePath);
                audioDetector.Dispose();
            });
        };

        Application.Run(mainForm);
    }

    static void SynthesizeTextToSpeech(string text, string filePath)
    {
        using (SpeechSynthesizer synth = new SpeechSynthesizer())
        {
            synth.SetOutputToWaveFile(filePath, new SpeechAudioFormatInfo(32000, AudioBitsPerSample.Sixteen, AudioChannel.Mono));
            PromptBuilder builder = new PromptBuilder();
            builder.AppendText(text);
            synth.Speak(builder);
        }
    }
}
