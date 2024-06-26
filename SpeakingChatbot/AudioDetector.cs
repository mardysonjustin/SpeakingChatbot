﻿using System;
using NAudio.Wave;
using SpeakingChatbot;

public class AudioDetector : IDisposable
{
    private const int DefaultBufferSize = 16384;
    private const float DefaultSoundThreshold = 0.99999f;

    private readonly int bufferSize;
    private readonly float soundThreshold;
    private AudioFileReader audioFile;

    public event EventHandler<string> SoundDetected;

    public AudioDetector(int bufferSize = DefaultBufferSize, float soundThreshold = DefaultSoundThreshold)
    {
        this.bufferSize = bufferSize;
        this.soundThreshold = soundThreshold;
    }

    public void AnalyzeAudio(string audioFilePath, Form1 mainForm)
    {
        try
        {
            using (var audioFile = new AudioFileReader(audioFilePath))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                bool isSoundDetected = false;
                bool hasPrintedOhNo = false;

                while ((bytesRead = audioFile.Read(buffer, 0, buffer.Length)) > 0)
                {
                    float maxAmplitude = GetMaxAmplitude(buffer, bytesRead);
                    if (maxAmplitude > soundThreshold)
                    {
                        if (!isSoundDetected)
                        {
                            isSoundDetected = true;
                            hasPrintedOhNo = false;

                            OnSoundDetected("Voice detected!");
                        }
                    }
                    else
                    {
                        if (isSoundDetected && !hasPrintedOhNo)
                        {
                            OnSoundDetected("Oh no!");
                            hasPrintedOhNo = true;
                        }
                        isSoundDetected = false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error analyzing audio: {ex.Message}");
        }
    }

    private float GetMaxAmplitude(byte[] buffer, int bytesRead)
    {
        float maxAmplitude = 0;
        for (int i = 0; i < bytesRead / 2; i += 2)
        {
            short sample = (short)((buffer[i + 1] << 8) | buffer[i]);
            float amplitude;
            if (sample == short.MinValue)
            {
                amplitude = 1.0f;
            }
            else
            {
                amplitude = Math.Abs(sample) / (float)short.MaxValue;
            }

            if (amplitude > maxAmplitude)
            {
                maxAmplitude = amplitude;
            }
        }
        return maxAmplitude;
    }

    protected virtual void OnSoundDetected(string message)
    {
        SoundDetected?.Invoke(this, message);
    }

    public void Dispose()
    {
        if (audioFile != null)
        {
            audioFile.Dispose();
            audioFile = null;
        }
    }
}
