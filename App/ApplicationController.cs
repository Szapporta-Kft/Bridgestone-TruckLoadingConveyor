using Bridgestone.Warehouse.Loading.Conveyor.App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.App
{
    public class ApplicationController
    {
        private static ApplicationController _Instance;
        private ApplicationModel _Model;
        private MainWindow _MainForm;
        private BaseView _View;

        public static void Start()
        {
            if (_Instance == null)
            {
                _Instance = new ApplicationController();
            }
            _Instance.Run();
        }


        public ApplicationController()
        {
            _Model = new ApplicationModel();
        }

        public void Run()
        {
            _MainForm = new MainWindow();
            SetView();
            Application.Run(_MainForm);
            Application.DoEvents();
            _MainForm.Dispose();
            Application.Exit();
        }
        public void SetView()
        {

            if (_Model.GetApplicationState() == ApplicationState.Start)
            {
                _View = new StartView();
            }
            else
            {
                _View = new TireCheckView();
            }

            _MainForm.PanelMain.Controls.Add(_View);
            _View.UserCommandIssued += new BaseView.UserCommandIssueHandlerEvent(OnViewUserCommand);


        }

        public virtual void OnViewUserCommand(UserCommand command)
        {
            switch (_Model.GetApplicationState())
            {
                //alkalmazás állapota: start
                case ApplicationState.Start:
                    //eseménykezelés
                    switch (command.Code)
                    {
                        case ApplicationModel.USER_COMMAND_START_DELIVERY:
                            int i = 0;
                            break;
                        case ApplicationModel.USER_COMMAND_START_EXIT:
                            int j = 0;
                            break;
                        default:
                            throw new Exception("Invalid user command: " + command.Code);
                            break;
                    }
                    break;
                //alkalmazás állapota: gumi ellenőrzés
                case ApplicationState.TireCheck:
                    //eseménykezelés
                    switch (command.Code)
                    {
                        case ApplicationModel.USER_COMMAND_TIRE_CHECK_START:
                            int i = 0;
                            break;
                        case ApplicationModel.USER_COMMAND_TIRE_CHECK_STOP:
                            int j = 0;
                            break;
                        case ApplicationModel.USER_COMMAND_TIRE_CHECK_CLOSE:
                            int k = 0;
                            break;
                        default:
                            throw new Exception("Invalid user command: " + command.Code);
                            break;
                    }
                    break;
                default:
                    throw new Exception("Invalid view");
                    break;
            }
        }


        public void Dispose()
        {
            _View.UserCommandIssued -= new BaseView.UserCommandIssueHandlerEvent(OnViewUserCommand);
            _Model = null;
            _View = null;

        }
    }
}
