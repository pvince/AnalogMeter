using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Microsoft.VisualBasic.Devices;

namespace AnalogGauges
{
    class StatWrapper
    {
        #region statType Enum and related functions
        public enum statType
        {
            CPU,
            CPU_Utility,
            GPU,
            RAM,
            FileCount,
            DiskActivity,
            TimingTestLines
        }

        public static String[] getStatTypeNames()
        {
            return Enum.GetNames(typeof(statType));
        }


        public static statType getStatType(String name)
        {
            return (statType)Enum.Parse(typeof(statType), name);
        }
        #endregion

        private PerformanceCounter statCounter;
        private ComputerInfo compInfo;

        private statType curStatType;
        private Int32 curValueIndex = 0;
        private Int32[] valueArray;

        public StatWrapper(statType type, int valueAvgCount)
        {
            curStatType = type;

            // Using the just set curStatType, initialize the counter for that stat.
            initializeCounter();

            // Create & Populate the value array used for averaging stat readings.
            valueArray = new int[valueAvgCount];

            for (int i = 0; i < valueArray.Length; i++)
            {
                getValue(); // Fill the valueArray with initial data.
            }
        }


        private void initializeCounter()
        {
            // Any stat that uses PerformanceCounter will need to be initialized.
            switch (curStatType)
            {
                case statType.CPU:
                    statCounter = new PerformanceCounter();
                    statCounter.CategoryName = "Processor Information";
                    statCounter.CounterName = "% Processor Time";
                    statCounter.InstanceName = "_Total";
                    break;
                case statType.CPU_Utility:
                    statCounter = new PerformanceCounter();
                    statCounter.CategoryName = "Processor Information";
                    statCounter.CounterName = "% Processor Utility";
                    statCounter.InstanceName = "_Total";
                    break;
                case statType.GPU:
                    statCounter = new PerformanceCounter();
                    statCounter.CategoryName = "NVIDIA GPU";
                    statCounter.CounterName = "% GPU Usage";
                    statCounter.InstanceName = "#0 NVIDIA RTX A2000 8GB Laptop GPU (id=1, NVAPI ID=256)";
                    break;
                case statType.RAM:
                    // Totally cheating here, using VisualBasic libraries to grab the RAM information.
                    // http://stackoverflow.com/questions/105031/c-sharp-how-do-you-get-total-amount-of-ram-the-computer-has
                    compInfo = new ComputerInfo();
                    break;
               case statType.DiskActivity:
                    statCounter = new PerformanceCounter();
                    statCounter.CategoryName = "LogicalDisk";
                    statCounter.CounterName = "% Disk Time";
                    statCounter.InstanceName = "_Total";
                    break;
            }
        }

        /// <summary>
        /// Gets an averaged value for the passed in PerformanceCounter.
        /// </summary>
        /// <returns>Returns an averaged value for the passed in PerformanceCounter 
        ///          averaged over valueAvgCount readings.</returns>
        public int getValue()
        {
            int currentValue = 0;
            switch (curStatType)
            {
                case statType.CPU:
                case statType.CPU_Utility:
                case statType.GPU:
                    currentValue = Math.Min(Convert.ToInt32(statCounter.NextValue()), 100);
                    break;
                case statType.RAM:
                    currentValue = 100 - Convert.ToInt32( ((float)compInfo.AvailablePhysicalMemory / (float)compInfo.TotalPhysicalMemory) * 100);
                    break;
                case statType.FileCount:
                    double fileCount = AGTools.getDirectorySize("Z:\\SCM\\2012.0.0\\ProductInstallers"); //System.IO.Directory.GetFiles("Z:\\SCM\\2012.0.0\\ProductInstallers", "*", System.IO.SearchOption.AllDirectories).Length;
                    double maxSize =  4000000000.0;
                    currentValue = Convert.ToInt32((fileCount / maxSize) * 100.0);
                    break;
               case statType.DiskActivity:
                    currentValue = Convert.ToInt32(statCounter.NextValue());
                    if (currentValue > 100)
                       currentValue = 100;
                    break;
                case statType.TimingTestLines:
                    int currentLines = AGTools.getFileLineCount(@"Z:\SCM\PRIVATE\BuildInProgress\timingTest.log");
                    if(currentLines > 0)
                    {
                        currentValue = Convert.ToInt32((currentLines / 29.0) * 100);
                    }
                    break;
               default:
                    currentValue = Convert.ToInt32(statCounter.NextValue());
                    break;
            }
            if (currentValue < 0 || currentValue > 100)
                throw new Exception("Invalid currentValue: " + currentValue);

            valueArray[curValueIndex++ % valueArray.Length] = currentValue;
            return AGTools.averageArray(valueArray);
        }


    }
}
