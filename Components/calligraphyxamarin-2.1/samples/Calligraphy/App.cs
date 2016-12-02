using System;
using Android.App;
using Android.Runtime;
using UK.CO.Chrisjenx.Calligraphy;

namespace CalligraphySample
{
	[Application]
	public class App : Application
	{
		public App(IntPtr handle, JniHandleOwnership transfer)
			: base(handle, transfer) {}

		public override void OnCreate ()
		{
			base.OnCreate ();

			CalligraphyConfig.InitDefault(new CalligraphyConfig.Builder()
				.SetDefaultFontPath("fonts/SudegnakNo2.ttf")
				.SetFontAttrId(Resource.Attribute.fontPath)
				.Build());
		}
	}
}

