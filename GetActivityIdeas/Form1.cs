using System;
using System.Windows.Forms;

namespace GetActivityIdeas
{
    public partial class Form1 : Form
    {
        private List<Activity> activities = new List<Activity>();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Bored? Get ideas and have fun!";
        }

        private async void addNewActivityBtn_Click(object sender, EventArgs e)
        {
            Activity toInsert = await FetchActivities.Fetch();
            activitiesListBox.Items.Add(toInsert.name);
            activities.Add(toInsert);
        }
    }
}