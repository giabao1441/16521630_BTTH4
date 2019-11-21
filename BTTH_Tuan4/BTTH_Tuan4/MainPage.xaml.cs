using System;
using Xamarin.Forms;
using BTTH_Tuan4.Views;

namespace BTTH_Tuan4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void pageInsertHoa(EventArgs e, object sender)
        {
            Navigation.PushAsync(new PageInsertLoaihoa());
        }
        private void pageInsertLoaiHoa(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageInsertHoa());
        }
    }
}
