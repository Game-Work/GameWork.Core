using GameWork.Models.Interfaces;

namespace GameWork.Models
{ 
    public struct DurationModel: IModel
    {        
        public string Id { get; set; }

        public float Duration { get; set; }
    }
}