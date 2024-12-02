using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace TaskApp
{
    public partial class MainPage : ContentPage

    {

        public ObservableCollection<Tache> Tasks { get; set; }


        public MainPage()

        {

            InitializeComponent();

            Tasks = new ObservableCollection<Tache>();

            taskListView.ItemsSource = Tasks;

        }


        private async void OnAddTaskClicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new AddTaskPage(Tasks));

        }


        private async void OnTaskSelected(object sender, SelectedItemChangedEventArgs e)

        {

            var selectedTask = e.SelectedItem as Tache;

            if (selectedTask != null)

            {

                await Navigation.PushAsync(new TaskDetailPage(selectedTask));

            }

        }

    }

}

public class Tache

{

    public string Title { get; set; }

}


