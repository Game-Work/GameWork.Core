using GameWork.Models.Interfaces;

namespace GameWork.Interfacing.Interfaces
{
    public interface IInterfaceModel : IModel
    {
        string VisibilityPath { get; set; }
    }
}