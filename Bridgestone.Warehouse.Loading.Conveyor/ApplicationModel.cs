using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.App
{
    public class ApplicationModel: ITireCheckModel
    {
        ApplicationState _ApplicatonState;

        public ApplicationModel()
        {
            _ApplicatonState = ApplicationState.Start;
        }

        public ApplicationState GetApplicationState()
        {
            return _ApplicatonState;
        }

        public void SetApplicationStateToStart()
        {
            _ApplicatonState = ApplicationState.Start;
        }

        public void SetApplicationStateToTireCheck()
        {
            _ApplicatonState = ApplicationState.TireCheck;
        }
    }
}
