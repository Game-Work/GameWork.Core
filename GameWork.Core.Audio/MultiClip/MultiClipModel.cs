using GameWork.Core.Audio.Clip;
using GameWork.Core.Models.Interfaces;

namespace GameWork.Core.Audio.MultiClip
{
    /// <summary>
    /// Todo: Please contact us if you see this message
    /// </summary>
    public class MultiClipModel : IModel
	{
		public AudioClipModel[] Clips { get; set; }
	}
}