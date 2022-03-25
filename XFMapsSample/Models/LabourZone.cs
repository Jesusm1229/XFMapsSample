using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XFMapsSample.Models
{
    //public class LabourZone: List<Point>
    //{
    //    public List<Point> Points => this;

    //    public LabourZone(IEnumerable<Point> items)
    //    {
    //        AddRange(items);
    //    }
    //    
    //}

    //la zona laboral herede de una Lista de poligonos
    public class LabourZone: List<Polygon>
    {
        public int Id { get; set; }
        public List<Polygon> Polygons => this;
                

        public LabourZone(IEnumerable<Polygon> items)
        {
            AddRange(items);
        }
    }

    
}
