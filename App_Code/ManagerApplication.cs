using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Piranha.WebPages;

/// <summary>
/// Summary description for ManagerApplication
/// </summary>
public class ManagerApplication : AreaRegistration
{
	/// <summary>
	/// Gets the area name.
	/// </summary>
	public override string AreaName {
		get { return "Manager" ; }
	}
		
	/// <summary>
	/// Registers the area.
	/// </summary>
	/// <param name="context">The current context</param>
	public override void RegisterArea(AreaRegistrationContext context) {
		WebPiranha.InitManager(context) ;
	}
}