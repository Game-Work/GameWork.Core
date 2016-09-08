namespace GameWork.Interfaces
{
    public interface ILoginable
    {
        void Login(string username, string password);

        void Logout();
    }
}