using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppChapter1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {
            InitializeComponent();
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = "It is so!";
        }

        async private void ImageTapped(object sender, EventArgs e)
        {
            Image image = ((Image)sender);
            image.Opacity = .5;
            await Task.Delay(2000);
            image.Opacity = 1;
        }
    }
}