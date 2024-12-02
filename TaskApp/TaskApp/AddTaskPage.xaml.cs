using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddTaskPage : ContentPage
    {
        private ObservableCollection<Tache> _tasks;


        public AddTaskPage(ObservableCollection<Tache> tasks)

        {

            InitializeComponent();

            _tasks = tasks;

        }


        private async void OnAddTaskClicked(object sender, EventArgs e)

        {

            var taskTitle = taskEntry.Text;

            if (!string.IsNullOrEmpty(taskTitle))

            {

                _tasks.Add(new Tache { Title = taskTitle });

                await Navigation.PopAsync();//Retourner à la MainPage

            }

        }
    }
}