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
                case ApplicationState.Start:

                    break;
                case ApplicationState.TireCheck:

                    break;
                default:
                    throw new Exception("Invalid view");
                    break;
            }
        }

        }
    }
