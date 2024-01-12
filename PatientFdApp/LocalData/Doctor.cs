using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientFdApp.LocalData
{
    public class CDoctor
    {
        public string DName;
        public int Action;

        public CDoctor()
        {
            DName = "";
            Action = 0;
        }

        public void remove()
        {
            Random rnd = new Random();
            Action = rnd.Next(1, 6);
        }
    }
}
