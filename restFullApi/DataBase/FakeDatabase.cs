namespace restFullApi.DataBase
{
    public class FakeDatabase
    {

        public static int GlobalId = 0;
        public List<User> Users { get; set; };
        public FakeDatabase()
        {
            Users = new List<User>();

           AddUserIntenal(new User
           {
              UserName = "UserName1",
              Password = "password1",
              Name = "name1",
              Surname = "Surname1",


           } );
           AddUserIntenal(new User
            {
                UserName = "UserName2",
                Password = "password2",
                Name = "name2",
                Surname = "Surname2",


            });
            AddUserIntenal(new User
            {
                UserName = "UserName3",
                Password = "password3",
                Name = "name3",
                Surname = "Surname3",


            });
            AddUserIntenal(new User
            {
                UserName = "UserName5",
                Password = "password5",
                Name = "name5",
                Surname = "Surname5",


            });
            AddUserIntenal(new User
            {
                UserName = "UserName6",
                Password = "password6",
                Name = "name6",
                Surname = "Surname6",


            });
        }

        public void AddUser(User user)
        {
           AddUserIntenal(user);
        }

        public void AddUserIntenal(User user) 
        {

            GlobalId++;
            user.IdUser = GlobalId;
            Users.Add(user);
        }
    }

    public class User
    {
        public int IdUser { get; set; }
        public string? UserName { get; set; }

        public string Password { get; set;}

        public string Name { get; set;}

        public string Surname { get; set;}  
    }
}
