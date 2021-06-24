// <autogenerated />
#pragma warning disable 618  // Ignore obsolete members warnings
#pragma warning disable 105  // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers.Xaml;
using App14.Droid;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif UNO_REFERENCE_API
using _View = Windows.UI.Xaml.UIElement;
#elif NET461
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace App14
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public partial class MainPage : Windows.UI.Xaml.Controls.Page
	{
		private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			IsParsing = true
			;
			// Source ..\..\..\..\..\..\..\App14.Shared\MainPage.xaml (Line 1:2)
			Content = 
			new global::Windows.UI.Xaml.Controls.Grid
			{
				IsParsing = true
				,
				// Source ..\..\..\..\..\..\..\App14.Shared\MainPage.xaml (Line 9:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.WebView
					{
						IsParsing = true
						,
						Name = "webView1",
						// Source ..\..\..\..\..\..\..\App14.Shared\MainPage.xaml (Line 10:10)
					}
					.MainPage_b9bf9d9452ffec00ccb9e0247752fd1c_XamlApply((MainPage_b9bf9d9452ffec00ccb9e0247752fd1cXamlApplyExtensions.XamlApplyHandler0)(c0 => 
					{
						nameScope.RegisterName("webView1", c0);
						this.webView1 = c0;
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c0, "file:///C:/Users/ChetanaKamble/Downloads/App14/App14.Shared/MainPage.xaml");
						c0.CreationComplete();
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						IsParsing = true
						,
						Margin = new global::Windows.UI.Xaml.Thickness(20)/* Windows.UI.Xaml.Thickness/, 20, StackPanel/Margin */,
						Padding = new global::Windows.UI.Xaml.Thickness(5)/* Windows.UI.Xaml.Thickness/, 5, StackPanel/Padding */,
						HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Left/* Windows.UI.Xaml.HorizontalAlignment/, Left, StackPanel/HorizontalAlignment */,
						Orientation = global::Windows.UI.Xaml.Controls.Orientation.Horizontal/* Windows.UI.Xaml.Controls.Orientation/, Horizontal, StackPanel/Orientation */,
						// Source ..\..\..\..\..\..\..\App14.Shared\MainPage.xaml (Line 11:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.Primitives.RepeatButton
							{
								IsParsing = true
								,
								Background = SolidColorBrushHelper.Gray/* Windows.UI.Xaml.Media.Brush/, Gray, RepeatButton/Background */,
								VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Top/* Windows.UI.Xaml.VerticalAlignment/, Top, RepeatButton/VerticalAlignment */,
								Width = 100d/* double/, 100, RepeatButton/Width */,
								Delay = 500/* int/, 500, RepeatButton/Delay */,
								Margin = new global::Windows.UI.Xaml.Thickness(25)/* Windows.UI.Xaml.Thickness/, 25, RepeatButton/Margin */,
								Interval = 100/* int/, 100, RepeatButton/Interval */,
								// Source ..\..\..\..\..\..\..\App14.Shared\MainPage.xaml (Line 12:14)
								Content = "Line Chart"
								,
							}
							.MainPage_b9bf9d9452ffec00ccb9e0247752fd1c_XamlApply((MainPage_b9bf9d9452ffec00ccb9e0247752fd1cXamlApplyExtensions.XamlApplyHandler1)(c1 => 
							{
								var Click_Increase_Click_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
								c1.Click += (Increase_Click_sender,Increase_Click_e) => (Click_Increase_Click_That.Target as MainPage)?.Increase_Click(Increase_Click_sender,Increase_Click_e);
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c1, "file:///C:/Users/ChetanaKamble/Downloads/App14/App14.Shared/MainPage.xaml");
								c1.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.Primitives.RepeatButton
							{
								IsParsing = true
								,
								Background = SolidColorBrushHelper.Gray/* Windows.UI.Xaml.Media.Brush/, Gray, RepeatButton/Background */,
								VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Top/* Windows.UI.Xaml.VerticalAlignment/, Top, RepeatButton/VerticalAlignment */,
								Width = 100d/* double/, 100, RepeatButton/Width */,
								Delay = 500/* int/, 500, RepeatButton/Delay */,
								Margin = new global::Windows.UI.Xaml.Thickness(25)/* Windows.UI.Xaml.Thickness/, 25, RepeatButton/Margin */,
								Interval = 100/* int/, 100, RepeatButton/Interval */,
								// Source ..\..\..\..\..\..\..\App14.Shared\MainPage.xaml (Line 13:14)
								Content = "3D Chart"
								,
							}
							.MainPage_b9bf9d9452ffec00ccb9e0247752fd1c_XamlApply((MainPage_b9bf9d9452ffec00ccb9e0247752fd1cXamlApplyExtensions.XamlApplyHandler1)(c2 => 
							{
								var Click_Decrease_Click_That = (this as global::Uno.UI.DataBinding.IWeakReferenceProvider).WeakReference;
								c2.Click += (Decrease_Click_sender,Decrease_Click_e) => (Click_Decrease_Click_That.Target as MainPage)?.Decrease_Click(Decrease_Click_sender,Decrease_Click_e);
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c2, "file:///C:/Users/ChetanaKamble/Downloads/App14/App14.Shared/MainPage.xaml");
								c2.CreationComplete();
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								IsParsing = true
								,
								Name = "clickTextBlock",
								// Source ..\..\..\..\..\..\..\App14.Shared\MainPage.xaml (Line 14:14)
							}
							.MainPage_b9bf9d9452ffec00ccb9e0247752fd1c_XamlApply((MainPage_b9bf9d9452ffec00ccb9e0247752fd1cXamlApplyExtensions.XamlApplyHandler2)(c3 => 
							{
								nameScope.RegisterName("clickTextBlock", c3);
								this.clickTextBlock = c3;
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c3, "file:///C:/Users/ChetanaKamble/Downloads/App14/App14.Shared/MainPage.xaml");
								c3.CreationComplete();
							}
							))
							,
						}
					}
					.MainPage_b9bf9d9452ffec00ccb9e0247752fd1c_XamlApply((MainPage_b9bf9d9452ffec00ccb9e0247752fd1cXamlApplyExtensions.XamlApplyHandler3)(c4 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetColumnSpan(c4, 6/* int/, 6, Grid/ColumnSpan */);
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c4, 3/* int/, 3, Grid/Row */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c4, "file:///C:/Users/ChetanaKamble/Downloads/App14/App14.Shared/MainPage.xaml");
						c4.CreationComplete();
					}
					))
					,
				}
			}
			.MainPage_b9bf9d9452ffec00ccb9e0247752fd1c_XamlApply((MainPage_b9bf9d9452ffec00ccb9e0247752fd1cXamlApplyExtensions.XamlApplyHandler4)(c5 => 
			{
				global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c5, global::Windows.UI.Xaml.Controls.Grid.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, context: global::App14.Droid.GlobalStaticResources.__ParseContext_);
				/* _isTopLevelDictionary:False */
				this._component_0 = c5;
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c5, "file:///C:/Users/ChetanaKamble/Downloads/App14/App14.Shared/MainPage.xaml");
				c5.CreationComplete();
			}
			))
			;
			
			this
			.Apply((c6 => 
			{
				// Source C:\Users\ChetanaKamble\Downloads\App14\App14.Shared\MainPage.xaml (Line 1:2)
				
				// WARNING Property c6.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.Apply((c7 => 
			{
				// Class App14.MainPage
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c7, "file:///C:/Users/ChetanaKamble/Downloads/App14/App14.Shared/MainPage.xaml");
				c7.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new MainPage_Bindings(this);
			Loading += delegate
			{
				_component_0.UpdateResourceBindings();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Windows.UI.Xaml.Data.ElementNameSubject _webView1Subject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.WebView webView1
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.WebView)_webView1Subject.ElementInstance;
			}
			set
			{
				_webView1Subject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Data.ElementNameSubject _clickTextBlockSubject = new global::Windows.UI.Xaml.Data.ElementNameSubject();
		private global::Windows.UI.Xaml.Controls.TextBlock clickTextBlock
		{
			get
			{
				return (global::Windows.UI.Xaml.Controls.TextBlock)_clickTextBlockSubject.ElementInstance;
			}
			set
			{
				_clickTextBlockSubject.ElementInstance = value;
			}
		}
		private global::Windows.UI.Xaml.Controls.Grid _component_0;
		private interface IMainPage_Bindings
		{
			void Initialize();
			void Update();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private IMainPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class MainPage_Bindings : IMainPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private MainPage Owner { get => (MainPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private MainPage Owner { get; set; }
			#endif
			public MainPage_Bindings(MainPage owner)
			{
				Owner = owner;
			}
			void IMainPage_Bindings.Initialize()
			{
			}
			void IMainPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void IMainPage_Bindings.StopTracking()
			{
			}
		}
	}
}
namespace App14.Droid
{
	static class MainPage_b9bf9d9452ffec00ccb9e0247752fd1cXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.WebView instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.WebView MainPage_b9bf9d9452ffec00ccb9e0247752fd1c_XamlApply(this global::Windows.UI.Xaml.Controls.WebView instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.Primitives.RepeatButton instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Primitives.RepeatButton MainPage_b9bf9d9452ffec00ccb9e0247752fd1c_XamlApply(this global::Windows.UI.Xaml.Controls.Primitives.RepeatButton instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.TextBlock instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.TextBlock MainPage_b9bf9d9452ffec00ccb9e0247752fd1c_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.StackPanel instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.StackPanel MainPage_b9bf9d9452ffec00ccb9e0247752fd1c_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.Grid instance);
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
		public static global::Windows.UI.Xaml.Controls.Grid MainPage_b9bf9d9452ffec00ccb9e0247752fd1c_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
