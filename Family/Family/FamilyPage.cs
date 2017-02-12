using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Family
{
    class FamilyPage : ContentPage
    {
        public FamilyPage()
        {
            Content = new Label
            {
                FormattedText = new FormattedString
                {
                    Spans =
                    {
                        new Span
                        {
                            Text = "Meet My Family" + Environment.NewLine + Environment.NewLine,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                
                        },

                        
                        new Span
                        {
                            Text = "I am ",
                        },

                        new Span
                        {
                            Text = "Radhika." + Environment.NewLine + Environment.NewLine,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },

                        
                        new Span
                        {
                            Text = "My husband is ",
                        },

                        new Span
                        {
                            Text = "Prabu." + Environment.NewLine + Environment.NewLine,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },

                        
                        new Span
                        {
                            Text = "My daughter is ",
                        },

                        new Span
                        {
                            Text = "Aditi." + Environment.NewLine + Environment.NewLine,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },

                        new Span
                        {
                            Text = "My son is ",
                        },

                        new Span
                        {
                            Text = "Abishek." + Environment.NewLine + Environment.NewLine,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },

                    }
                },

                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                BackgroundColor = Color.Blue
            };
            
        }
    }
}
