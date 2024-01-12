// **************************************************************************************************
//		CDoctorFdApp
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
/// The application specific federate that is extended from the Generic Federate Class of RACoN API
/// </summary>

// System
using System;
using System.Collections.Generic; // for List
// Racon
using Racon;
using Racon.RtiLayer;
// Application
using DoctorFdApp.Som;

namespace DoctorFdApp
{
  public partial class CDoctorFdApp : Racon.CGenericFederate
  {
    #region Declarations
    public DoctorFdApp.Som.FederateSom Som;
    #endregion //Declarations
    
    #region Constructor
    public CDoctorFdApp() : base(RTILibraryType.HLA1516e_OpenRti)
    {
      // Create and Attach Som to federate
      Som = new DoctorFdApp.Som.FederateSom();
      SetSom(Som);
    }
    #endregion //Constructor
  
  }
}
