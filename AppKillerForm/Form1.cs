using System;
using System.Diagnostics;

namespace AppKillerForm
{
    public partial class Form1 : Form
    {
        private List<Process> _observedProcess;

        public Form1()
        {
            InitializeComponent();
            checkedListBoxCurrentProcess.Items.AddRange(Process.GetProcesses()
                .Select(p => p.ProcessName)
                .Distinct()
                .Order()
                .ToArray());

        }

        private void checkedListBoxCurrentProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
