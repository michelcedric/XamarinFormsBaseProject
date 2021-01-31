using XamarinFormsBaseProject.Interfaces.Services;
using XamarinFormsBaseProject.ViewModels.Base;

namespace XamarinFormsBaseProject.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {
        private string _name;

        public SecondViewModel(IDataService dataService)
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
