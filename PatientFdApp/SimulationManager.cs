// **************************************************************************************************
//		CSimulationManager
//
//		generated
//			by		: 	Simulation Generator (SimGe) v.0.3.3
//			at		: 	Sunday, December 31, 2023 12:22:33 PM
//		compatible with		: 	RACoN v.0.0.2.5
//
//		copyright		: 	(C) 
//		email			: 	
// **************************************************************************************************
/// <summary>
/// The Simulation Manager manages the (multiple) federation execution(s) and the (multiple instances of) joined federate(s).
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
using System.ComponentModel;
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using PatientFdApp.Som;


namespace PatientFdApp
{
    public class CSimulationManager
    {
        #region Declarations
        // Communication layer related structures
        public CPatientFdApp federate; //Application-specific federate 
                                    // Local data structures
                                    // TODO: user-defined data structures are declared here
        public bool IsSimulationOn = false;
        public BindingList<CDoctorHlaObject> DoctorObjects;
        public BindingList<CPatientHlaObject> PatientObjects;

        #endregion //Declarations

        #region Constructor
        public CSimulationManager()
        {
            // Initialize the application-specific federate
            federate = new CPatientFdApp(this);
            // Initialize the federation execution
            federate.FederationExecution.Name = "HealthcareSimulatorr";
            federate.FederationExecution.FederateType = "PatientFederate";
            federate.FederationExecution.ConnectionSettings = "rti://127.0.0.1";
            // Handle RTI type variation
            initialize();

            DoctorObjects = new BindingList<CDoctorHlaObject>();
            PatientObjects = new BindingList<CPatientHlaObject>();
        }
        #endregion //Constructor

        #region Methods
        // Handles naming variation according to HLA specification
        private void initialize()
        {
            switch (federate.RTILibrary)
            {
                case RTILibraryType.HLA13_DMSO:
                case RTILibraryType.HLA13_Portico:
                case RTILibraryType.HLA13_OpenRti:
                    federate.Som.PatientOC.Name = "objectRoot.Patient";
                    federate.Som.PatientOC.PrivilegeToDelete.Name = "privilegeToDelete";
                    federate.Som.DoctorOC.Name = "objectRoot.Doctor";
                    federate.Som.DoctorOC.PrivilegeToDelete.Name = "privilegeToDelete";
                    federate.Som.TreatmentLogIC.Name = "interactionRoot.TreatmentLog";
                    federate.FederationExecution.FDD = @"C:\Users\bbyvj\Desktop\1531\HealthcareSimulation\PatientFdApp\HealthcareSimulatorrFOM.fed";
                    break;
                case RTILibraryType.HLA1516e_Portico:
                case RTILibraryType.HLA1516e_OpenRti:
                    federate.Som.PatientOC.Name = "HLAobjectRoot.Patient";
                    federate.Som.PatientOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
                    federate.Som.DoctorOC.Name = "HLAobjectRoot.Doctor";
                    federate.Som.DoctorOC.PrivilegeToDelete.Name = "HLAprivilegeToDeleteObject";
                    federate.Som.TreatmentLogIC.Name = "HLAinteractionRoot.TreatmentLog";
                    federate.FederationExecution.FDD = @"C:\Users\bbyvj\Desktop\1531\HealthcareSimulation\PatientFdApp\HealthcareSimulatorrFOM.xml";
                    break;
            }
        }
        #endregion //Methods
    }
}
