using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoctorFdApp.LocalData
{
    public class CPatient
    {
        public int PId;
        public string PName;
        public int Fluids; // in litres
        public bool Chance;
        public static int PCounter;
        public CPatient()
        {
            PCounter++;
            PId = PCounter;
            PName = "Patient " + PCounter;
            Fluids = 3;
            Chance = true;
        }

        public void success(int chance)
        {
            Random rnd = new Random();
            int successChance = rnd.Next(1, 101);
            if (successChance <= chance)
                Chance = true;
            else
            {
                Chance = false;
                Fluids--;
            }

        }
    }
}
