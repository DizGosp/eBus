﻿using eBus.Mobile.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBus.Mobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ocjena : ContentPage
    {
        private OcjenaViewModel model = null;
        public Ocjena(int id)
        {
            InitializeComponent();
            BindingContext = model = new OcjenaViewModel(id);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.ButtonInit();
        }
    }
}