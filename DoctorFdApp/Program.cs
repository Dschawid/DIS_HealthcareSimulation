using System;
using System.Collections.Generic;
using System.Linq;

using Racon;
using Racon.RtiLayer;

using DoctorFdApp.Som;

using DoctorFdApp.LocalData;

namespace DoctorFdApp
{
    class Program
    {
        static CSimulationManager manager = new CSimulationManager();
     //   static CShip ship = new CShip(); // Own ship
        static bool Terminate = false; // exit switch for app
        public static int patientsPresent = 0;
        public static int patientsAvailable = 0;
        public static int extractionsPerformed = 0;
        public static int reacting = 0;
        public static bool startExtracting = false;
        public static int nameUpdate = 0;
        public static double startTime;
        public static bool finished = false;

        static void Main(string[] args)
        {

            PrintVersion();

            // Racon Initialization
            // Getting the information/debugging messages from RACoN
            manager.federate.StatusMessageChanged += Federate_StatusMessageChanged;
            manager.federate.LogLevel = LogLevel.WARN;




            CDoctorHlaObject encapsulatedDoctorObject = new CDoctorHlaObject(manager.federate.Som.DoctorOC);
            encapsulatedDoctorObject.Doctor = new CDoctor();
            encapsulatedDoctorObject.Doctor.DName = "Doctor Who";
            manager.DoctorObjects.Add(encapsulatedDoctorObject);


            // Federation Initialization
            // connect, create and join to federation execution, declare object model
            if (manager.federate.InitializeFederation(manager.federate.FederationExecution))
            {

                Console.WriteLine("Federation was connected, created, joined, and had federate capabilities declared.\n");
            }
        


            // FM Test
            manager.federate.ListFederationExecutions();





            while (true)
            {
                if (manager.federate.FederateState.HasFlag(Racon.FederateStates.JOINED))
                    manager.federate.Run();

                if (!startExtracting && patientsAvailable > 0 && nameUpdate == patientsAvailable )
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Doctor Who is ready to accept the patients");
                    Console.WriteLine(manager.federate.SendMessage("Doctor Who is ready to accept the patients", 0));
                    Thread.Sleep(400);
                    Console.ResetColor();
                    startExtracting = true;
                }

                if (finished)
                    break;
            }

            manager.federate.DeleteObjectInstance(manager.DoctorObjects[0], Tags.deleteRemoveTag);
            // Leave and destroy federation execution
            bool result2 = manager.federate.FinalizeFederation(manager.federate.FederationExecution);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void PrintVersion()
        {
            Console.WriteLine(
              "---------------------------------------------------------------------------\n"
              + "                        " + "DoctorFdApp v1.0.0" + "\n"
              + "---------------------------------------------------------------------------");
        }

        public static string ExtractMessage(string name, int action)
        {
            if (action == 1)
                return "" + name + " goes for leg joint -> Stay steady!\nSuccess Chance = " + (100 - action * 15) + "%";
            else if (action == 2)
                return "" + name + " goes for lateral muscle joint -> Keep Your arm flexed at all cost!\nSuccess Chance = " + (100 - action * 15) + "%";
            else if (action == 3)
                return "" + name + " continues with hip abduction-> Pain can be inbareable, try to not twitch!\nSuccess Chance  = " + (100 - action * 15) + "%";
            else if (action == 4)
                return "" + name + " goes for lung fluid sucktion -> Very dangerious, doctor needs to be careful!\nSuccess Chance  = " + (100 - action * 15) + "%";
            else if (action == 5)
                return "" + name + " goes for spinal cord -> a spinal cord requires great precision!\nSuccess Chance  = " + (100 - action * 15) + "%";
            else return null;
        }

        private static void Federate_StatusMessageChanged(object sender, EventArgs e)
        {
            Console.ResetColor();
            Console.WriteLine((sender as CDoctorFdApp).StatusMessage);
        }



    }

}
