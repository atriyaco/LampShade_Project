namespace _0_Framework.Application
{
    public class AuthViewModel
    {
        public long Id { get; set; }
        public long RoleId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }

        public AuthViewModel(long id, long roleId, string fullname, string username)
        {
            Id = id;
            RoleId = roleId;
            Fullname = fullname;
            Username = username;
        }
    }
}