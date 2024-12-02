using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskDetailPage : ContentPage
    {

        public TaskDetailPage(Tache selectedTask)

        {

            InitializeComponent();

            taskTitleLabel.Text = selectedTask.Title;

        }
    }
}