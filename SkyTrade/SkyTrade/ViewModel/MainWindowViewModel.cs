using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;

namespace SkyTrade
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            SystemStatus = "Loading...";
        }

        private string _systemStatus;
        public string SystemStatus
        {
            get
            {
                return _systemStatus;
            }
            set
            {
                _systemStatus = value;
                UpdateProperty("SystemStatus");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void UpdateProperty(string name)
        {
            if (PropertyChanged != null)
            {
                var e = new PropertyChangedEventArgs(name);
                PropertyChanged(this, e);
            }
        }
    }
}
