using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorFdApp.LocalData
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

        public void extract()
        {
            Random rnd = new Random();
            Action = rnd.Next(1, 6);
        }
    }
}
