namespace ECommerce.Dtos.UserDto
{
    public class SignInRequest
    {
        public SignInRequest() { }
        public SignInRequest(string userphone, string password)
        {
            UserPhone = userphone;
            Password = password;
        }
        public string UserPhone { get; set; }
        public string Password { get; set; }
    }
}
