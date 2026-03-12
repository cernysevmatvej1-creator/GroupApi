using GroupApi.Doamin.Efenties_Models;

namespace GroupApi.Aplacation.InterfaceServies
{
    public interface IFirebaseAuthServies
    {
        Task<FirebaseAuthModel> SignAnonimalAsync();
    }
}
