﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibPhone;
using ClassLibPhone.Component_Interfaces;
using ClassLibPhone.Peripherals;

namespace WinFormsPhone {
    static class Program {

        private const int Lab = 3;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            switch (Lab) {
                case 2:
                    Phone formPhone = new Phone();
                    formPhone.FormTopLabel = "Select playback component (specify index):";
                    formPhone.FormOption1 = "1 - MeizuHeadset";
                    formPhone.FormOption2 = "2 - SamsungHeadset";
                    formPhone.FormOption3 = "3 - UnofficialiPhoneHeadset";
                    formPhone.FormOption4 = "4 - PortableSpeaker";
                    IOutput output = new WinFormOutput(formPhone);
                    formPhone.Output = output;
                    Application.Run(formPhone);
                    break;
                case 3:
                    SMSScreen formSMS = new SMSScreen();
                    Application.Run(formSMS);
                    break;
            }
        }
    }
}
