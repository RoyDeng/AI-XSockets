using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using XSockets.Owin.Host;

[assembly: OwinStartup(typeof(WebRTC.MS.Emotion.API.Startup))]

namespace WebRTC.MS.Emotion.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
           app.UseXSockets();
        }
    }
}
