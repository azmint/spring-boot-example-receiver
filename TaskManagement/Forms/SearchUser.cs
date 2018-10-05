using System;
using System.Windows.Forms;
using TaskManagement.Support.Json;

namespace TaskManagement.Forms
{
    public partial class SearchUser : Form
    {
        public SearchUser()
        {
            InitializeComponent();
        }

        private void RerunButton_Click(object sender, EventArgs e)
        {
            this.AllUserGridView.Rows.Clear();
            var url = "http://localhost:8080/users";
            var json = Json.From(url);
            var users = json.AsList<User>();
            users.ForEach(user => this.AllUserGridView.Rows.Add(user.id, user.name));
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            this.FoundUserGridView.Rows.Clear();
            var userId = this.UserIdTextBox.Text;
            //var id = "ABCDEFGHIJK";
            var url = "http://localhost:8080/" + userId;
            var user = Json.From(url).As<User>();
            this.FoundUserGridView.Rows.Add(user.id, user.name);
        }
    }
}
