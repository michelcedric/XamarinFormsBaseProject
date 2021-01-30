using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsBaseProject.Interfaces.Services;
using XamarinFormsBaseProject.ViewModels.Base;

namespace XamarinFormsBaseProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitNavigation();
        }

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
