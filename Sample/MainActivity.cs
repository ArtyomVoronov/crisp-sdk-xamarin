using Android.App;
using Android.OS;
using IM.Crisp.Sdk;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Crisp.Initialize(this);
            Crisp.Instance.WebsiteId = "Your_Website_Id";
            Crisp.User.SetEmail("user@email.com");
            Crisp.User.SetNickname("NickName");

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

