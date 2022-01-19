using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace BackendApp;

public class AuthOptions
{
    public const string Issuer = "http://localhost:8080"; // издатель токена
    public const string Audience = "http://localhost"; // потребитель токена
    private const string Key = "b4a004617976c16a18333393e2c88e06"; // ключ для шифрации
    public const int Lifetime = 60; // время жизни токена - 1 минута

    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(Key));
    }
}