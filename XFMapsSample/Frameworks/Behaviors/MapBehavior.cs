using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using XFMapsSample.Models;

namespace XFMapsSample.Frameworks.Behavior
{
    public class MapBehavior: BindableBehavior<Map>
    {
        public static readonly BindableProperty ItemsSourceProperty = 
            BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable<PolygonItem>), typeof(MapBehavior), null, BindingMode.Default, propertyChanged: ItemsSourceChanged);


        public IEnumerable<PolygonItem> ItemsSource
        {
            get => (IEnumerable<PolygonItem>)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        /*El método ItemsSourceChanged nos va a servir para 
         * detectar los cambios en nuestra propiedad Items 
         * del Behavior. Cada vez que asignamos esta propiedad, 
         * el Behavior procederá a agregar los lugares (Poligons) 
         * a nuestro mapa.*/
        private static void ItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is MapBehavior behavior)) return;

            //Aquí se añade el comportamiento. 
            behavior.AddPolygons();
            //behavior.PositionMap(); Función para posicionar el mapa
        }

        //Añadir polígonos al mapa 
        private void AddPolygons()
        {
            var map = AssociatedObject;
                        
            var polygons = ItemsSource.Select(x =>
            {
                var polygon = new Polygon
                {
                    StrokeColor = Color.FromHex("#1BA1E2"),
                    StrokeWidth = 8,
                    FillColor = Color.FromHex("#881BA1E2"),
                    
                    
                };
                //Aquí debería de llamar las posiciones del polígono de X

                foreach (var polygonGeopath in x.Geopath)
                    polygon.Geopath.Add(new Position(polygonGeopath.Latitude, polygonGeopath.Longitude ));


                return polygon;
            }).ToArray();

            foreach (var polygon in polygons)
                map.MapElements.Add(polygon);

        }

        private void AddNewPolygon()
        {
            var map = AssociatedObject;

            var polygons = ItemsSource.Select(x =>
            {
                var polygon = new Polygon
                {
                    StrokeColor = Color.FromHex("#1BA1E2"),
                    StrokeWidth = 8,
                    FillColor = Color.FromHex("#881BA1E2"),
                   
                };

                foreach (var polygonGeopath in x.Geopath)
                    polygon.Geopath.Add(new Position());

                return polygon;
            }).ToArray();

            
            
        }


        private void PolygonOnClicked(object sender, EventArgs eventArgs)
        {
            var polygon = sender as Polygon;
            if (polygon == null) return;

            //var viewModel = ItemsSource.FirstOrDefault(x => x.Id == polygon.Id);

            //viewModel.Command.Execute(null);

        }
            
    }
}
