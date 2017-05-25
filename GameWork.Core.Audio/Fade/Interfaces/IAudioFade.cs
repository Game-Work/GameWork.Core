using GameWork.Core.Audio.Clip;

namespace GameWork.Core.Audio.Fade.Interfaces
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public interface IAudioFade
	{
	    AudioClipModel Clip { get; }

	    bool IsComplete { get; }

		float Volume { get; }

        float TargetVolume { get; }

        float Duration { get; }

	    void AddDeltaTime(float deltaTime);
	}
}