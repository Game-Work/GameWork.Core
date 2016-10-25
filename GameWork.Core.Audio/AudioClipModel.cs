namespace GameWork.Core.Audio
{
    public class AudioClipModel
    {
        public string Name { get; set; }

        public float TargetVolume { get; set; }

        public uint TargetLayer { get; set; }

        public bool Loop { get; set; }

        public float Duration { get; set; }
    }
}