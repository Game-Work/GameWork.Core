using GameWork.Models.Interfaces;

namespace GameWork.Models
{
    public struct OptionsModel : IModel
    {
        public string Id { get; set; }

        public string[] Options { get; set; }
    }
}