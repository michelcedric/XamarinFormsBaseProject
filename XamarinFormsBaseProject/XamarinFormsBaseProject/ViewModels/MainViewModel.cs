using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
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

        public ICommand NavigateCommand => new Command(async () => await OpenSecondView());

        private async Task OpenSecondView()
        {
            await NavigationService.NavigateToAsync<SecondViewModel>();
        }
    }
}
