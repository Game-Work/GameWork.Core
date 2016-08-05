namespace GameWork.Interfaces.Views
{
    public interface IView
    {
        bool IsVisible { get; }

        void Initialize();

        void Terminate();

        void Show();

        void Hide();
    }
}