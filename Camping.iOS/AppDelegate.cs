using Foundation;
using UIKit;
using Xamarin.Forms;

using Lottie.Forms.iOS.Renderers;

using FFImageLoading.Forms.Touch;

using UXDivers.Artina.Shared;
using System.Diagnostics;

namespace Camping.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();
			CachedImageRenderer.Init(); // Initializing FFImageLoading
			AnimationViewRenderer.Init(); // Initializing Lottie

			UXDivers.Artina.Shared.GrialKit.Init(new ThemeColors(), "Camping.iOS.GrialLicense");

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			FormsHelper.ForceLoadingAssemblyContainingType(typeof(UXDivers.Effects.Effects));
			FormsHelper.ForceLoadingAssemblyContainingType<UXDivers.Effects.iOS.CircleEffect>();

            LoadDB();
			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
        }


        
        public void LoadDB()
        {
            bool exito;

            NSFileManager fileManager = NSFileManager.DefaultManager;// [NSFileManager defaultManager];
            NSError error;
            //NSArray paths = NSSearchPath.GetDirectories(NSLibraryDirectory, NSUserDomainMask, true);// NSSearchPathForDirectoriesInDomains(NSLibraryDirectory, NSUserDomainMask, YES);
            string[] lpath = NSSearchPath.GetDirectories(NSSearchPathDirectory.LibraryDirectory,NSSearchPathDomain.All, true);
            NSArray paths = NSArray.FromObjects(lpath);
            NSString libraryDirectory = paths.GetItem<NSString>(0);// [paths objectAtIndex: 0];

            NSString db = new NSString("cache.db");
            NSString writableDBPath = libraryDirectory.AppendPathComponent(db); //[libraryDirectory stringByAppendingPathComponent: @"ApprendemosBD.sqlite"];

            exito = fileManager.FileExists(writableDBPath);//FileExists.writableDBPath();// [fileManager fileExistsAtPath:writableDBPath];
 
        if (exito) return;

            // Si no existe en Library, la copio desde el original.
            
            NSString defaultDBPath = new NSString("cache.db").AppendPathComponent(new NSString(NSBundle.MainBundle.ResourcePath));//[[[NSBundle mainBundle] resourcePath] stringByAppendingPathComponent:@"ApprendemosBD.sqlite"];
 //           NSError errorCopy = new NSError();
            exito = fileManager.Copy(defaultDBPath, writableDBPath,out error);
                
            //exito = [fileManager copyItemAtPath:defaultDBPath toPath:writableDBPath error:&amp;error];
 
        if (!exito) {
                Debug.WriteLine("Error al cargar la bd");    
///            NSAssert1(0, @"Error al cargar la base de datos, error = '%@'.", [error localizedDescription]);
        }

    }

	}
}