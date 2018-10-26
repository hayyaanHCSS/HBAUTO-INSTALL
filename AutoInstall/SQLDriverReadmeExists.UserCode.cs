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

namespace AutoInstall
{
    public partial class SQLDriverReadmeExists
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void ValidateSQLDriver()
        {
        	string sqlDriver = @"C:\HeavyBid\UTILITY\SQL Drivers Readme.txt";
        	if(System.IO.File.Exists(sqlDriver))
	        	{
					Report.Success("Validation","Found SQL Driver Readme!");
	        	} 
        	else
        		{
					Report.Failure("Validation","Could not find SQL Driver Readme!");
    	   	   	}

           
        }

    }
}
