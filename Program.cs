﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransactionsTrackerApp
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>


                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new TransactionsTrackerApp.PresentationLayer.MainForm());

        }
    }
}
