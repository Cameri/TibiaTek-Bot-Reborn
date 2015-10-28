using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TibiaTekBot
{

    class Log
    {
        Tibia client = new Tibia();
        public string result = "";
        public void SaveLog(DateTime date,string logtype,string LogTextDetails)
        {
            
            string path = Environment.CurrentDirectory + "\\Logs";
            string playername = client.LocalPlayer.Name;

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path + "\\" + playername + ".Logs.txt"))
            {
                // Create a file to write to.
                File.Create(path + "\\" + playername + ".Logs.txt").Close();

            }
            using (StreamWriter sw = new StreamWriter(path + "\\" + playername + ".Logs.txt", true))
            {
                result = string.Format("{0}     Log Type: {1}     {2}", DateTime.Now, logtype, LogTextDetails);
                sw.WriteLine(result);
            }
            
        }
    }
}
