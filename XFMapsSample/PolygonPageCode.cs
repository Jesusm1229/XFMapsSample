using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XFMapsSample
{
    public class PolygonPageCode: ContentPage
    {
        Map map;
        Polygon polygon;

        public PolygonPageCode()
        {
            map = new Map();

            // instantiate a polygon
             polygon = new Polygon
            {
                StrokeWidth = 8,
                StrokeColor = Color.FromHex("#1BA1E2"),
                FillColor = Color.FromHex("#881BA1E2"),
                Geopath =
                {
                    new Position(47.6368678, -122.137305),
                    new Position(47.6368894, -122.134655),
                    new Position(47.6359424, -122.134655),
                    new Position(47.6359496, -122.1325521),
                    new Position(47.6424124, -122.1325199),
                    new Position(47.642463,  -122.1338932),
                    new Position(47.6406414, -122.1344833),
                    new Position(47.6384943, -122.1361248),
                    new Position(47.6372943, -122.1376912)
                }

            };

            map.MapElements.Add(polygon);
        }
    }
}
