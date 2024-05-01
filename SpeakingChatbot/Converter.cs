using NAudio.Lame;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeakingChatbot
{
    internal class Converter
    {
        public static void ConvertWavToMp3(string wavFilePath, string mp3FilePath)
        {
            using (var reader = new WaveFileReader(wavFilePath))
            {
                using (var writer = new LameMP3FileWriter(mp3FilePath, reader.WaveFormat, 128))
                {
                    reader.CopyTo(writer);
                }
            }
        }
    }
}
