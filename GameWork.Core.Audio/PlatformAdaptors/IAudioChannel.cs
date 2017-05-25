using System;
using GameWork.Core.Audio.Clip;

namespace GameWork.Core.Audio.PlatformAdaptors
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface IAudioChannel
    {
        bool IsPlaying { get; }

        float PlaybackSeconds { get; }

        int PlaybackSamples { get; }

        float Volume { get; set; }

        void Play(AudioClipModel clip, IAudioChannel master = null, Action onComplete = null);

        void Stop();

        void Tick();   
    }
}
