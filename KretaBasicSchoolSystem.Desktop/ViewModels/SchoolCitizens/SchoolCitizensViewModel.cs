using CommunityToolkit.Mvvm.ComponentModel;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        [ObservableProperty] BaseViewModel childViewModel;
    }
}
