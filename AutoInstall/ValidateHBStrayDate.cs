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
    ///The ValidateHBStrayDate recording.
    /// </summary>
    [TestModule("82ff8626-4ccf-402d-b3ee-db8e600f7d69", ModuleType.Recording, 1)]
    public partial class ValidateHBStrayDate : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static ValidateHBStrayDate instance = new ValidateHBStrayDate();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateHBStrayDate()
        {
            YearVersion = "2019";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateHBStrayDate Instance
        {
            get { return instance; }
        }

#region Variables

        string _YearVersion;

        /// <summary>
        /// Gets or sets the value of variable YearVersion.
        /// </summary>
        [TestVariable("b53c7e93-8ed1-4459-8552-62df97849436")]
        public string YearVersion
        {
            get { return _YearVersion; }
            set { _YearVersion = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            try {
                Report.Log(ReportLevel.Info, "Application", "(Optional Action)\r\nRun application 'Excel.EXE' with arguments 'C:\\HeavyBid\\BIN\\STRAY.XML' in normal mode.", new RecordItemIndex(0));
                Host.Local.RunApplication("Excel.EXE", "C:\\HeavyBid\\BIN\\STRAY.XML", "C:\\Program Files (x86)\\Microsoft Office", false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExcelRelated.OpenXML.xmlTable' at Center.", repo.ExcelRelated.OpenXML.xmlTableInfo, new RecordItemIndex(1));
                repo.ExcelRelated.OpenXML.xmlTable.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExcelRelated.OpenXML.OKButton' at Center.", repo.ExcelRelated.OpenXML.OKButtonInfo, new RecordItemIndex(2));
                repo.ExcelRelated.OpenXML.OKButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExcelRelated.ExcelXMLPopup.OKButton' at Center.", repo.ExcelRelated.ExcelXMLPopup.OKButtonInfo, new RecordItemIndex(3));
                repo.ExcelRelated.ExcelXMLPopup.OKButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeRegex (Text~$YearVersion) on item 'ExcelRelated.Excel.CellA2'.", repo.ExcelRelated.Excel.CellA2Info, new RecordItemIndex(4));
                Validate.AttributeRegex(repo.ExcelRelated.Excel.CellA2Info, "Text", new Regex(YearVersion), null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='10/24/2018') on item 'ExcelRelated.Excel.CellB2'.", repo.ExcelRelated.Excel.CellB2Info, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.ExcelRelated.Excel.CellB2Info, "Text", "10/24/2018", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Application", "(Optional Action)\r\nClosing application containing item 'ExcelRelated.Excel'.", repo.ExcelRelated.Excel.SelfInfo, new RecordItemIndex(6));
                Host.Current.CloseApplication(repo.ExcelRelated.Excel.Self, 10000);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                //Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ExcelRelated.ExcelXMLPopup.DontSaveButton' at Center.", repo.ExcelRelated.ExcelXMLPopup.DontSaveButtonInfo, new RecordItemIndex(7));
                //repo.ExcelRelated.ExcelXMLPopup.DontSaveButton.Click();
                //Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
