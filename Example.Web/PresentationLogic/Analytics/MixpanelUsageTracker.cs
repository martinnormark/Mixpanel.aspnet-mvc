using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.Web.PresentationLogic.Analytics
{
	public class MixpanelUsageTracker
	{
#if DEBUG
		/// <summary>
		/// Test site
		/// </summary>
		public const string Token = "TOKEN";
#else
		/// <summary>
		/// Production site
		/// </summary>
		public const string Token = "TOKEN";
#endif
	}
}