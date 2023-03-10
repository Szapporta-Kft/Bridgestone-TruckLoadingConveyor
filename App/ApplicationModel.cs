using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.App
{
    public class ApplicationModel: ITireCheckModel
    {
        public const string USER_COMMAND_START_DELIVERY = "START_DELIVERY";
        public const string USER_COMMAND_START_EXIT = "START_EXIT";
        public const string USER_COMMAND_TIRE_CHECK_START = "TIRE_CHECK_START";
        public const string USER_COMMAND_TIRE_CHECK_STOP = "TIRE_CHECK_STOP";
        public const string USER_COMMAND_TIRE_CHECK_CLOSE = "TIRE_CHECK_CLOSE";

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
