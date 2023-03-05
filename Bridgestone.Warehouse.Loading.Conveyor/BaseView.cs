using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bridgestone.Warehouse.Loading.Conveyor.App
{
    public abstract partial class BaseView : UserControl
    {
        public delegate void UserCommandIssueHandlerEvent(UserCommand userCommand);
        public event UserCommandIssueHandlerEvent UserCommandIssued;

        protected bool _ProcessingUserCommand = false;
        protected ApplicationModel _ViewModel;


        public BaseView()
        {
            InitializeComponent();
        }

        public BaseView(ApplicationModel viewModel)
        {
            this._ViewModel = viewModel;
            this.ParentChanged += new EventHandler(Handle_ParentChanged);
            InitializeComponent();
        }

        void Handle_ParentChanged(object sender, EventArgs e)
        {
            //TODO
            int i = 0;

        //    if (this.TopLevelControl != null)
        //    {
        //        //ControlKeyRegisterUtil.RegisterKeyUp(this, true, new KeyEventHandler(HandleKeyUp));
        //        ((MainWindow)this.TopLevelControl).KeyDown += new KeyEventHandler(Handle_PreKeyDown);
        //        ((MainWindow)this.TopLevelControl).KeyUp += new KeyEventHandler(Handle_PreKeyUp);
        //        ((MainWindow)this.TopLevelControl).KeyPress += new KeyPressEventHandler(Handle_PreKeyPress);

        //        _OldTopLevelControl = this.TopLevelControl;
        //    }
        //    else if (_OldTopLevelControl != null)
        //    {
        //        //ControlKeyRegisterUtil.UnRegisterKeyUp(_OldTopLevelControl, true, new KeyEventHandler(HandleKeyUp));
        //        try
        //        {
        //            ((MainWindow)_OldTopLevelControl).KeyDown -= new KeyEventHandler(Handle_PreKeyDown);
        //        }
        //        catch (Exception ex) { }
        //        try
        //        {
        //            ((MainWindow)_OldTopLevelControl).KeyUp -= new KeyEventHandler(Handle_PreKeyUp);
        //        }
        //        catch (Exception ex) { }
        //        try
        //        {
        //            ((MainWindow)_OldTopLevelControl).KeyPress -= new KeyPressEventHandler(Handle_PreKeyPress);
        //        }
        //        catch (Exception ex) { }

        //        _OldTopLevelControl = null;
        //    }
        }

        protected void OnUserCommand(UserCommand userCommand)
        {
            if (!this._ProcessingUserCommand)
            {
                this._ProcessingUserCommand = true;
                if (this.UserCommandIssued != null)
                    this.UserCommandIssued(userCommand);
                this._ProcessingUserCommand = false;
            }
        }

        protected virtual void Handle_ButtonClick(object sender, EventArgs e)
        {
            if (_ProcessingUserCommand != true)
            {
                this.OnUserCommand(new UserCommand(this._ButtonUserCommDict[(Button2)sender]));
            }
    }
}
