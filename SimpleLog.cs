using System;
using System.Collections.Generic;
using System.Text;

namespace dis_lab_1
{
    public class SimpleLog
    {
        public void Write(string type, string msg)
        {
            DateTime currtime = DateTime.Now;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"app.log", true))
            {
                string tmptxt = String.Format("{0:yyMMdd hh:mm:ss} {1} {2}", currtime, type, msg);
                file.WriteLine(tmptxt);
                file.Close();
            }
        }
        public string Read()
        {
            string text = System.IO.File.ReadAllText(@"app.log");
            return text;
        }
    }
}
