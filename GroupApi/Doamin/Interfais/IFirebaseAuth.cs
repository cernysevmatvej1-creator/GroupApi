using GroupApi.Doamin.Efenties_Models;

namespace GroupApi.Doamin.Interfais
{
    public interface IFirebaseAuth
    {
        Task<FirebaseAuthModel> SignAnonimalAsync();
    }
}
