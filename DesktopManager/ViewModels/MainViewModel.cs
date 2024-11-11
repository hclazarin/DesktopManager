using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopManager.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<UserHomeViewModel> KioskCollection { get; set; } = new();

        public MainViewModel()
        {
            FillKioskCollection();
        }

        private void FillKioskCollection()
        {
            KioskCollection.Add(new());
            KioskCollection.Add(new());
        }
    }
}
