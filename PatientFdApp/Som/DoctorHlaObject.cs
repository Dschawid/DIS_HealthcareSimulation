// **************************************************************************************************
//		CDoctorHlaObject
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
/// This is a wrapper class for local data structures. This class is extended from the object model of RACoN API
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using PatientFdApp.Som;
using PatientFdApp.LocalData;


namespace PatientFdApp.Som
{
    public class CDoctorHlaObject : HlaObject
    {
        #region Declarations
        // TODO: Declare your local object structure here
        // Your_LocalData_Type Data;
        public CDoctor Doctor;


        #endregion //Declarations

        #region Constructor
        public CDoctorHlaObject(HlaObjectClass _type) : base(_type)
        {
            // TODO: Instantiate local data here
            // var Data = new Your_LocalData_Type();
            Doctor = new CDoctor();
        }
        // Copy constructor - used in callbacks
        public CDoctorHlaObject(HlaObject _obj) : base(_obj)
        {
            // TODO: Instantiate local data here
            // var Data = new Your_LocalData_Type();
            Doctor = new CDoctor();
        }
        #endregion //Constructor
    }
}
