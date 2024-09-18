using Microsoft.Maui.Maps;

namespace PAM3_Maps
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            //Iinicializacao do Mapa
            var location = new Location(-23.514261498137525, -46.596412633083695);
            var mapSpan = new MapSpan(location, 0.01, 0.01);
            map.MoveToRegion(mapSpan);
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }
    }

}
