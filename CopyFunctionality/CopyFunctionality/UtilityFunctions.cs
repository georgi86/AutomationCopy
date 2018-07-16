using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CopyFunctionality
{

    public class ReportAction
    {
        public static void PositiveReport()
        {                    
                        
            Ranorex.Report.Success("Sucessfully Performed");
        }

        public static void NegativeReport(double dActualValue, double dHardcodedVAlue, int iErrorLine)
        {
            string strErrLine = "Error on Line: " + (iErrorLine + 1);
            Ranorex.Report.Error(strErrLine);

            string strActualValue = "Actual Value is:" + dActualValue;
            Ranorex.Report.Error(strActualValue);

            string strhardcodedValue = "HardcodedValue is:" + dHardcodedVAlue;
            Ranorex.Report.Error(strhardcodedValue);
        }
    }
    public class Mathematics
    {
     
        public static double GetNunbertsAbsDifference(double first, double second)
        {
            double dDiference = first - second;

            return System.Math.Abs(dDiference);
        }

       
      
        
    }
}



