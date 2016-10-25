namespace GameWork.Core.Audio.Interfaces
{
	public interface IAudioClip
	{
        string Name { get; }

        float TargetVolume { get; }

        uint TargetLayer { get; }

        bool Loop { get; }

        float Duration { get; }
    }
}