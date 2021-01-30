using XamarinFormsBaseProject.Interfaces.Services;
using XamarinFormsBaseProject.ViewModels.Base;

namespace XamarinFormsBaseProject.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _name;

        public MainViewModel(IDataService dataService)
        {
            Name = dataService.GetUserName();
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
