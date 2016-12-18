using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Sanford.Multimedia;
using Sanford.Multimedia.Midi;
// using System.Reflection;


namespace MIDICrossApp
{
    public partial class Form1 : Form
    {
        InputDevice inDevice = null;
        OutputDevice outDevice = null;

        public Form1()
        {
            // MidiDevice KamilMidi = new MidiDevice();         Tworzenie obiektu klasy

            InitializeComponent();

            // PictureBox.CreateControl();

            Init();
            // MidiDevice.Init();           // Odwolanie do funkcji statycznej - nie trzeba tworzyc obiektu
            // KamilMidi.Init();            // Odwolanie do funkcji w obiekcie klasy


        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (comboMidiInDevices.SelectedIndex == -1)
            {
                // MessageInfo("Wybierz urządzenie wejściowe.", "Informacja.");
                MessageBox.Show("Wybierz urządzenie wejściowe.", "Informacja.", MessageBoxButtons.OK);
            }
            else if (comboMidiOutDevices.SelectedIndex == -1)
            {
                // MessageInfo("Wybierz urządzenie wyjściowe.", "Informacja.");
                MessageBox.Show("Wybierz urządzenie wyjściowe.", "Informacja.", MessageBoxButtons.OK);
            }
            else
            {
                StartReadData();
            }
        }

        void StartReadData()
        {
            // odpalenie wejscia i wyjscia
            inDevice = new InputDevice(comboMidiInDevices.SelectedIndex);
            outDevice = new OutputDevice(comboMidiOutDevices.SelectedIndex);

            inDevice.ChannelMessageReceived += new EventHandler<ChannelMessageEventArgs>(inDevScan_ChannelMessageReceived);
            inDevice.StartRecording();
            
            // OutputDevice outDev = null;

        }


        void inDevScan_ChannelMessageReceived(object sender, ChannelMessageEventArgs e)
        {
            ChannelMessageBuilder builder = new ChannelMessageBuilder();

            if ( (e.Message.Command == ChannelCommand.NoteOn)
                || (e.Message.Command == ChannelCommand.NoteOff) )
            {
                /*
                NoteList.Items.Add("nuta");
                if (NoteList.Items.Count >= 20)
                    NoteList.Clear();
                 */

                NoteVal.Text = e.Message.Data1.ToString();

                if (e.Message.Command == ChannelCommand.NoteOn)
                    builder.Command = ChannelCommand.NoteOn;

                if (e.Message.Command == ChannelCommand.NoteOff)
                    builder.Command = ChannelCommand.NoteOff;

                builder.MidiChannel = e.Message.MidiChannel;
                builder.Data1 = e.Message.Data1;        // note val
                builder.Data2 = e.Message.Data2;        // velocity
                builder.Build();

                outDevice.Send(builder.Result);
            }
        }



        private void PictureBox_Click(object sender, EventArgs e)
        {
            
            // Cursor pozycja;
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            // ToolTip trackTip;
           
            // pozycja = PictureBox.Cursor;
            PozycjaKursora.Text = x.ToString() + ":" + y.ToString();
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
