namespace restFullApi.Model.Request
{
    public class AddUserRequest
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
    }
}
