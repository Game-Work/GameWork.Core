namespace GameWork.Interfaces.Views
{
    public interface IViewFactory
    {
        IView Create(string id);
    }
}