# lcjs-uno-platform-template

Project template for using LCJS with Uno Platform

The UNO Platform is Universal Windows Platform Bridge that allows UWP based code(c# and XMAL) to run on IOS, Android and WebAssembly. It provides the full API definitions of the UWP Windows 10 2004 (19041), and the implementation of parts of the UWP API, such as Windows.UI.Xaml, to enable UWP applications to run on these platforms.

A)	UWP : In this implementation is done by using WebView and invoke JavaScript function to run charts. As webgl is supported in x64 CPU configuration, it is running on UWP windows app on x64 CPU currently.

B)	Android 
Same UWP is code is running in case of android with webview implementation.

C) WASM and SKIA
Currently these are not supported, as WebView has not been implemented yet on these platforms.
