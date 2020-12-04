using Sitecore.Diagnostics;
using Sitecore.Pipelines.Logout;

namespace SitecoreLogout
{
    public class LogoutRedirectProcessor
    {
        public void Process(LogoutArgs args)
        {
            Tracer.Info("Intercepting call to Sitecore logout. Redirecting to Single Logout instead");
            Sitecore.Text.UrlString urlString = new Sitecore.Text.UrlString("https://www.google.com");
            args.RedirectUrl = urlString;

            //var uri = "https://www.google.com";
            //var psi = new System.Diagnostics.ProcessStartInfo();
            //psi.UseShellExecute = true;
            //psi.FileName = uri;
            //System.Diagnostics.Process.Start(psi);

        }
    }    
}
