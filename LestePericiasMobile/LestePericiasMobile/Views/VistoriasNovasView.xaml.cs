﻿using LestePericiasMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LestePericiasMobile.Views
{
    public partial class VistoriasNovasView : ContentPage
    {
        public VistoriasNovasView()
        {
            InitializeComponent();
            BindingContext = new VistoriasNovasViewModel();
        }
    }
}