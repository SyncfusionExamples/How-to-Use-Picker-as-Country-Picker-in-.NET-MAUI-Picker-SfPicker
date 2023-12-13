using Syncfusion.Maui.Picker;
using System.Collections.ObjectModel;

namespace CountryPicker
{
    public class PickerBehavior : Behavior<ContentPage>
    {
        private SfPicker picker;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            this.picker = bindable.FindByName<SfPicker>("picker");
            
            ObservableCollection<object> countryName = new ObservableCollection<object>();
            countryName.Add("UnitedStates");
            countryName.Add("Qatar");
            countryName.Add("India");
            countryName.Add("Germany");
            countryName.Add("Spain");
            countryName.Add("Malaysia");
            countryName.Add("Netherlands");
            countryName.Add("Mexico");
            countryName.Add("Brazil");
            PickerColumn pickerColumn = new PickerColumn()
            {
                ItemsSource = countryName,
                SelectedIndex = 3,
            };

            this.picker.Columns.Add(pickerColumn);
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            if (this.picker != null)
            {
                this.picker = null;
            }
        }
    }

}