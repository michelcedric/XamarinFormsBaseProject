using System.Threading.Tasks;
using XamarinFormsBaseProject.ViewModels.Base;

namespace XamarinFormsBaseProject.Interfaces.Services
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase;
    }
}
