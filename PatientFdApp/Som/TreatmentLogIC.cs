// **************************************************************************************************
//		CTreatmentLogIC
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
    public class CTreatmentLogIC : HlaInteractionClass
    {
        #region Declarations
        public HlaParameter litres;
        public HlaParameter message;
        public HlaParameter type;
        #endregion //Declarations

        #region Constructor
        public CTreatmentLogIC() : base()
        {
            // Initialize Class Properties
            Name = "HLAinteractionRoot.TreatmentLog";
            ClassPS = PSKind.PublishSubscribe;

            // Create Parameters
            // litres
            litres = new HlaParameter("litres");
            Parameters.Add(litres);
            // message
            message = new HlaParameter("message");
            Parameters.Add(message);
            // type
            type = new HlaParameter("type");
            Parameters.Add(type);
        }
        #endregion //Constructor
    }
}
