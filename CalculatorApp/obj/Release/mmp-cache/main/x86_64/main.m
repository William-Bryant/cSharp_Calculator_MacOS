static void xamarin_invoke_registration_methods ()
{
}

#define MONOMAC 1
#include <xamarin/xamarin.h>



extern "C" int xammac_setup ()
{
	extern NSString* xamarin_custom_bundle_name;
	xamarin_custom_bundle_name = @"MonoBundle";
	xamarin_executable_name = "Calculator.exe";
	xamarin_marshal_objectivec_exception_mode = MarshalObjectiveCExceptionModeDisable;
	xamarin_disable_lldb_attach = true;

	xamarin_create_classes ();
	setenv ("MONO_GC_PARAMS", "major=marksweep", 1);
	xamarin_supports_dynamic_registration = TRUE;
	xamarin_mac_modern = TRUE;
	xamarin_invoke_registration_methods ();
	return 0;
}

