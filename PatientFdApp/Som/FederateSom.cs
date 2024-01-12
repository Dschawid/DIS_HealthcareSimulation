// **************************************************************************************************
//		FederateSom
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
/// This class is extended from the object model of RACoN API
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using PatientFdApp.Som;


namespace PatientFdApp.Som
{
    public class FederateSom : Racon.ObjectModel.CObjectModel
    {
        #region Declarations
        #region SOM Declaration
        public PatientFdApp.Som.CPatientOC PatientOC;
        public PatientFdApp.Som.CDoctorOC DoctorOC;
        public PatientFdApp.Som.CTreatmentLogIC TreatmentLogIC;
        #endregion
        #endregion //Declarations

        #region Constructor
        public FederateSom() : base()
        {
            // Construct SOM
            PatientOC = new PatientFdApp.Som.CPatientOC();
            AddToObjectModel(PatientOC);
            DoctorOC = new PatientFdApp.Som.CDoctorOC();
            AddToObjectModel(DoctorOC);
            TreatmentLogIC = new PatientFdApp.Som.CTreatmentLogIC();
            AddToObjectModel(TreatmentLogIC);
        }
        #endregion //Constructor
    }
}
