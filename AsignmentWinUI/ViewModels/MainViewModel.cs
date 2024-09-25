using System.Diagnostics;
using AsignmentWinUI.Contracts.Services;
using AsignmentWinUI.Core.Entities;
using AsignmentWinUI.Core.UseCases.Services;
using AsignmentWinUI.Services;
using AsignmentWinUI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml.Controls;

namespace AsignmentWinUI.ViewModels;

public partial class MainViewModel : ObservableRecipient
{
    private readonly INavigationService _navigationService;
    private readonly ISignalRService _signalRService;
    public MainViewModel(
        ISignalRService signalRService,
        INavigationService navigationService
        )
    {
        Debug.WriteLine("INIT MainViewModel");
        _navigationService = navigationService;
        _signalRService = signalRService;
       _signalRService.ConnectAsync("http://localhost:5192/chathub");
    }

    [RelayCommand]
    public void JoinChatPage()
    {
        Debug.WriteLine("@");
            try
        {
            _navigationService.NavigateTo(typeof(ChatViewModel).FullName);

        }
        catch (Exception ex)
        {
            Debug.WriteLine($"esssx: {ex.Message}");
            throw;
        }
    }
}
