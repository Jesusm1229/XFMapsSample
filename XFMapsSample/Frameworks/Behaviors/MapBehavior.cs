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
            BindableProperty.Create(nameof(ItemsSource), typeof(IEnumerable<LabourZone>), typeof(MapBehavior), null, BindingMode.Default, propertyChanged: ItemsSourceChanged);


        public IEnumerable<LabourZone> ItemsSource
        {
            get => (IEnumerable<LabourZone>)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        private static void ItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is MapBehavior behavior)) return;

            //Aquí se añade el comportamiento. 
            behavior.AddPolygons();
        }

        private void AddPolygons()
        {
            var map = AssociatedObject;

            //Añadir poligonos al map

            var polygons = ItemsSource.Select(x =>
            {
                var polygon = new Polygon
                {
                    StrokeColor = Color.FromHex("#1BA1E2"),
                    StrokeWidth = 8,
                    FillColor = Color.FromHex("#881BA1E2"),
                    
                    //Aquí debería de llamar las posiciones del polígono de X

                };

                


                return polygon;

            }).ToArray();

            foreach (var polygon in polygons)
                map.MapElements.Add(polygon);

        }
            
    }
}
