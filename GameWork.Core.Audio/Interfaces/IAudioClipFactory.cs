namespace GameWork.Core.Audio.Interfaces
{
    public interface IAudioClipFactory
    {
        void AddModel(AudioClipModel model);

        IAudioClip Create(string id);
    }
}
