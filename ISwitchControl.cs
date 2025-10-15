using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08_Git_Multiple
{
    internal interface ISwitchControl
    {
        bool isOn { get; set; }
        void TurnOn();
        void TurnOff();
    }
}
