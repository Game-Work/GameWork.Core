using GameWork.Controllers.Interfaces;

namespace GameWork.Audio.Interfaces
{
	public interface IAudioController : IController
	{
		void Play(IAudioClip clip);

		void Stop(IAudioClip clip);

		void FadeIn(IAudioClip clip, float duration);

		void FadeOut(IAudioClip clip, float duration);
	}
}