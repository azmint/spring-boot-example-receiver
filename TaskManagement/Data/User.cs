namespace TaskManagement
{
    class User
    {
        public string id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return "User[" + id + "," + name + "]";
        }
    }
}
