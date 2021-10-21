using System;
using System.Collections.Generic;
using System.Text;

using TheNextCar.Model;
namespace NextCar.Controller
{
    class AccubaterryController
    {
        private Accubattery accubaterry;
        private OnPowerChanged callBackOnPowerChanged;
        public AccubaterryController(OnPowerChanged callBackOnPowerChanged)
        {
            this.accubaterry = new Accubattery(12);
            this.callBackOnPowerChanged = callBackOnPowerChanged;
        }
        public bool accubatterryIsOn()
        {
            return this.accubaterry.isOn();
        }
        public void turnOn()
        {
            this.accubaterry.turnOn();
            this.callBackOnPowerChanged.onPowerChangedStatus("ON", "power is on");
        } public void turnOff()
        {
            this.accubaterry.turnOff();
            this.callBackOnPowerChanged.onPowerChangedStatus("OFF", "power is off");
        }
    }
    interface OnPowerChanged
    {
        void onPowerChangedStatus(string value, string message);
    }
}