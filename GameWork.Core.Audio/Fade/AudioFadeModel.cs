using GameWork.Core.Models.Interfaces;

namespace GameWork.Core.Audio.Fade
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public class AudioFadeModel : IModel
    {
		public float StartVolume { get; set; }

        public float TargetVolume { get; set; }

        public float Duration { get; set; }

        public AudioFadeModel(float startVolume, float targetVolume, float duration)
        {
            StartVolume = startVolume;
            TargetVolume = targetVolume;
            Duration = duration;
        }
    }
}