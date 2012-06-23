﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BackupV2
{
    public class Error_Logging
    {
        public void MakeLog(string ex)
        {
            FileStream fs = new FileStream(Environment.GetEnvironmentVariable("APPDATA") + "\\returnzork\\Error.log", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("\r\n" + DateTime.Now.ToString() + ex);
            sw.Close();
            fs.Close();
        }
    }
}