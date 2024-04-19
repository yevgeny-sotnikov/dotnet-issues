using Core;

namespace MauiApp;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        _label.Text = FileHelper.GetDir();
    }

}