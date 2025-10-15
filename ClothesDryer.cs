using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08_Git_Multiple
{
    class ClothesDryer : ISwitchControl, ITemperatureControl
    {
        private bool _isOn = false;
        private int _targetTemp = 60; 
        private int _currentTemp = 30; 
     
        public bool isOn
        {
            get => _isOn;
            set => _isOn = value;
        }
        public int TargetTemperature
        {
            get => _targetTemp;
            set => _targetTemp = value;
        }


        public int CurrentTemperature
        {
            get => _currentTemp;
            set => _currentTemp = value;
        }
        public readonly int _MinTemperature = 30; 
        public readonly int _MaxTemperature = 80;
        public int MinTemperature => _MinTemperature;

        public int MaxTemperature => _MaxTemperature;

        public int GetCurrentTemperature()
        {
            if (isOn)
            {
                if (_currentTemp < _targetTemp)
                {
                    _currentTemp++;  
                }
                else if (_currentTemp > _targetTemp)
                {
                    _currentTemp--;  
                }
            }
            Console.WriteLine("Current Temperature is " + _currentTemp + "°C");
            return _currentTemp;
        }

        public void SetTemperature(int degrees)
        {
            if (isOn)  
            {
                _targetTemp = Math.Max(_MinTemperature, Math.Min(degrees, _MaxTemperature));
                Console.WriteLine("Target Temperature set to : " + _targetTemp + "°C");
            }
            else
            {
                Console.WriteLine("Cannot set Temp when Dryer is OFF");
            }
        }

        public void TurnOff()
        {
            ToggleSwitch();
        }

        public void TurnOn()
        {
            ToggleSwitch();
        }
        private void ToggleSwitch()
        {
            isOn = !isOn;
            string result = isOn ? "is ON" : "is OFF";
            Console.WriteLine("Clothes Dryer " + result);
        }
    }
}
