using System.Threading.Tasks;
using XamarinFormsBaseProject.Interfaces.Services;

namespace XamarinFormsBaseProject.ViewModels.Base
{
    public abstract class ViewModelBase : ExtendedBindableObject
    {

        protected readonly INavigationService NavigationService;

        public ViewModelBase()
        {
            NavigationService = ViewModelLocator.Resolve<INavigationService>();
        }

        public virtual Task InitializeAsync()
        {
            return Task.FromResult(false);
        }
    }
}
