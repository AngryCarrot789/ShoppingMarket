using ShoppingMarket.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingMarket.ViewModel
{
    public class ShoppingMarketViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<IProductModel> _products = new ObservableCollection<IProductModel>();
        public ObservableCollection<IProductModel> Products { get { return _products; } set { _products = value; RaisePropertyChanged(); } }

        public ShoppingMarketViewModel()
        {
            List<IProductModel> products = GetSamples();

            foreach(PhysicalProduct eek in products)
            {
                Products.Add(eek);
            }

            foreach (DigitalProduct eek in products)
            {
                Products.Add(eek);
            }

            foreach (ServiceProduct eek in products)
            {
                Products.Add(eek);
            }

            //This would get everything above and put them all in. The above allows you to separate what you want to add.
            //foreach (IProductModel eek in products)
            //{
            //    Products.Add(eek);
            //}
        }

        private List<IProductModel> GetSamples()
        {
            return new List<IProductModel> { new DigitalProduct { ItemName = "Black Ops 3" }, new PhysicalProduct { ItemName = "Desk Fan", } };
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
