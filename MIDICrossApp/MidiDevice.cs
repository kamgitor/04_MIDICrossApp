using System;
using System.Collections.Generic;
/*
using System.ComponentModel;
using System.Drawing;
using System.Data;
*/
using System.Linq;
using System.Text;

using System.Windows.Forms;
using Sanford.Multimedia;
using Sanford.Multimedia.Midi;


namespace MIDICrossApp
{
    public partial class Form1      // MidiDevice
    {
        // uzycie metody statycznej nie wymaga tworzenia obiektu
        // ale skolei statyczna metoda ma problem do odwolan do innych metod w klasie / obiektow
        // jak tu byl static to nie widzialem obiektu comboMidiInDevices nawet gdy klasa byla partial Form1
        // public static void Init()

        public void Init()
        {
            // In MIDI Devices
            int iDevices = InputDevice.DeviceCount;

            comboMidiInDevices.Items.Clear();
            
            // Wypisz urzadzenia
            for (int x = 0; x < iDevices; x++)
            {
                MidiInCaps caps = InputDevice.GetDeviceCapabilities(x);

                comboMidiInDevices.Items.Add(caps.name);

                // Zapamietaj indeks urzadzenia, ktory jest wybrany
        //      if (caps.name == inString)
        //          iSelectedIn = x;
            }

            // Out MIDI Devices
            int oDevices = OutputDevice.DeviceCount;

            comboMidiOutDevices.Items.Clear();
            for (int x = 0; x < oDevices; x++)
            {
                MidiOutCaps caps = OutputDevice.GetDeviceCapabilities(x);

                comboMidiOutDevices.Items.Add(caps.name);

                // Zapamietaj indeks urzadzenia, ktory jest wybrany
         //     if (caps.name == outString)
         //         iSelectedOut = x;
            }

        }   // Init
    }
}

