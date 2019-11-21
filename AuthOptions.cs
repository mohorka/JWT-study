using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace JWT_study
{
    public class AuthOptions
    {
        public const string ISSUER = "MyServer";
        public const string AUDIENCE = "http://localhost:54244";
        const string KEY = "secretkey_dunno_why123";
        public const int LIFETIME = 1;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}