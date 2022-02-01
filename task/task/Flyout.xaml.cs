using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace task
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Flyout : ContentPage
    {
        public ListView ListView;

        public Flyout()
        {
            InitializeComponent();

            BindingContext = new FlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class FlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FlyoutMenuItem> MenuItems { get; set; }

            public FlyoutViewModel()
            {
                MenuItems = new ObservableCollection<FlyoutMenuItem>(new[]
                {
                    new FlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new FlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new FlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new FlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new FlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}