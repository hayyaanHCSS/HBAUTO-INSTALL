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
    ///The VerifyServerReleaseVersion recording.
    /// </summary>
    [TestModule("bde2f0df-0f77-479a-b4a2-1a2a235f3d36", ModuleType.Recording, 1)]
    public partial class VerifyServerReleaseVersion : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static VerifyServerReleaseVersion instance = new VerifyServerReleaseVersion();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyServerReleaseVersion()
        {
            currentVersion = "2019";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyServerReleaseVersion Instance
        {
            get { return instance; }
        }

#region Variables

        string _currentVersion;

        /// <summary>
        /// Gets or sets the value of variable currentVersion.
        /// </summary>
        [TestVariable("72c683b6-e2c0-4feb-978b-da12f0e185d7")]
        public string currentVersion
        {
            get { return _currentVersion; }
            set { _currentVersion = value; }
        }

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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'HeavyBidServerSetup'", repo.HeavyBidServerSetup.SelfInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            repo.HeavyBidServerSetup.SelfInfo.WaitForExists(30000);
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~'HeavyBid') on item 'HeavyBidServerSetup.TextContainersForValidation.Titlebar'.", repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, new RecordItemIndex(1));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, "Text", new Regex("HeavyBid"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~'Setup') on item 'HeavyBidServerSetup.TextContainersForValidation.Titlebar'.", repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, new RecordItemIndex(2));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, "Text", new Regex("Setup"), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeContains (Text>$currentVersion) on item 'HeavyBidServerSetup.TextContainersForValidation.Titlebar'.", repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, new RecordItemIndex(3));
                Validate.AttributeContains(repo.HeavyBidServerSetup.TextContainersForValidation.TitlebarInfo, "Text", currentVersion, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~$currentVersion) on item 'HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.TitleText'.", repo.HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.TitleTextInfo, new RecordItemIndex(4));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.TitleTextInfo, "Text", new Regex(currentVersion), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // B.3
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nB.3\r\nValidating AttributeRegex (Text~$currentVersion) on item 'HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.MainText'.", repo.HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.MainTextInfo, new RecordItemIndex(5));
                Validate.AttributeRegex(repo.HeavyBidServerSetup.TextContainersForValidation.WelcomeScreen.MainTextInfo, "Text", new Regex(currentVersion), null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.Text957' at UpperCenter.", repo.HeavyBidServerSetup.Text957Info, new RecordItemIndex(6));
            repo.HeavyBidServerSetup.Text957.Click(Location.UpperCenter);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'GoogleChrome.ArticleList'", repo.GoogleChrome.ArticleListInfo, new ActionTimeout(15000), new RecordItemIndex(7));
            repo.GoogleChrome.ArticleListInfo.WaitForExists(15000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Article List') on item 'GoogleChrome.ArticleList'.", repo.GoogleChrome.ArticleListInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.GoogleChrome.ArticleListInfo, "Text", "Article List");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'help.hcss') on item 'GoogleChrome.AddressBar'.", repo.GoogleChrome.AddressBarInfo, new RecordItemIndex(9));
            Validate.AttributeRegex(repo.GoogleChrome.AddressBarInfo, "Text", new Regex("help.hcss"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GoogleChrome.Pane1' at 1895;7.", repo.GoogleChrome.Pane1Info, new RecordItemIndex(10));
            repo.GoogleChrome.Pane1.Click("1895;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(11));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidServerSetup.Buttons.NextButton' at Center.", repo.HeavyBidServerSetup.Buttons.NextButtonInfo, new RecordItemIndex(12));
            repo.HeavyBidServerSetup.Buttons.NextButton.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
