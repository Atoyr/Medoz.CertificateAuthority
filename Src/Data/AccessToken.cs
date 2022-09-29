
namespace Medoz.CertificateAuthority.Data;

public class AccessToken
{
    public string Value { get; set; }
    public string UserId { get; set; }
    public string ClientId { get; set; }
    public string Scopes { get; set; }
    public DateTime ExpiresAt { get; set; }
}
