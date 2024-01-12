using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Racon;
using Racon.RtiLayer;

using PatientFdApp.Som;

using PatientFdApp;
using PatientFdApp.LocalData;
using System.Threading;

namespace PatientFdApp
{
    class Program
    {
        static CSimulationManager manager = new CSimulationManager();
        //   static CShip ship = new CShip(); // Own ship
        static bool Terminate = false; // exit switch for app
        public static int successChance = 0;
        public static bool treatmentStart = false;
        public static int treatments = 0;
        public static int updates = 0;
        public static double startTime;
        public static bool finished = false;
        static void Main(string[] args)
        {
            PrintVersion();

            // Racon Initialization
            // Getting the information/debugging messages from RACoN
            manager.federate.StatusMessageChanged += Federate_StatusMessageChanged;
            manager.federate.LogLevel = LogLevel.ALL;

            //Object Initialization
            Random rnd = new Random();
            CPatientHlaObject encapsulatedPatientObject1 = new CPatientHlaObject(manager.federate.Som.PatientOC);
            encapsulatedPatientObject1.Patient.PName = "Patient " + rnd.Next(1,6);
            manager.PatientObjects.Add(encapsulatedPatientObject1);






            // Federation Initialization
            // connect, create and join to federation execution, declare object model
            bool result = manager.federate.InitializeFederation(manager.federate.FederationExecution);


            // FM Test
            manager.federate.ListFederationExecutions();
            treatmentStart = false;


            bool req = true;
            int x = 0;
            // process rti events (callbacks) and tick
            while (true)
            {
                if (manager.federate.FederateState.HasFlag(Racon.FederateStates.JOINED))
                    manager.federate.Run();

                if (finished)
                    break;


            }

            manager.federate.DeleteObjectInstance(manager.PatientObjects[0], Tags.deleteRemoveTag);
            // Leave and destroy federation execution
            bool result2 = manager.federate.FinalizeFederation(manager.federate.FederationExecution);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }


        private static void PrintVersion()
        {
            Console.WriteLine(
              "---------------------------------------------------------------------------\n"
              + "                        " + "PatientFdApp v1.0.0" + "\n"
              + "---------------------------------------------------------------------------");
        }

        private static void Federate_StatusMessageChanged(object sender, EventArgs e)
        {
            Console.ResetColor();
            Console.WriteLine((sender as CPatientFdApp).StatusMessage);
        }
    }
}
