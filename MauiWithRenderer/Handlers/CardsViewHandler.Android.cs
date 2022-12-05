using Android.Content;
using Microsoft.Maui.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWithRenderer.Handlers
{
    public partial class CardsViewHandler : Microsoft.Maui.Handlers.LayoutHandler
    {
        private CardsView cardsView;

        protected override LayoutViewGroup CreatePlatformView()
        {
            return base.CreatePlatformView();
            // or alternativly override (replace) this with your custom android control if needed
            // return new MyNativeLayoutControl(this.Context);
        }

        protected override void ConnectHandler(LayoutViewGroup platformView)
        {
            cardsView = (CardsView)VirtualView;

            // adapted cardsView as u need or attach on events

            base.ConnectHandler(platformView);
        }

        protected override void DisconnectHandler(LayoutViewGroup platformView)
        {
            base.DisconnectHandler(platformView);

            // detach from events

            cardsView = null;
        }
    }

    /*
    public class MyNativeLayoutControl : LayoutViewGroup  // Android.Views.ViewGroup
    {
        public MyNativeLayoutControl(Context context) : base(context)
        {

        }

        // override any property or method needed, or attach to events
    }
    */
}
