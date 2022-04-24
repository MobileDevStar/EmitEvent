using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput.Native;
using WindowsInput;
using System.Threading;

namespace EmitEvent
{
    public partial class frmEmitEvent : Form
    {
        private Thread runSimThread;

        public frmEmitEvent()
        {
            InitializeComponent();
        }

        private void frmEmitEvent_Load(object sender, EventArgs e)
        {
            comboTypes.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (runSimThread == null || !runSimThread.IsAlive)
            {
                runSimThread = new Thread(startSimulation);
                runSimThread.Start();
            }
        }

        private void startSimulation()
        {
            int interval = Convert.ToInt32(numInterval.Value);
            Console.WriteLine("Interval: " + interval);

            InputSimulator sim = new InputSimulator();

            int type = 0;
            if (type == 0)
            {
                int numKey1 = Convert.ToInt32(numKeyFrom.Value);
                Console.WriteLine("Key count from: " + numKey1);

                int numKey2 = Convert.ToInt32(numKeyTo.Value);
                Console.WriteLine("Key count to: " + numKey2);

                for (int i = numKey1; i < numKey2; i++)
                {
                    sim.Keyboard.KeyPress(VirtualKeyCode.RIGHT);
                }
            }
            else
            {
                int numMouse1 = Convert.ToInt32(numMouseFrom.Value);
                Console.WriteLine("Mouse count from: " + numMouse1);

                int numMouse2 = Convert.ToInt32(numMouseTo.Value);
                Console.WriteLine("Mouse count to: " + numMouse2);

                for (int i = numMouse1; i < numMouse2; i++)
                {
                    sim.Mouse.LeftButtonClick();
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (runSimThread!= null && runSimThread.IsAlive)
            {
                runSimThread.Abort();
            }

            Application.Exit();
        }

    }
}
