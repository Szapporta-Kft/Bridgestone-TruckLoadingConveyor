using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridgestone.Warehouse.Loading.Conveyor.App
{
    public class UserCommand
    {
        private string _Code;
        public string Code
        {
            get { return _Code; }
        }

        public UserCommand(string code)
        {
            this._Code = code;
        }
    }
}
