using System;

namespace ContentStringsMemoizeFromMediator
{
	public static class DataMediator
	{
		public static string GetString (string key, LocaleTypes locale)
		{
			return string.Format ("{0} {1}", key, locale.ToString ());
		}
	}
}

