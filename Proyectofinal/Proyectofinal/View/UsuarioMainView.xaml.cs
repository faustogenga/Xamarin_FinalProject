﻿using Proyectofinal.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyectofinal.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioMainView : ContentPage
    {
        
        public UsuarioMainView()
        {
            InitializeComponent();

            this.BindingContext = new UsuarioMainViewViewModel();
        }
    }
}