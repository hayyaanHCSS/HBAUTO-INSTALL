﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using System.IO;


namespace AutoInstall
{
    public partial class CheckMissingDLLsOCXs
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        /// 

        string directory = @"C:\Program Files (x86)\Common Files\HCSS";
        	
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void ValidateDLLComparison(string FileName)
        {
        	string FilePath = Path.Combine(directory,FileName);
               if (File.Exists(FilePath))
			   {
        			Report.Success("File Exist", "Success! " + FilePath + " exists!");
			   }
				else                  
			   {
					Report.Failure("File Exist", "Fail. " + FilePath + " does not exists.");
			   }
        	}

    }
}
