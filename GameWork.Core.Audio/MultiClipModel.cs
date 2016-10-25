using GameWork.Core.Audio.Interfaces;
using GameWork.Core.Models.Interfaces;

namespace GameWork.Core.Audio
{
	public class MultiClipModel : IModel
	{
		public IAudioClip[] Clips { get; set; }
	}
}