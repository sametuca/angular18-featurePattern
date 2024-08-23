using AngularJWT.Domain.Entities;

namespace AngularJWT.Application.Interfaces
{
    public interface ITokenService
    {
        /// <summary>
        /// Kullanıcı bilgilerine dayanarak bir JWT token oluşturur.
        /// </summary>
        /// <param name="user">Token oluşturmak için gereken kullanıcı bilgileri.</param>
        /// <returns>Oluşturulan JWT token'ı içeren string.</returns>
        string CreateToken(User user);

        /// <summary>
        /// JWT token'ı doğrular ve geçerli olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="token">Doğrulanacak JWT token.</param>
        /// <returns>Token geçerli ise true, değilse false döner.</returns>
        bool ValidateToken(string token);

        /// <summary>
        /// JWT token içindeki bilgileri çözer ve kullanıcı bilgilerini döner.
        /// </summary>
        /// <param name="token">Çözülecek JWT token.</param>
        /// <returns>Token'dan çözülen kullanıcı bilgileri.</returns>
        User DecodeToken(string token);

        /// <summary>
        /// Mevcut bir token'ı yeniler ve yeni bir token döner.
        /// </summary>
        /// <param name="token">Yenilenecek mevcut JWT token.</param>
        /// <returns>Yenilenmiş JWT token.</returns>
        string RefreshToken(string token);
    }

}
