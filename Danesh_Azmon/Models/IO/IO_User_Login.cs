namespace Danesh_Azmon.Models.IO
{
    public class IO_User_Login
    {

        public required string NationalCode { get; set; }
        public required string Password { get; set; }
        public bool RemmeberMe { get; set; }

    }
}
