using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using Xamarin.Essentials;

namespace AppTheme
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class AppThemeActivity : AppCompatActivity
    {
        private TextView _themeTextView;
        private Button _checkThemeButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            UIReferences();
            UIClickevents();
        }

        private void UIClickevents()
        {
            _checkThemeButton.Click += CheckThemeButton_Click;
        }

        private void CheckThemeButton_Click(object sender, EventArgs e)
        {
            var currentTheme = AppInfo.RequestedTheme;
            _themeTextView.Text = $"Current theme: {currentTheme}";
        }

        private void UIReferences()
        {
            _themeTextView = FindViewById<TextView>(Resource.Id.themeTextView);
            _checkThemeButton = FindViewById<Button>(Resource.Id.checkThemeButton);
        } 
    }
}