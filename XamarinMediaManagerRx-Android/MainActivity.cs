using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ReactiveUI;
using System.Reactive;
using System.Reactive.Linq;
using XamarinMediaManagerRx.Core.ViewModels;
using Akavache;
using Xamarin.Forms.Platform.Android;
using ReactiveUI.XamForms;
using Xamarin.Forms;

namespace XamarinMediaManagerRx.Views
{
    [Activity (Label = "XamarinMediaManagerRx-Android", MainLauncher = true)]
    public class MainActivity : AndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Forms.Init(this, bundle);

            var bootstrapper = RxApp.SuspensionHost.GetAppState<AppBootstrapper>();
            this.SetPage(bootstrapper.CreateMainPage());
        }
    }
}
