using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms31withEvent
{
    public class MessageToParentEventArgs: EventArgs
    {
        public string[] UrgentInfo { get; set; }
    }
}
