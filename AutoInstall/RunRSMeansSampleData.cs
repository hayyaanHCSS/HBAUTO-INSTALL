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
    ///The RunRSMeansSampleData recording.
    /// </summary>
    [TestModule("4df77207-444f-446d-9919-9b5e15a1ff43", ModuleType.Recording, 1)]
    public partial class RunRSMeansSampleData : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static RunRSMeansSampleData instance = new RunRSMeansSampleData();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public RunRSMeansSampleData()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static RunRSMeansSampleData Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.DocumentInterface.TreeViewTree.FirstAvailableActivity' at Center.", repo.HeavyBidApp.DocumentInterface.TreeViewTree.FirstAvailableActivityInfo, new RecordItemIndex(0));
            repo.HeavyBidApp.DocumentInterface.TreeViewTree.FirstAvailableActivity.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Right}'.", new RecordItemIndex(1));
            Keyboard.Press("{Right}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HeavyBidApp.DocumentInterface.Buttons.AddActivitiesButton' at Center.", repo.HeavyBidApp.DocumentInterface.Buttons.AddActivitiesButtonInfo, new RecordItemIndex(2));
            repo.HeavyBidApp.DocumentInterface.Buttons.AddActivitiesButton.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Expanded to 'True' on item 'HBPopUpScreens.FromFileButtons.RSMeanRelated.AddActivitesBiditem.RSMeansTreeItem'.", repo.HBPopUpScreens.FromFileButtons.RSMeanRelated.AddActivitesBiditem.RSMeansTreeItemInfo, new RecordItemIndex(3));
            repo.HBPopUpScreens.FromFileButtons.RSMeanRelated.AddActivitesBiditem.RSMeansTreeItem.Element.SetAttributeValue("Expanded", "True");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'HBPopUpScreens.FromFileButtons.RSMeanRelated.AddActivitesBiditem.SampleDataTreeItem'.", repo.HBPopUpScreens.FromFileButtons.RSMeanRelated.AddActivitesBiditem.SampleDataTreeItemInfo, new RecordItemIndex(4));
                Validate.Exists(repo.HBPopUpScreens.FromFileButtons.RSMeanRelated.AddActivitesBiditem.SampleDataTreeItemInfo, null, false);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HBPopUpScreens.FromFileButtons.RSMeanRelated.AddActivitesBiditem.CancelButton' at Center.", repo.HBPopUpScreens.FromFileButtons.RSMeanRelated.AddActivitesBiditem.CancelButtonInfo, new RecordItemIndex(5));
            repo.HBPopUpScreens.FromFileButtons.RSMeanRelated.AddActivitesBiditem.CancelButton.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
