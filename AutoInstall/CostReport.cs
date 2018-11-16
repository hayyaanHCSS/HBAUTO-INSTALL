﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace AutoInstall
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CostReport recording.
    /// </summary>
    [TestModule("f2dca640-d155-4bc2-8763-41db5cf29aee", ModuleType.Recording, 1)]
    public partial class CostReport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static CostReport instance = new CostReport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CostReport()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CostReport Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Tabs.ReportTab' at Center.", repo.HeavyBidApp.Tabs.ReportTabInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.Tabs.ReportTab.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.Buttons.Report.CostReportsButton' at Center.", repo.HeavyBidApp.Buttons.Report.CostReportsButtonInfo, new RecordItemIndex(1));
            repo.HeavyBidApp.Buttons.Report.CostReportsButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'HeavyBidApp.DocumentInterface.Reports.CostReports.CostReport' at Center.", repo.HeavyBidApp.DocumentInterface.Reports.CostReports.CostReportInfo, new RecordItemIndex(2));
            repo.HeavyBidApp.DocumentInterface.Reports.CostReports.CostReport.DoubleClick();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 15s.", new RecordItemIndex(3));
            Delay.Duration(15000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBReportViewers.HBReportPlus.HBReportPlusViewer.ExportTo' at LowerCenter.", repo.HBReportViewers.HBReportPlus.HBReportPlusViewer.ExportToInfo, new RecordItemIndex(4));
            repo.HBReportViewers.HBReportPlus.HBReportPlusViewer.ExportTo.Click(Location.LowerCenter);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Return}' with focus on 'HBReportViewers.HBReportPlus.HBReportPlusViewer.ExportTo'.", repo.HBReportViewers.HBReportPlus.HBReportPlusViewer.ExportToInfo, new RecordItemIndex(5));
            repo.HBReportViewers.HBReportPlus.HBReportPlusViewer.ExportTo.PressKeys("{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Tab}{Return}");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBReportViewers.HBReportPlus.TextExportOptions.OKButton' at Center.", repo.HBReportViewers.HBReportPlus.TextExportOptions.OKButtonInfo, new RecordItemIndex(6));
            //repo.HBReportViewers.HBReportPlus.TextExportOptions.OKButton.Click();
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(7));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HBReportViewers.SaveAsExport.FilePathURL' at CenterRight.", repo.HBReportViewers.SaveAsExport.FilePathURLInfo, new RecordItemIndex(8));
                repo.HBReportViewers.SaveAsExport.FilePathURL.Click(Location.CenterRight);
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence 'W:\\HBDaily\\InstallAutomation\\HBReportsExportFiles{Return}'.", new RecordItemIndex(9));
                Keyboard.Press("W:\\HBDaily\\InstallAutomation\\HBReportsExportFiles{Return}");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HBReportViewers.SaveAsExport.FileName' at Center.", repo.HBReportViewers.SaveAsExport.FileNameInfo, new RecordItemIndex(10));
                repo.HBReportViewers.SaveAsExport.FileName.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence 'CostReport.txt'.", new RecordItemIndex(11));
                Keyboard.Press("CostReport.txt");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HBReportViewers.SaveAsExport.SaveButton' at Center.", repo.HBReportViewers.SaveAsExport.SaveButtonInfo, new RecordItemIndex(12));
                repo.HBReportViewers.SaveAsExport.SaveButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(12)); }
            
            try {
                //Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HBReportViewers.ConfirmSaveAs.YesButton' at Center.", repo.HBReportViewers.ConfirmSaveAs.YesButtonInfo, new RecordItemIndex(13));
                //repo.HBReportViewers.ConfirmSaveAs.YesButton.Click();
                //Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBReportViewers.ExportScreen.NoButton' at Center.", repo.HBReportViewers.ExportScreen.NoButtonInfo, new RecordItemIndex(14));
            repo.HBReportViewers.ExportScreen.NoButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBReportViewers.HBReportPlus.HBReportPlusViewer.ClosePreviewButton' at Center.", repo.HBReportViewers.HBReportPlus.HBReportPlusViewer.ClosePreviewButtonInfo, new RecordItemIndex(15));
            repo.HBReportViewers.HBReportPlus.HBReportPlusViewer.ClosePreviewButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
