using GroupApi.Doamin.Efenties_Models;
using GroupApi.Doamin.Interfais;
using Firebase.Auth;
namespace GroupApi.Infrastructure.Repotisory
{
    public class FireBaseAuthRepotisorycs : IFirebaseAuth
    {
        public async  Task<FirebaseAuthModel> SignAnonimalAsync()
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyCizHvDCDeFTpZ9ICNEgWTFjt5eBpqCLXg"));
                var auth = await authProvider.SignInAnonymouslyAsync();
                return  new FirebaseAuthModel { UserId = auth.User.LocalId, FireBaseRefreshToken = auth.RefreshToken, FireBaseToken = auth.FirebaseToken };
            }
            catch
            {
                return null; 
            }
        }
    }
}
