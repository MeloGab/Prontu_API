namespace Prontu_API.Services.Interfaces
{
    public interface IPassHashService
    {
        void CreatePassHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
    }
}
