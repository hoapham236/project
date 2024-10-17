using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace HotelManagement_FinalProject
{
    enum Shift { Day, Night }
    internal class Worksession
    {
        public static string calam;
        public static int idb;
        public static string tentn;
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }

        public Shift Shift { get; set; }
        public bool hasChar(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                    continue;
                else
                    return false;
            }
            return true;
        }
        public bool hasDigits(string s)
        {
            foreach (char c in s)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }
        public bool checkname(string s)
        {
            foreach (char c in s)
            {
                if (char.IsLetter(c) || c == ' ')
                    continue;
                else
                    return false;
            }
            return true;
        }

    }
}