using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using XFMapsSample.Models;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms.Maps;

namespace XFMapsSample.ViewModels
{
    public class MapPageViewModel: ViewModel
    {
        //Acá debería crear un servicio para leer la zona laboral de la API
        /*private readonly ILabourZoneService labourzoneService

         public MapVIewModel(ILabourZoneService labourzoneService)
         {
             this.labourzoneService = labourzoneService;
         }*/


        //private ObservableCollection<PolygonItem> labourZone;

        ////Función para cargar todo desde la API 
        //public async Task LoadData()
        //{
        //    var itemGroup = new LabourZone();



        //}

        //public MapPageViewModel()
        //{
        //    LoadData();


        //}

        private List<PolygonItem> _items;

        public List<PolygonItem> Items
        {
            get => _items;
            set
            {
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }
        
        public MapPageViewModel()
        {
            Init();
        }

        public void Add()
        {
            new PolygonItem
            {


            };
        }

        private void Init()
        {
            Items = new List<PolygonItem> {

                new PolygonItem
                {
                    id = 1,
                    Geopath = {
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
                },
                new PolygonItem
                {
                    id = 2,
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
                }

            };
        }

       public ICommand AddToMap { private set; get; }
    }
}


//Acá debería crear un servicio para leer la zona laboral de la API
/*private readonly ILabourZoneService labourzoneService

public MapVIewModel(ILabourZoneService labourzoneService)
{
    this.labourzoneService = labourzoneService;
}

*/
//Se crea una lista de items polígonos
/*private List<LabourZone> _items;


public List<LabourZone> Items
{
    get => _items;

    set{
        _items = value;
        OnPropertyChanged(nameof(Items));
    }
}



public MapPageViewModel()
{
    Init();
}

private void Init()
{
    //Aquí se mandan las zonas laborales previas que tenga la empresa
    Items = new List<LabourZone>
    {

    };

}



*/  