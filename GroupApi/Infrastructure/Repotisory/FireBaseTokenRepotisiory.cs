using Firebase.Auth;

using GroupApi.Doamin.Efenties_Models;
using GroupApi.Doamin.Interfais;

namespace GroupApi.Infrastructure.Repotisory
{
    public class FireBaseTokenRepotisiory : IFirebaseTokenRepotisory
    {

      private   FirebaseAuthLink _authLink;
        private readonly IConfiguration _config;
        public FireBaseTokenRepotisiory(IConfiguration config)
        {
            _config = config;
        }

        public async  Task<string> GetIdToken(FirebaseAuthModel firebaseAuth)
        {


            var auth = new FirebaseAuth
            {
                RefreshToken = firebaseAuth.FireBaseRefreshToken,
                FirebaseToken = firebaseAuth.FireBaseToken,
                User = new User { LocalId = firebaseAuth.UserId }
            };

            if (firebaseAuth.FireBaseRefreshToken != null && firebaseAuth.UserId != null)
            {




                string firebaseApiKey = _config["FirebaseApiKey"];
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(firebaseApiKey));
                _authLink = await authProvider.RefreshAuthAsync(auth);
                return  _authLink.FirebaseToken;
            }
            return "Данные пусты";
        }
    }
}

