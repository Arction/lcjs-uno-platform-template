# lcjs-uno-platform-template

Project template for using LCJS with Uno Platform

The nature of the Uno Platform is that it functions as a bridge to bring UWP and WinUI code such as C# and XAML to be deployed to iOS, Android, macOS, Linux and WebAssembly environments.

A)	UWP : In this implementation is done by using WebView and invoke JavaScript function to run charts. As webgl is supported in x64 CPU configuration, it is running on UWP windows app on x64 CPU currently.

B)	Android 
Same UWP is code is running in case of android with webview implementation.

C) WASM and SKIA
Currently these are not supported, as WebView has not been implemented yet on these platforms.
