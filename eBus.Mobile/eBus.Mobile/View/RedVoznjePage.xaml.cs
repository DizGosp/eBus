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
    public partial class RedVoznjePage : ContentPage
    {

        private RedVoznjeModel model = null;

        public RedVoznjePage()
        {
            InitializeComponent();
            BindingContext = model = new RedVoznjeModel();

        }

        protected async override void OnAppearing() 
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}