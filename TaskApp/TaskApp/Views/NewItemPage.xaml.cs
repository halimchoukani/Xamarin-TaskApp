using System;
using System.Collections.Generic;
using System.ComponentModel;
using TaskApp.Models;
using TaskApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}