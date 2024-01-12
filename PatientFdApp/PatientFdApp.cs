// **************************************************************************************************
//		CPatientFdApp
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
/// The application specific federate that is extended from the Generic Federate Class of RACoN API. This file is intended for manual code operations.
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using PatientFdApp.Som;

namespace PatientFdApp
{
  public partial class CPatientFdApp : Racon.CGenericFederate
  {
    #region Manually Added Code
    
    // Local Data
    private CSimulationManager manager;
    
    #region Constructor
    public CPatientFdApp(CSimulationManager parent) : this()
    {
      manager = parent; // Set simulation manager
      // Create regions manually
    }
        #endregion //Constructor

        public bool SendMessage(string txt, int litres)
        {
            HlaInteraction interaction = new Racon.RtiLayer.HlaInteraction(Som.TreatmentLogIC, "TreatmentLog");

            // Add Values
            interaction.AddParameterValue(Som.TreatmentLogIC.type, 1); // int
            interaction.AddParameterValue(Som.TreatmentLogIC.message, txt); // String
            interaction.AddParameterValue(Som.TreatmentLogIC.litres, litres); // int


            // Send interaction
            return (SendInteraction(interaction, "Patients finished treatments."));
        }

        public void UpdateAll(CPatientHlaObject patient)
        {
            // Add Values
            patient.AddAttributeValue(Som.PatientOC.PId, patient.Patient.PId);
            patient.AddAttributeValue(Som.PatientOC.PName, patient.Patient.PName);
            patient.AddAttributeValue(Som.PatientOC.Fluids, (uint)patient.Patient.Fluids);
            patient.AddAttributeValue(Som.PatientOC.Chance, patient.Patient.Chance);
            UpdateAttributeValues(patient, Tags.updateReflectTag);
        }

        public bool UpdateName(CPatientHlaObject patient)
        {
            patient.AddAttributeValue(Som.PatientOC.PName, patient.Patient.PName);

            return (UpdateAttributeValues(patient, Tags.updateReflectTag));
        }
        public bool UpdateFluids (CPatientHlaObject patient)
        {
            patient.AddAttributeValue(Som.PatientOC.Fluids, (uint)patient.Patient.Fluids);

            return (UpdateAttributeValues(patient, Tags.updateReflectTag));
        }

        public bool UpdateChance(CPatientHlaObject patient)
        {
            patient.AddAttributeValue(Som.PatientOC.Chance, patient.Patient.Chance);

            return (UpdateAttributeValues(patient, Tags.updateReflectTag));
        }


        #endregion

    }
}
