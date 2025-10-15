using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08_Git_Multiple
{
    interface ITemperatureControl
    {
        int TargetTemperature { get; set; }
        int CurrentTemperature { get; }

        int MinTemperature { get; }
        int MaxTemperature { get; }

        void SetTemperature(int degrees);

        int GetCurrentTemperature();
    }
}
