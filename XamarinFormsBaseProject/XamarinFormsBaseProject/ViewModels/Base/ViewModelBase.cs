using System.Threading.Tasks;

namespace XamarinFormsBaseProject.ViewModels.Base
{
    public abstract class ViewModelBase : ExtendedBindableObject
    {           
        public virtual Task InitializeAsync()
        {
            return Task.FromResult(false);
        }
    }
}
