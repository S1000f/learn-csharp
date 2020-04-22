using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {
    class Log {
        public static void printLog(String dirName, String fileName, String contents) {
            DirectoryInfo di = new DirectoryInfo(dirName);
            if(!di.Exists) {
                di.Create();
            }

            using (StreamWriter writer = new StreamWriter(dirName + "\\" + fileName, true)) {
                writer.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] " + contents);
            }
        }
    }
}
