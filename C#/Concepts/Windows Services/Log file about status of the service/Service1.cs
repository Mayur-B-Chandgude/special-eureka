using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace Log_file_about_status_of_the_service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            MarvellousWriteToFile("Marvellous Service Started..");
        }

        protected override void OnStop()
        {
            MarvellousWriteToFile("Marvellous Service Stoped..");
        }

        public void MarvellousWriteToFile(string message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\MarvellousLogs";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\MarvellousLogs\\MarvellousServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/','_') + ".txt";

            if(!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(message);
                }
            }
            else
            {
                using(StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(message);
                }
            }
        }
    }
}
