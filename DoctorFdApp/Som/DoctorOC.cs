// **************************************************************************************************
//		CDoctorOC
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
using DoctorFdApp.Som;


namespace DoctorFdApp.Som
{
  public class CDoctorOC : HlaObjectClass
  {
    #region Declarations
    public HlaAttribute Action;
    public HlaAttribute DName;
    #endregion //Declarations
    
    #region Constructor
    public CDoctorOC() : base()
    {
      // Initialize Class Properties
      Name = "HLAobjectRoot.Doctor";
      ClassPS = PSKind.PublishSubscribe;
      
      // Create Attributes
      // Action
      Action = new HlaAttribute("Action", PSKind.PublishSubscribe);
      Attributes.Add(Action);
      // DName
      DName = new HlaAttribute("DName", PSKind.PublishSubscribe);
      Attributes.Add(DName);
    }
    #endregion //Constructor
  }
}
