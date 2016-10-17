using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace MyNewService
{
    public partial class Service1 : ServiceBase
    {
        static int eventId = 0;
        public Service1()
        {
            InitializeComponent();
            eventLog1 = new EventLog();

            if (!EventLog.SourceExists("MyNewSource"))
            {
                EventLog.CreateEventSource("MyNewSource", "MyNewLog");
            }

            eventLog1.Source = "MyNewSource";
            eventLog1.Log = "MyNewLog";

        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("InOnStart");
            System.Timers.Timer timer = new System.Timers.Timer(60000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information, eventId++);
        }
        protected override void OnStop()
        {
            eventLog1.WriteEntry("In on Stopped");
        }

        protected override void OnPause()
        {
            eventLog1.WriteEntry("In on Paused");
        }

        protected override void OnContinue()
        {
            eventLog1.WriteEntry("In oncontinue");
        }

        protected override void OnShutdown()
        {
            eventLog1.WriteEntry("In on Shutdown");
        }

    }
}
