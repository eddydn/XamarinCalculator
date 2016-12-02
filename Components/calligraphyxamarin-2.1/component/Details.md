This component is a simple binding of the Calligraphy Android library here. As of now it is using **version 2.1** of the Calligraphy repo.

[https://github.com/chrisjenx/Calligraphy](https://github.com/chrisjenx/Calligraphy)

You can find the source code on github here: [GitHub](https://github.com/kevinskrei/XamarinCalligraphy)

## Example ##
---
Step 1:
Add your otf/ttf fonts to your `Assets/fonts` folder.

Step 2:
In your `Application` subclass `OnCreate` method put your `InitDefault` method here like:

    CalligraphyConfig.InitDefault(new CalligraphyConfig.Builder()
				.SetDefaultFontPath("fonts/your_font.ttf")
				.SetFontAttrId(Resource.Attribute.fontPath)
				.Build());

Make sure to replace the "fonts/your_fonts.tff" with your folder/file.

Step 3:
In your `BaseActivity` override `AttachBaseContext` method.
    
    protected override void AttachBaseContext(Android.Content.Context @base)
	{
		base.AttachBaseContext (CalligraphyContextWrapper.Wrap(@base));
	}

Step 4:
Using either direct XML manipulation in your layout files or in your styles, set the `fontPath` attribute like

    <TextView
    	android:layout_width="match_parent"
    	android:layout_height="wrap_content"
    	android:text="This text should be converted to a different font."
    	fontPath="fonts/your_font.ttf" />
    	
 Or you styles
 
 You should now run the app and see your font for the `TextView`'s.
 
## Attribution ##
---
<div>Icons made by <a href="http://www.freepik.com" title="Freepik">Freepik</a> from <a href="http://www.flaticon.com" title="Flaticon">www.flaticon.com</a>             is licensed by <a href="http://creativecommons.org/licenses/by/3.0/" title="Creative Commons BY 3.0">CC BY 3.0</a></div>

Code taken from https://github.com/chrisjenx/Calligraphy
 