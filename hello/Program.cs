using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace hello
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static int isLoad = 0;
        public static StreamWriter writer;
        public static DateTime startTime;

        public static void loadFile(String name)
        {
            if (isLoad == 1)
                return;
            else
                isLoad = 1;
            //Console.WriteLine(name);
            name = name.Replace("/","-");
            name = name.Replace(":","：");
            //Console.WriteLine(name);
            writer = new StreamWriter("results/result " + name + ".txt",false);
            
            
            writer.WriteLine("参与时间:" + DateTime.Now);
            writer.WriteLine("编号  ---  系统时间  ---  点击总数 ---  结束原因（0：破了, 1：收账）  ---  前面所有气球的总分  ---  1  ---  2  ---  3 ...");
            writer.WriteLine("---------------------");
            writer.Flush();
        }
    }
}
