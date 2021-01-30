using XamarinFormsBaseProject.ViewModels.Base;

namespace XamarinFormsBaseProject.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _name;

        public MainViewModel()
        {
            Name = "Cédric Michel";
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }
    }
}
