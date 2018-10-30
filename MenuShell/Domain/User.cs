namespace MenuShell.Domain
{
    class User
    {
        public string UserName { get; }
        public string PassWord { get; }
        public string Role { get; }

        public User(string userName, string passWord, string role)
        {
            UserName = userName;
            PassWord = passWord;
            Role = role;
        }
    }
}
