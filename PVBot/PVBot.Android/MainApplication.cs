using System;
using Android.App;
using Android.Runtime;

namespace PVBot.Droid
{
    [Application(
        Theme = "@style/MainTheme"
        )]
    public class MainApplication : Android.App.Application
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            Xamarin.Essentials.Platform.Init(this);
        }
    }
}
