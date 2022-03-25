using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using XFMapsSample.Frameworks.Behavior;

namespace XFMapsSample
{
    public partial class MainPage: ContentPage
    {
        Polygon pg;
        public MainPage()
        {
            InitializeComponent();

            MapView.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(47.640663, -122.1376177), Distance.FromMiles(1)));

            pg = new Polygon
            {
                StrokeColor = Color.FromHex("#FF9900"),
                StrokeWidth = 8,
                FillColor = Color.FromHex("#88FF9900"),
            };

        }

        private void CreatePoligon_Clicked(object sender, EventArgs e)
        {
            MapView.MapClicked += OnMapClicked;
        }

        private void DeletePoligon_Clicked(object sender, EventArgs e)
        {
            
        }

        private void CreateLabourZone_Clicked(object sender, EventArgs e)
        {

        }



        private void OnMapClicked(object sender, MapClickedEventArgs e)
        {
           
            pg.Geopath.Add(new Position(e.Position.Latitude, e.Position.Longitude));
            DisplayAlert("Coordenadas", $"Lat:{e.Position.Latitude}, Lon: {e.Position.Longitude}", "Ok");

            MapView.MapElements.Add(pg);

                   
        }

        
    }
    
}



/*
 public partial class MainPage: ContentPage
    {
        Map map;
        Polygon msEast;
        public MainPage()
        {
            InitializeComponent();

            //Se declara el mapa
            map = new Map
            {
                IsShowingUser = true
            };

            //Se declaran los botones y funciones que tendrán:
            /*
             1.Botón para marcar inicio de creación de polígono
                1.a Botón para detener la creación de poligono
             2.Botón marcar "Listo" creación zona laboral
             3.Botón eliminar polígono. 
             
Button polygonButton = new Button
{
    Text = "Crear polígono"
};
polygonButton.Clicked += AddPolygonsClicked;

Button polygon2Button = new Button
{
    Text = "Stop polígono"
};
polygon2Button.Clicked += StopPolygonsClicked;




msEast = new Polygon
{
    StrokeColor = Color.FromHex("#1BA1E2"),
    StrokeWidth = 8,
    FillColor = Color.FromHex("#881BA1E2"),

};

Content = new StackLayout
{
    Children =
                {
                    map,
                    polygonButton,
                    polygon2Button
                }

};


map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(47.640663, -122.1376177), Distance.FromMiles(1)));


map.MapElements.Add(msEast);
map.Behaviors.Add(new MapBehavior());


        }

        void AddPolygonsClicked(object sender, System.EventArgs e)
{

    map.MapClicked += OnMapClicked;

}

void StopPolygonsClicked(object sender, System.EventArgs e)
{
    map.MapClicked -= OnMapClicked;
}

private void OnMapClicked(object sender, MapClickedEventArgs e)
{
    msEast.Geopath.Add(new Position(e.Position.Latitude, e.Position.Longitude));
    DisplayAlert("Coordenadas", $"Lat:{e.Position.Latitude}, Lon: {e.Position.Longitude}", "Ok");
}

*/


    /* Prueba con Maps
    public partial class MainPage : ContentPage
    { 
        Map map;
        Polyline interstateBridge;
        Polygon msWest;
        Polygon msEast; 

        public MainPage()
        {

            InitializeComponent();

            map = new Map();


            Button polygonButton = new Button
            {
                Text = "Registrar nueva zona"
            };

          

        msEast = new Polygon
        {
            StrokeColor = Color.FromHex("#1BA1E2"),
            StrokeWidth = 8,
            FillColor = Color.FromHex("#881BA1E2"),
           
        };


            Content = new StackLayout
            {
                Children = {
                    map,
                    polygonButton
                    
                }
            };

            map.MapClicked += Map_MapClicked;

        map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(47.640663, -122.1376177), Distance.FromMiles(1)));

         
            map.MapElements.Add(msEast);
        }

        private void Map_MapClicked(object sender, MapClickedEventArgs e)
        {
            msEast.Geopath.Add(new Position(e.Position.Latitude, e.Position.Longitude));
            DisplayAlert("Coordenadas", $"Lat:{e.Position.Latitude}, Lon: {e.Position.Longitude}", "Ok");
        }
    }

    



}*/

/*using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace WorkingWithMaps
{
    public class PolygonsPageCode : ContentPage
    {
        Map map;
        Polyline interstateBridge;
        Polygon msWest;
        Polygon msEast;

        public PolygonsPageCode()
        {
            Title = "Polygon/Polyline Code demo";
            
            map = new Map();

            Button polygonButton = new Button
            {
                Text = "Show Campus (Polygons)"
            };
            polygonButton.Clicked += AddPolygonsClicked;

            Button polylineButton = new Button
            {
                Text = "Show Access Road (Polyline)"
            };
            polylineButton.Clicked += AddPolylineClicked;

            Button clearButton = new Button
            {
                Text = "Clear All"
            };
            clearButton.Clicked += ClearClicked;

            msWest = new Polygon
            {
                StrokeColor = Color.FromHex("#FF9900"),
                StrokeWidth = 8,
                FillColor = Color.FromHex("#88FF9900"),
                Geopath =
                {
                    new Position(47.6458676, -122.1356007),
                    new Position(47.6458097, -122.142789),
                    new Position(47.6367593, -122.1428104),
                    new Position(47.6368027, -122.1398707),
                    new Position(47.6380172, -122.1376177),
                    new Position(47.640663, -122.1352359),
                    new Position(47.6426148, -122.1347209),
                    new Position(47.6458676, -122.1356007)
                }
            };

            msEast = new Polygon
            {
                StrokeColor = Color.FromHex("#1BA1E2"),
                StrokeWidth = 8,
                FillColor = Color.FromHex("#881BA1E2"),
                Geopath =
                {
                    new Position(47.6368678, -122.137305),
                    new Position(47.6368894, -122.134655),
                    new Position(47.6359424, -122.134655),
                    new Position(47.6359496, -122.1325521),
                    new Position(47.6424124, -122.1325199),
                    new Position(47.642463, -122.1338932),
                    new Position(47.6406414, -122.1344833),
                    new Position(47.6384943, -122.1361248),
                    new Position(47.6372943, -122.1376912),
                    new Position(47.6368678, -122.137305),
                }
            };

            interstateBridge = new Polyline
            {
                StrokeColor = Color.Black,
                StrokeWidth = 12,
                Geopath =
                {
                    new Position(47.6381401, -122.1317367),
                    new Position(47.6381473, -122.1350841),
                    new Position(47.6382847, -122.1353094),
                    new Position(47.6384582, -122.1354703),
                    new Position(47.6401136, -122.1360819),
                    new Position(47.6403883, -122.1364681),
                    new Position(47.6407426, -122.1377019),
                    new Position(47.6412558, -122.1404056),
                    new Position(47.6414148, -122.1418647),
                    new Position(47.6414654, -122.1432702)
                }
            };

            Content = new StackLayout
            {
                Children = {
                    map,
                    polygonButton,
                    polylineButton,
                    clearButton
                }
            };

            map.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(47.640663, -122.1376177), Distance.FromMiles(1)));
        }

        void AddPolylineClicked(object sender, System.EventArgs e)
        {
            if (!map.MapElements.Contains(interstateBridge))
            {
                map.MapElements.Add(interstateBridge);
            }
        }

        void AddPolygonsClicked(object sender, System.EventArgs e)
        {
            if (!map.MapElements.Contains(msWest))
            {
                map.MapElements.Add(msWest);
            }

            if (!map.MapElements.Contains(msEast))
            {
                map.MapElements.Add(msEast);
            }
        }

        void ClearClicked(object sender, System.EventArgs e)
        {
            map.MapElements.Remove(msWest);
            map.MapElements.Remove(msEast);
            map.MapElements.Remove(interstateBridge);
        }
    }
}*/