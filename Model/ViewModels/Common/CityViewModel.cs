using Model.Models.Common;
using Model.ViewModels.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ViewModels.Common
{
    public class CityViewModel : BaseViewModel
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string ExternalCode { get; set; }
        public StateViewModel State { get; set; }

        public static implicit operator CityViewModel(City model)
        {
            return new CityViewModel()
            {
                CityId = model.CityId,
                Name = model.Name,
                ExternalCode = model.ExternalCode,
                State = new StateViewModel() { StateId = model.StateId }
            };
        }
    }
}
