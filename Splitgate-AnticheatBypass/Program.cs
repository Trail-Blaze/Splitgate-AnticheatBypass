using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Args_Dumper
{
    class Program
    {

        public static string GetArgs(string[] args)
        {
            string final = "";
            foreach (string arg in args)
            {
                final += arg + " ";
            }
            return final;
        }

        public static bool ArgsInvalid(string[] args)
        {
            if (args.Length == 0)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {

            if (ArgsInvalid(args))
            {
                Process.Start("steam://rungameid/677620");
                Environment.Exit(0);
            }
            
            var Splitgate = new Process();
            Splitgate.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\PortalWars\\Binaries\\Win64\\PortalWars-Win64-Shipping.exe";
            Splitgate.StartInfo.Arguments = GetArgs(args);

            Splitgate.Start();

            Splitgate.WaitForExit();
        }
    }
}
