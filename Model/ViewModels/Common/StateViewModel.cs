using Model.Models.Common;

namespace Model.ViewModels.Common
{
    public class StateViewModel
    {
        public int StateId { get; set; }
        public string Name { get; set; }
        public string FederativeUnit { get; set; }
        public string ExternalCode { get; set; }
        //public List<City> Cities { get; set; }

        public static implicit operator StateViewModel(State model)
        {
            return new StateViewModel
            {
                StateId = model.StateId,
                Name = model.Name,
                FederativeUnit = model.FederativeUnit,
                ExternalCode = model.ExternalCode
            };
        }       
    }
}
