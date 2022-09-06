using Android.Content;
using Android.Views;
using AndroidX.CardView.Widget;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWithRenderer.Platforms.Android
{
    public class CardsViewRenderer : VisualElementRenderer<CardsView>  // Microsoft.Maui.Controls.Handlers.Compatibility.VisualElementRenderer<CardsView> 
    {
        public CardsViewRenderer(Context context) : base(context)
        {
        }
    }    
}
