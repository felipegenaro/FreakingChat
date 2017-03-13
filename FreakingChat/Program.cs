﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace FreakingChat
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var logon = new LogonUI())
            {
                Application.Run(logon);
            }
            Environment.Exit(Environment.ExitCode);
        }

        public static void SingleInstance()
        {
            if (PriorProcess() != null)
            {
                MessageBox.Show(@"Another instance of the program is already open.");
                Environment.Exit(Environment.ExitCode);
            }
        }

        public static Process PriorProcess()
        {
            var curr = Process.GetCurrentProcess();
            var procs = Process.GetProcessesByName(curr.ProcessName);
            return procs.FirstOrDefault(p => (p.Id != curr.Id) && (p.MainModule.FileName == curr.MainModule.FileName));
        }
    }
}
