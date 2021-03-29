#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Forms;
using System;
using System.Windows.Forms;

namespace GettingStarted
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            MessageBoxAdv.CanResize = true;
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
        }

        /// <summary>
        /// Show Error Message
        /// </summary>
        private void btn_errormsg_Click(object sender, EventArgs e)
        {
            string errorMessage = "Windows cannot install required files. The file may be corrupt or missing. Make sure all files " +
                "required for installation are available, and restart the installation.Error code:0x80070570";
            string details = "You can most likely get the error when reinstalling or updating the operating system. The symptom of the failure is the error message stating that Windows cannot install required files.The file may be corrupt or missing.Make sure all files required for installation are available, and restart the installation.Error code: 0x80070570.";

          MessageBoxAdv.Show(errorMessage, "Install Windows", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning,
              details);
        }
    }
}
