using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using XFMapsSample.Models;

namespace XFMapsSample.ViewModels
{
    public class MapPageViewModel: INotifyPropertyChanged
    {
        //Se crea una lista de zona laborales
        private List<LabourZone> _items;

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


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
