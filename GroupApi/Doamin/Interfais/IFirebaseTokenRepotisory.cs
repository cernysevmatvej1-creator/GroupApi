using GroupApi.Common;
using GroupApi.Doamin.Efenties_Models;
namespace GroupApi.Doamin.Interfais
{
    public interface IFirebaseTokenRepotisory
    {
        Task<string> GetIdToken(FirebaseAuthModel firebaseAuth);
    }
}
