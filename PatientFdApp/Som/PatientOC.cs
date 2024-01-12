// **************************************************************************************************
//		CPatientOC
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
    public class CPatientOC : HlaObjectClass
    {
        #region Declarations
        public HlaAttribute PName;
        public HlaAttribute Chance;
        public HlaAttribute Fluids;
        public HlaAttribute PId;
        #endregion //Declarations

        #region Constructor
        public CPatientOC() : base()
        {
            // Initialize Class Properties
            Name = "HLAobjectRoot.Patient";
            ClassPS = PSKind.PublishSubscribe;

            // Create Attributes
            // PName
            PName = new HlaAttribute("PName", PSKind.PublishSubscribe);
            Attributes.Add(PName);
            // Chance
            Chance = new HlaAttribute("Chance", PSKind.PublishSubscribe);
            Attributes.Add(Chance);
            // Fluids
            Fluids = new HlaAttribute("Fluids", PSKind.PublishSubscribe);
            Attributes.Add(Fluids);
            // PId
            PId = new HlaAttribute("PId", PSKind.PublishSubscribe);
            Attributes.Add(PId);
        }
        #endregion //Constructor
    }
}
