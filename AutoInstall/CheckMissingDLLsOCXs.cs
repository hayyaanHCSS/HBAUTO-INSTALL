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
    ///The CheckMissingDLLsOCXs recording.
    /// </summary>
    [TestModule("a6f15c91-1e6d-43df-ab08-61a8a5bb251d", ModuleType.Recording, 1)]
    public partial class CheckMissingDLLsOCXs : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AutoInstallRepository repository.
        /// </summary>
        public static AutoInstallRepository repo = AutoInstallRepository.Instance;

        static CheckMissingDLLsOCXs instance = new CheckMissingDLLsOCXs();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CheckMissingDLLsOCXs()
        {
            DLL = "ChilkatCert.dll";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CheckMissingDLLsOCXs Instance
        {
            get { return instance; }
        }

#region Variables

        string _DLL;

        /// <summary>
        /// Gets or sets the value of variable DLL.
        /// </summary>
        [TestVariable("22f653b1-83ed-4798-891e-198e424ff63f")]
        public string DLL
        {
            get { return _DLL; }
            set { _DLL = value; }
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 100ms.", new RecordItemIndex(0));
            Delay.Duration(100, false);
            
            ValidateDLLComparison(DLL);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
