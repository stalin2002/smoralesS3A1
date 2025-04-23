using CommunityToolkit.Mvvm.Input;
using smoralesS3A1.Models;

namespace smoralesS3A1.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}