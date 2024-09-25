using AsignmentWinUI.Contracts.Services;
using AsignmentWinUI.Core.Entities;
using AsignmentWinUI.Models;
using AsignmentWinUI.Services;
using AsignmentWinUI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Hosting;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace AsignmentWinUI.ViewModels
{
    public partial class ChatViewModel : ObservableRecipient
    {
        private readonly ISignalRService _signalRService;
        public ObservableCollection<string> OnlineUsers { get; set; } = new ObservableCollection<string>();
        
        [ObservableProperty]
        private Account _Acc = new Account();

        [ObservableProperty]
        private string _newMessage;
        public ChatViewModel(ISignalRService signalRService)
        {
            OnlineUsers.Add("User1");
            OnlineUsers.Add("User2");
            OnlineUsers.Add("User3");
        }
        [RelayCommand]
        private void CheckName()
        {
            Debug.WriteLine("Acc: " + Acc.UserName);
        }
        [RelayCommand]
        private void SendMessage()
        {
            if (!string.IsNullOrWhiteSpace(NewMessage))
            {
                Debug.WriteLine("Ms: " + NewMessage);
                NewMessage = string.Empty; 
            }
        }
        [RelayCommand]
        private async void CreateNewWindow()
        {
            MainWindow mainWindow = new MainWindow();
            Frame frame = new Frame();
            mainWindow.Content = frame;
            frame.Navigate(typeof(MainPage));
            mainWindow.Activate();
        }
    }
}
