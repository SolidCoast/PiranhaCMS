using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Piranha.WebPages;

/// <summary>
/// Summary description for Class1
/// </summary>
public static class WebApplication
{
	/// <summary>
	/// Initializes the webb app.
	/// </summary>
	public static void AppInitialize() {
		WebPiranha.Init() ;
		WebPiranha.InitServices() ;
	}
}