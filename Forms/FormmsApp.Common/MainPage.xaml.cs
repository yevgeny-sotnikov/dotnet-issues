using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Xamarin.Forms;

namespace MAUI_Issues
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            _label.Text  = FileHelper.GetDir();
        }
    }
}