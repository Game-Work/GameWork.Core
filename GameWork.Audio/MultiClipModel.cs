using GameWork.Models.Interfaces;

namespace GameWork.Audio
{
	public class MultiClipModel : IModel
	{
		public AudioClip[] Clips { get; set; }
	}
}