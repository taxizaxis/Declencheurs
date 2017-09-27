using System;
using Declencheurs.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Declencheurs.Views
{
    public sealed partial class AccueilDetailControl : UserControl
    {
        public Declencheur MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as Declencheur; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(Declencheur), typeof(AccueilDetailControl), new PropertyMetadata(null));
        

        public AccueilDetailControl()
        {
            InitializeComponent();
        }

        void CheckBoxPage_Loaded(object sender, RoutedEventArgs e)
        {
            SetCheckedState();
        }

        private void Option_Checked(object sender, RoutedEventArgs e)
        {
            SetCheckedState();
        }
        private void OptionComposant_Checked(object sender, RoutedEventArgs e)
        {
            SetCheckedStateComposant();
        }

        private void Option_Unchecked(object sender, RoutedEventArgs e)
        {
            SetCheckedState();
        }
        private void OptionComposant_Unchecked(object sender, RoutedEventArgs e)
        {
            SetCheckedStateComposant();
        }

        private void SelectAll_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox CheckboxLundi = sender as CheckBox;
            CheckBox CheckboxMardi = sender as CheckBox;
            CheckBox CheckboxMercredi = sender as CheckBox;
            CheckBox CheckboxJeudi = sender as CheckBox;
            CheckBox CheckboxVendredi = sender as CheckBox;
            CheckBox CheckboxSamedi = sender as CheckBox;
            CheckBox CheckboxDimanche = sender as CheckBox;

            CheckboxLundi.IsChecked = CheckboxMardi.IsChecked = CheckboxMercredi.IsChecked = CheckboxJeudi.IsChecked = CheckboxVendredi.IsChecked = CheckboxSamedi.IsChecked = CheckboxDimanche.IsChecked = true;
        }

        private void SelectAllComposant_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox CheckboxWiFi = sender as CheckBox;
            CheckBox CheckboxBluetooth = sender as CheckBox;
            CheckBox CheckboxDonnéesMobiles = sender as CheckBox;

            CheckboxWiFi.IsChecked = CheckboxBluetooth.IsChecked = CheckboxDonnéesMobiles.IsChecked = true;
        }

        private void SelectAll_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox CheckboxLundi = sender as CheckBox;
            CheckBox CheckboxMardi = sender as CheckBox;
            CheckBox CheckboxMercredi = sender as CheckBox;
            CheckBox CheckboxJeudi = sender as CheckBox;
            CheckBox CheckboxVendredi = sender as CheckBox;
            CheckBox CheckboxSamedi = sender as CheckBox;
            CheckBox CheckboxDimanche = sender as CheckBox;

            CheckboxLundi.IsChecked = CheckboxMardi.IsChecked = CheckboxMercredi.IsChecked = CheckboxJeudi.IsChecked = CheckboxVendredi.IsChecked = CheckboxSamedi.IsChecked = CheckboxDimanche.IsChecked = false;
        }
        private void SelectAllComposant_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox CheckboxWiFi = sender as CheckBox;
            CheckBox CheckboxBluetooth = sender as CheckBox;
            CheckBox CheckboxDonnéesMobiles = sender as CheckBox;

            CheckboxWiFi.IsChecked = CheckboxBluetooth.IsChecked = CheckboxDonnéesMobiles.IsChecked = false;
        }

        private void SelectAll_Indeterminate(object sender, RoutedEventArgs e)
        {
            // If the SelectAll box is checked (all options are selected), 
            // clicking the box will change it to its indeterminate state.
            // Instead, we want to uncheck all the boxes,
            // so we do this programatically. The indeterminate state should
            // only be set programatically, not by the user.
            CheckBox CheckboxLundi = sender as CheckBox;
            CheckBox CheckboxMardi = sender as CheckBox;
            CheckBox CheckboxMercredi = sender as CheckBox;
            CheckBox CheckboxJeudi = sender as CheckBox;
            CheckBox CheckboxVendredi = sender as CheckBox;
            CheckBox CheckboxSamedi = sender as CheckBox;
            CheckBox CheckboxDimanche = sender as CheckBox;
            CheckBox CheckboxAll = sender as CheckBox;


            if (CheckboxLundi.IsChecked == true &&
                CheckboxMardi.IsChecked == true &&
                CheckboxMercredi.IsChecked == true &&
                CheckboxJeudi.IsChecked == true &&
                CheckboxVendredi.IsChecked == true &&
                CheckboxSamedi.IsChecked == true &&
                CheckboxDimanche.IsChecked == true)
            {
                // This will cause SelectAll_Unchecked to be executed, so
                // we don't need to uncheck the other boxes here.
                CheckboxAll.IsChecked = false;
            }
        }
        private void SelectAllComposant_Indeterminate(object sender, RoutedEventArgs e)
        {
            // If the SelectAll box is checked (all options are selected), 
            // clicking the box will change it to its indeterminate state.
            // Instead, we want to uncheck all the boxes,
            // so we do this programatically. The indeterminate state should
            // only be set programatically, not by the user.
            CheckBox CheckboxWiFi = sender as CheckBox;
            CheckBox CheckboxBluetooth = sender as CheckBox;
            CheckBox CheckboxDonnéesMobiles = sender as CheckBox;


            if (CheckboxWiFi.IsChecked == true &&
                CheckboxBluetooth.IsChecked == true &&
                CheckboxDonnéesMobiles.IsChecked == true)
            {
                // This will cause SelectAll_Unchecked to be executed, so
                // we don't need to uncheck the other boxes here.
                CheckboxAllComposant.IsChecked = false;
            }
        }
        private void SetCheckedState()
        {

            // Controls are null the first time this is called, so we just 
            // need to perform a null check on any one of the controls.

            CheckBox CheckboxLundi = sender as CheckBox;
            CheckBox CheckboxMardi = sender as CheckBox;
            CheckBox CheckboxMercredi = sender as CheckBox;
            CheckBox CheckboxJeudi = sender as CheckBox;
            CheckBox CheckboxVendredi = sender as CheckBox;
            CheckBox CheckboxSamedi = sender as CheckBox;
            CheckBox CheckboxDimanche = sender as CheckBox;
            CheckBox CheckboxAll = sender as CheckBox;

            if (CheckboxLundi != null)
            {
                if (CheckboxLundi.IsChecked == true &&
                    CheckboxMardi.IsChecked == true &&
                    CheckboxMercredi.IsChecked == true &&
                    CheckboxJeudi.IsChecked == true &&
                    CheckboxVendredi.IsChecked == true &&
                    CheckboxSamedi.IsChecked == true &&
                    CheckboxDimanche.IsChecked == true)
                {
                    CheckboxAll.IsChecked = true;
                }
                else if (CheckboxLundi.IsChecked == false &&
                    CheckboxMardi.IsChecked == false &&
                    CheckboxMercredi.IsChecked == false &&
                    CheckboxJeudi.IsChecked == false &&
                    CheckboxVendredi.IsChecked == false &&
                    CheckboxSamedi.IsChecked == false &&
                    CheckboxDimanche.IsChecked == false)
                {
                    CheckboxAll.IsChecked = false;
                }
                else
                {
                    // Set third state (indeterminate) by setting IsChecked to null.
                    CheckboxAll.IsChecked = null;
                }
            }
        }

        private void SetCheckedStateComposant()
        {

            // Controls are null the first time this is called, so we just 
            // need to perform a null check on any one of the controls.

            CheckBox CheckboxWiFi = sender as CheckBox;
            CheckBox CheckboxBluetooth = sender as CheckBox;
            CheckBox CheckboxDonnéesMobiles = sender as CheckBox;

            if (CheckboxWiFi != null)
            {
                if (CheckboxWiFi.IsChecked == true &&
                    CheckboxBluetooth.IsChecked == true &&
                    CheckboxDonnéesMobiles.IsChecked == true)
                {
                    CheckboxAllComposant.IsChecked = true;
                }
                else if (CheckboxWiFi.IsChecked == false &&
                    CheckboxBluetooth.IsChecked == false &&
                    CheckboxDonnéesMobiles.IsChecked == false)
                {
                    CheckboxAllComposant.IsChecked = false;
                }
                else
                {
                    // Set third state (indeterminate) by setting IsChecked to null.
                    CheckboxAllComposant.IsChecked = null;
                }
            }
        }

        private void ListBoxSon_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void ListBoxMinutes_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void ListBoxComposant_Loaded(object sender, RoutedEventArgs e)
        {

        }

    }
}
