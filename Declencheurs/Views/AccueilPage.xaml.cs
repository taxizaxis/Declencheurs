using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

using Declencheurs.Models;
using Declencheurs.Services;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Declencheurs.Views
{
    public sealed partial class AccueilPage : Page, INotifyPropertyChanged
    {
        private Declencheur _selected;

        public Declencheur Selected
        {
            get { return _selected; }
            set { Set(ref _selected, value); }
        }

        public ObservableCollection<Declencheur> DeclencheurItems { get; private set; } = new ObservableCollection<Declencheur>();

        public AccueilPage()
        {
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            DeclencheurItems.Clear();

            var data = await DeclencheursService.GetSampleModelDataAsync();

            foreach (var item in data)
            {
                DeclencheurItems.Add(item);
            }

            Selected = DeclencheurItems.First();
        }

        private void MasterListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e?.ClickedItem as Declencheur;
            if (item != null)
            {
                if (WindowStates.CurrentState == NarrowState)
                {
                    NavigationService.Navigate<Views.AccueilDetailPage>(item);
                }
                else
                {
                    Selected = item;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
