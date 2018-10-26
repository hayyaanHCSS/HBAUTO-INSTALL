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
    ///The TestSARegCode recording.
    /// </summary>
    [TestModule("49487010-896c-429c-91e4-51f488e53473", ModuleType.Recording, 1)]
    public partial class TestSARegCode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static TestSARegCode instance = new TestSARegCode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TestSARegCode()
        {
            RegCodeSA = "28d7c9f7-0f26-4b09-8b40-16c84e43681b";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TestSARegCode Instance
        {
            get { return instance; }
        }

#region Variables

        string _RegCodeSA;

        /// <summary>
        /// Gets or sets the value of variable RegCodeSA.
        /// </summary>
        [TestVariable("09e58522-487a-4d3a-b07a-7d51113c5046")]
        public string RegCodeSA
        {
            get { return _RegCodeSA; }
            set { _RegCodeSA = value; }
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
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 30s to exist. Associated repository item: 'HeavyBidRegistration.RegEntryTextbox'", repo.HeavyBidRegistration.RegEntryTextboxInfo, new ActionTimeout(30000), new RecordItemIndex(0));
                repo.HeavyBidRegistration.RegEntryTextboxInfo.WaitForExists(30000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Keyboard", "(Optional Action)\r\nKey sequence from variable '$RegCodeSA' with focus on 'HeavyBidRegistration.RegEntryTextbox'.", repo.HeavyBidRegistration.RegEntryTextboxInfo, new RecordItemIndex(1));
                repo.HeavyBidRegistration.RegEntryTextbox.PressKeys(RegCodeSA);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(2));
            Delay.Duration(5000, false);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HeavyBidRegistration.Buttons.CheckButton' at Center.", repo.HeavyBidRegistration.Buttons.CheckButtonInfo, new RecordItemIndex(3));
                repo.HeavyBidRegistration.Buttons.CheckButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeRegex (Text~'attempting') on item 'HeavyBidRegistration.TextContainsForValidation.WrongRegistrationCodeTextbox'.", repo.HeavyBidRegistration.TextContainsForValidation.WrongRegistrationCodeTextboxInfo, new RecordItemIndex(4));
                Validate.AttributeRegex(repo.HeavyBidRegistration.TextContainsForValidation.WrongRegistrationCodeTextboxInfo, "Text", new Regex("attempting"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HeavyBidRegistration.Buttons.SubmitButton' at Center.", repo.HeavyBidRegistration.Buttons.SubmitButtonInfo, new RecordItemIndex(5));
                repo.HeavyBidRegistration.Buttons.SubmitButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Wait", "(Optional Action)\r\nWaiting 10s to exist. Associated repository item: 'HeavyBidRegistration.Buttons.OKButton'", repo.HeavyBidRegistration.Buttons.OKButtonInfo, new ActionTimeout(10000), new RecordItemIndex(6));
                repo.HeavyBidRegistration.Buttons.OKButtonInfo.WaitForExists(10000);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeRegex (Text~'attempting') on item 'HeavyBidRegistration.TextContainsForValidation.WrongRegistrationCodePopupTextbox'.", repo.HeavyBidRegistration.TextContainsForValidation.WrongRegistrationCodePopupTextboxInfo, new RecordItemIndex(7));
                Validate.AttributeRegex(repo.HeavyBidRegistration.TextContainsForValidation.WrongRegistrationCodePopupTextboxInfo, "Text", new Regex("attempting"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'HeavyBidRegistration.Buttons.OKButton' at Center.", repo.HeavyBidRegistration.Buttons.OKButtonInfo, new RecordItemIndex(8));
                repo.HeavyBidRegistration.Buttons.OKButton.Click();
                Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
