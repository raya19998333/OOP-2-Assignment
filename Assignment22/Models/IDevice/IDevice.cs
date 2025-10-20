using Assignment22.Models.IDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22.Models.IDevice
{
    //Create an interface IDevice with methods:
    interface IDevice
    {
        void TurnOn();
        void TurnOff();
        void ShowStatus();
    }
    //- LightBulb (on/off state, brightness level)
    class Light : IDevice
    {
        private bool isOn;
        private int brightness;
        // Constructor to initialize default state
        public Light()
        {
            isOn = false;
            brightness = 0; // Default brightness
        }
        // Methods to implement IDevice interface
        public void TurnOn()
        {
            isOn = true;
            brightness = 100; // Set brightness to maximum when turned on
        }
        // Method to turn off the light bulb
        public void TurnOff()
        {
            isOn = false;
            brightness = 0; // Set brightness to zero when turned off
        }
        // Method to show the current status of the light bulb
        public void ShowStatus()
        {
            Console.WriteLine($"LightBulb is currently {(isOn ? "ON" : "OFF")} ,Brightness: {brightness}%.");
        }
    }
    //Thermostat (on/off state, current temp)    
    class Thermostat : IDevice
    {
        // Fields to represent the state of the Thermostat
        private bool isOn;
        private double currentTemperature;
        public Thermostat()
        {
            // Initialize default state
            isOn = false;
            currentTemperature = 22.0; // Default temperature
        }
        // Methods to implement IDevice interface
        public void TurnOn()
        {
            // Set the thermostat to on state
            isOn = true;
            currentTemperature = 24.0; // Set to default temperature when turned on
        }
        // Method to turn off the thermostat
        public void TurnOff()
        {
            isOn = false;
        }
        // Method to show the current status of the thermostat
        public void ShowStatus()
        {
            Console.WriteLine($"Thermostat is currently {(isOn ? "ON" : "OFF")}, Current Temperature: {currentTemperature}°C.");
        }
    }

}
//Create a Controller class that accepts any IDevice and can operate it using its methods.
class Controller 
{
    // Method to control any IDevice
    public void OperatelDevice(IDevice device)
    {
        // Use the IDevice methods to operate the device
        device.TurnOn();
        device.ShowStatus();
        device.TurnOff();
        device.ShowStatus();
    }
}