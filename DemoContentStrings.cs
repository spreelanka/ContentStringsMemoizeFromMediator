using System;
using System.Reflection;
using System.Linq;

namespace ContentStringsMemoizeFromMediator
{
	public static class DemoContentStrings
	{
	
		static LocaleTypes _Locale = LocaleTypes.One;


		public static LocaleTypes Locale {
			get {
				return _Locale;
			}
			set {
				if (_Locale != value) {
					_Locale = value;
					Loading.Clear ();
				}
			}
		}

		public static class ReflectionHelper
		{
			public static void Clear (Type type)
			{
				foreach (var propInfo in type.GetRuntimeProperties()) {
					propInfo.SetValue (null, null);
				}
			}
		}

		public static class Loading
		{
			//this will null ALL public properties.
			//if you have some reason to not do that clear them manually below
			public static void Clear ()
			{
				ReflectionHelper.Clear (typeof(Loading));
				LoadingSubclass.Clear ();
			}

			static string _Text;

			public static string Text {
				get {
					if (_Text == null)
						_Text = DataMediator.GetString ("Text", Locale);
					return _Text;
				}
				private set{ _Text = value; }
			}


			public static class LoadingSubclass
			{
				public static void Clear ()
				{
					ReflectionHelper.Clear (typeof(LoadingSubclass));
				}

				static string _Text2;

				public static string Text2 {
					get {
						if (_Text2 == null)
							_Text2 = DataMediator.GetString ("Text2", Locale);
						return _Text2;
					}
					private set{ _Text2 = value; }
				}
			}
		}


	}

	public enum LocaleTypes
	{
		notSelected,
		One,
		Two
	}
}

