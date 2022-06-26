#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#pragma clang diagnostic ignored "-Wunguarded-availability-new"
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>

@class __monomac_internal_ActionDispatcher;
@class NSApplicationDelegate;
@class Foundation_NSDispatcher;
@class __MonoMac_NSSynchronizationContextDispatcher;
@class Foundation_NSAsyncDispatcher;
@class __MonoMac_NSAsyncSynchronizationContextDispatcher;
@class __NSGestureRecognizerToken;
@class __NSGestureRecognizerParameterlessToken;
@class __NSGestureRecognizerParametrizedToken;
@class __NSClickGestureRecognizer;
@class __NSMagnificationGestureRecognizer;
@class __NSPanGestureRecognizer;
@class __NSPressGestureRecognizer;
@class __NSRotationGestureRecognizer;
@class __NSObject_Disposer;
@class AppDelegate;
@class ViewController;

@interface NSApplicationDelegate : NSObject<NSApplicationDelegate> {
}
	-(id) init;
@end

@interface __NSGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface __NSGestureRecognizerParameterlessToken : __NSGestureRecognizerToken {
}
	-(void) target;
@end

@interface __NSGestureRecognizerParametrizedToken : __NSGestureRecognizerToken {
}
	-(void) target:(NSGestureRecognizer *)p0;
@end

@interface AppDelegate : NSObject<NSApplicationDelegate, NSApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(void) applicationDidFinishLaunching:(NSNotification *)p0;
	-(void) applicationWillTerminate:(NSNotification *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface ViewController : NSViewController {
}
	@property (nonatomic, assign) NSTextField * infoLabel;
	-(void) release;
	-(id) retain;
	-(GCHandle) xamarinGetGCHandle;
	-(bool) xamarinSetGCHandle: (GCHandle) gchandle flags: (enum XamarinGCHandleFlags) flags;
	-(enum XamarinGCHandleFlags) xamarinGetFlags;
	-(void) xamarinSetFlags: (enum XamarinGCHandleFlags) flags;
	-(NSTextField *) infoLabel;
	-(void) setInfoLabel:(NSTextField *)p0;
	-(void) viewDidLoad;
	-(NSObject *) representedObject;
	-(void) setRepresentedObject:(NSObject *)p0;
	-(void) bnt_2:(NSObject *)p0;
	-(void) btn_0:(NSObject *)p0;
	-(void) btn_1:(NSObject *)p0;
	-(void) btn_3:(NSObject *)p0;
	-(void) btn_4:(NSObject *)p0;
	-(void) btn_5:(NSObject *)p0;
	-(void) btn_6:(NSObject *)p0;
	-(void) btn_7:(NSObject *)p0;
	-(void) btn_8:(NSObject *)p0;
	-(void) btn_9:(NSObject *)p0;
	-(void) btn_dec:(NSObject *)p0;
	-(void) btn_Divide:(NSObject *)p0;
	-(void) btn_Equal:(NSObject *)p0;
	-(void) btn_Minus:(NSObject *)p0;
	-(void) btn_Mult:(NSObject *)p0;
	-(void) btn_Plus:(NSObject *)p0;
	-(void) btnReset:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end


