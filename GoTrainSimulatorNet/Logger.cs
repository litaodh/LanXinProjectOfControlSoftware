using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Luster.TrafficSeries
{
    sealed class Logger
    {
        private static string logFilePath = System.Windows.Forms.Application.StartupPath;
        private static object obj = new object();
        static Logger()
        {
            string logPath = Path.Combine(logFilePath, "Log");
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }
        }

        public static string LogFilePath
        {
            get
            {
                string logPath = Path.Combine(logFilePath, "Log");
                if (!Directory.Exists(logPath))
                {
                    Directory.CreateDirectory(logPath);
                }
                string logFile = Path.Combine(logPath + DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
                if (!File.Exists(logFile))
                {
                    File.Create(logFile).Close();
                }

                return logFile;
            }
        }

        public static int GetLineNum()
        {
            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(1, true);
            return st.GetFrame(0).GetFileLineNumber();
        }

        public static string GetCurSourceFileName()
        {
            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(1, true);
            return st.GetFrame(0).GetFileName();
        }

        public static string GetCurSourceFileInfo()
        {
            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(1, true);
            return String.Format("{0}:{1}", st.GetFrame(0).GetFileName(), st.GetFrame(0).GetFileLineNumber());
        }
        //public void AddLog(string logContext)
        //{
        //    LogInfo logInfo = new LogInfo(logContext);
        //    this.AddLog(logInfo);
        //}
        //public void AddLog(LogInfo logInfo)
        //{
        //    lock (obj)
        //    {
        //        using (FileStream stream = File.Open(this.LogFilePath, FileMode.Open))
        //        using (StreamWriter writer = new StreamWriter(stream))
        //        {
        //            stream.Seek(0, SeekOrigin.End);
        //            writer.WriteLine(String.Format("{0}--{1}", logInfo.LogDateTime.ToLongTimeString(), logInfo.LogContext));
        //            writer.Close();
        //            stream.Close();
        //        }
        //    }
        //}

        public static void Fatal(string message, string codePosition = "", string errorCode = "")
        {
            lock (obj)
            using (FileStream stream = File.Open(LogFilePath, FileMode.Open))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        stream.Seek(0, SeekOrigin.End);
                        DateTime nowTime = DateTime.Now;
                        string tmpInfo = String.Format("[{0}][{1}][Fatal][{2}][{3}][{4}]", nowTime.ToLongDateString(),
                            nowTime.ToLongTimeString(), codePosition, errorCode, message);
                        writer.WriteLine(tmpInfo);
                    }
                }
        }


        public static void Error(string message, string codePosition = "", string errorCode = "")
        {
            lock (obj)
            using (FileStream stream = File.Open(LogFilePath, FileMode.Open))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        stream.Seek(0, SeekOrigin.End);
                        DateTime nowTime = DateTime.Now;
                        string tmpInfo = String.Format("[{0}][{1}][Error][{2}][{3}][{4}]", nowTime.ToLongDateString(),
                            nowTime.ToLongTimeString(), codePosition, errorCode, message);
                        writer.WriteLine(tmpInfo);
                    }
                }
        }

        public static void Warn(string message, string codePosition = "")
        {
            lock (obj)
            using (FileStream stream = File.Open(LogFilePath, FileMode.Open))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        stream.Seek(0, SeekOrigin.End);
                        DateTime nowTime = DateTime.Now;
                        string tmpInfo = String.Format("[{0}][{1}][Warn][{2}][{3}]", nowTime.ToLongDateString(),
                            nowTime.ToLongTimeString(), codePosition, message);
                        writer.WriteLine(tmpInfo);
                    }
                }
        }

        public static void Info(string message, string codePosition = "")
        {
            lock (obj)
            using (FileStream stream = File.Open(LogFilePath, FileMode.Open))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        stream.Seek(0, SeekOrigin.End);
                        DateTime nowTime = DateTime.Now;
                        string tmpInfo = String.Format("[{0}][{1}][Info][{2}][{3}]", nowTime.ToLongDateString(),
                            nowTime.ToLongTimeString(), codePosition, message);
                        writer.WriteLine(tmpInfo);
                    }
                }
        }

        [Conditional("DEBUG")]
        public static void Debug(string message, string codePosition = "")
        {
            lock (obj)
            using (FileStream stream = File.Open(LogFilePath, FileMode.Open))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        stream.Seek(0, SeekOrigin.End);
                        DateTime nowTime = DateTime.Now;
                        string tmpInfo = String.Format("[{0}][{1}][Debug][{2}][{3}]", nowTime.ToLongDateString(),
                            nowTime.ToLongTimeString(), codePosition, message);
                        writer.WriteLine(tmpInfo);
                    }
                }
        }
    }
}
