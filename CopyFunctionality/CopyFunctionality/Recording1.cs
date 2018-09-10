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
using System.IO;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;


namespace CopyFunctionality
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("724171ab-a4eb-4413-8484-b6af1e159f42", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CopyFunctionalityRepository repository.
        /// </summary>
        public static CopyFunctionalityRepository repo = CopyFunctionalityRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

        #region Variables

        #endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            //if the STA file exist at the beggining of run, delete them

            string strActualValuesPath = "D:\\Joro\\GIT_Automations\\AutomationCopy\\Reports\\ActualValuesBIG.STA";    // Here we delete the actuasl.STA file otherwice the data will be duplicate    
            System.IO.File.Delete(strActualValuesPath);
            Delay.Milliseconds(200);

            string strActualValuesFFWPath = "D:\\Joro\\GIT_Automations\\AutomationCopy\\Reports\\ActualValuesFFW.STA"; // Here we delete the actuasl.STA file otherwice the data will be duplicate  
            System.IO.File.Delete(strActualValuesFFWPath);                                                              
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at 882;7.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(0));
            repo.SnapXUntitled.TitleBar.Click("882;7");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(1));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(1000);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(3));
            Keyboard.Press("f");
            Delay.Milliseconds(600);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'o'.", new RecordItemIndex(5));
            Keyboard.Press("o");
            Delay.Milliseconds(3000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}'.", new RecordItemIndex(7));
            Keyboard.Press("{Back}");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationCopy\\Routine\\Copy.mxy'.", new RecordItemIndex(8));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationCopy\\Routine\\Copy.mxy");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(9));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(200);                       

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(10));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(1000);
                        
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(12));
            Keyboard.Press("f");
            Delay.Milliseconds(600);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'r'.", new RecordItemIndex(14));
            Keyboard.Press("r");
            Delay.Milliseconds(1000);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(15));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXCopyMxy.Finish' at Center.", repo.SnapXCopyMxy.FinishInfo, new RecordItemIndex(16));
            repo.SnapXCopyMxy.Finish.Click();
            Delay.Milliseconds(200);
            
            strActualValuesPath = "D:\\Joro\\GIT_Automations\\AutomationCopy\\Reports\\ActualValuesBIG.STA";       //with the folowing 6 lines on this code we finding (we have the path) and reading into these files (ActualVAlues.STA and hardcodedVAlues.STA)            
            string strHardcodedValuesPath = "D:\\Joro\\GIT_Automations\\AutomationCopy\\Reports\\HardcodedValuesBIG.STA";

            string[] readActualLines = File.ReadAllLines(strActualValuesPath);
            int iActualResuls = readActualLines.Length;

            string[] readHardcodedLines = File.ReadAllLines(strHardcodedValuesPath);
            int ihardcodedResults = readHardcodedLines.Length;

            bool bBigNothingBADsoFAR = true;                   //1-this code has been added to avoid after every compairing values to write Sucessfully Performed in the Report.
            for (int i = 0; i < iActualResuls; i++)
            {
                if (i >= ihardcodedResults)
                    break;

                double dActualValue;
                double dHardcodedValue;
                Double.TryParse(readActualLines[i], out dActualValue);
                Double.TryParse(readHardcodedLines[i], out dHardcodedValue);


                double dResult = Mathematics.GetNunbertsAbsDifference(dActualValue, dHardcodedValue);

                if (dResult < 0.0002)
                {                    
                }
                else
                {
                    bBigNothingBADsoFAR = false;            //2-this code has been added to avoid after every compairing values to write Sucessfully performed in the Report.
                    ReportAction.NegativeReport(dActualValue, dHardcodedValue, i);
                }
            }

            if (bBigNothingBADsoFAR)                        //3-this code has been added to avoid after every compairing values to write Sucessfully performed in the Report.
                ReportAction.PositiveReport();

            Delay.Milliseconds(200);

            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXCopyMxy.BIGtoFFW' at Center.", repo.SnapXCopyMxy.BIGtoFFWInfo, new RecordItemIndex(17));
            repo.SnapXCopyMxy.BIGtoFFW.Click();
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at 882;7.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(18));
            repo.SnapXUntitled.TitleBar.Click("882;7");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(19));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(1000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(21));
            Keyboard.Press("f");
            Delay.Milliseconds(600);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'o'.", new RecordItemIndex(23));
            Keyboard.Press("o");
            Delay.Milliseconds(3000);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}'.", new RecordItemIndex(25));
            Keyboard.Press("{Back}");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationCopy\\Routine\\CopyFFW.mxy'.", new RecordItemIndex(26));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationCopy\\Routine\\CopyFFW.mxy");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(27));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(200);

            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(28));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(30));
            Keyboard.Press("f");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'r'.", new RecordItemIndex(32));
            Keyboard.Press("r");
            Delay.Milliseconds(1000);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(33));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Inspection.ButtonOK' at Center.", repo.Inspection.ButtonOKInfo, new RecordItemIndex(34));
            repo.Inspection.ButtonOK.Click();
            Delay.Milliseconds(10000);


            strActualValuesFFWPath = "D:\\Joro\\GIT_Automations\\AutomationCopy\\Reports\\ActualValuesFFW.STA";    
            string strHardcodedActualVAluesFFWPath = "D:\\Joro\\GIT_Automations\\AutomationCopy\\Reports\\HardcodedValuesFFW.STA";

            string[] strReadActualFFWLines = File.ReadAllLines(strActualValuesFFWPath);
            int iActualFFWResult = strReadActualFFWLines.Length;

            string[] strReadHardcodedFFWLines = File.ReadAllLines(strHardcodedActualVAluesFFWPath);
            int iHardcodedFFWResult = strReadHardcodedFFWLines.Length;
            
            bool bFFWNothingBADsoFAR = true;           //1-this code has been added to avoid after every compairing values to write Sucessfully performed in the Report

            for (int i = 0; i < iActualFFWResult; i++)
            {
                if (i >= iHardcodedFFWResult)
                    break;
            
                double dFFWActualValue;
                double dFFWHardcodedVale;

                Double.TryParse(strReadActualFFWLines [i], out dFFWActualValue);
                Double.TryParse(strReadHardcodedFFWLines[i], out dFFWHardcodedVale);

                double dFFWResult = Mathematics.GetNunbertsAbsDifference(dFFWActualValue, dFFWHardcodedVale);

                if (dFFWResult < 0.0002)
                {
                }
                else
                {
                    bFFWNothingBADsoFAR = false;            //2-this code has been added to avoid after every compairing values to write Sucessfully performed in the Report.
                    ReportAction.NegativeReport(dFFWActualValue, dFFWHardcodedVale, i);
                }
            }

            if (bFFWNothingBADsoFAR)                        //3-this code has been added to avoid after every compairing values to write Sucessfully performed in the Report.
                ReportAction.PositiveReport();

            Delay.Milliseconds(1000);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXCopyMxy.FFWtoBIG' at Center.", repo.SnapXCopyMxy.FFWtoBIGInfo, new RecordItemIndex(35));
            repo.SnapXCopyMxy.FFWtoBIG.Click();
            Delay.Milliseconds(1000);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(36));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(1000);

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(38));
            Keyboard.Press("f");
            Delay.Milliseconds(600);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'n'.", new RecordItemIndex(40));
            Keyboard.Press("n");
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ButtonGo' at 47;149.", repo.SnapXUntitled.ButtonGoInfo, new RecordItemIndex(0));
            repo.SnapXUntitled.ButtonGo.Click("47;149");
            Delay.Milliseconds(2000);

            /////////works fine///////////

        }

            #region Image Feature Data
            #endregion
        }
    }
#pragma warning restore 0436

