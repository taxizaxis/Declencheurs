using System;

using Declencheurs.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Declencheurs.Views
{
    public sealed partial class AccueilDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(AccueilDetailControl), new PropertyMetadata(null));

        public AccueilDetailControl()
        {
            InitializeComponent();
        }
    }
}
