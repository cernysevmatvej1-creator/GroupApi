using GroupApi.Doamin.Efenties_Models;
using GroupApi.Doamin.Interfais;
using Firebase.Auth;
namespace GroupApi.Infrastructure.Repotisory
{
    public class FireBaseAuthRepotisorycs : IFirebaseAuth
    {
        private readonly IConfiguration _config;
        public FireBaseAuthRepotisorycs(IConfiguration config)
        {
            _config = config;
        }

        public async  Task<FirebaseAuthModel> SignAnonimalAsync()
        {
            try
            {
                string firebaseApiKey = _config["FirebaseApiKey"];
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(firebaseApiKey));
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
