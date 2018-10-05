using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TaskManagement.Support.Json;

namespace TaskManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var userId = this.textBox1.Text;
            //var id = "ABCDEFGHIJK";
            //var data = GetUser(id);
            var users = GetUsers();
            users.ForEach(user => this.dataGridView1.Rows.Add(user.id, user.name));
        }

        User GetUser(string id)
        {
            var url = "http://localhost:8080/" + id;
            return Json.From(url).As<User>();
        }

        List<User> GetUsers()
        {
            var url = "http://localhost:8080/users";
            Json json = Json.From(url);
            return json.AsList<User>();
        }
    }
}
