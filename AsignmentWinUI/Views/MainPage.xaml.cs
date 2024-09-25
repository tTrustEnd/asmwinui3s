using System.Diagnostics;
using AsignmentWinUI.Core.UseCases.LoginUseCase;
using AsignmentWinUI.ViewModels;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml.Controls;

namespace AsignmentWinUI.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel;
    private readonly ILoginUseCase loginUseCase = App.GetRequiredService<ILoginUseCase>();
    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private async void JoinChat(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        var User =await loginUseCase.ExecuteAsync(UserNameTexBox.Text);
        if (User != null)
        {
             Debug.WriteLine("User: " + User.UserName);
            Frame.Navigate(typeof(ChatPage), User.UserName);
        }
    }
}
