
using GroupApi.Aplacation.InterfaceServies;
using GroupApi.Doamin.Efenties_Models;
using GroupApi.Doamin.Interfais;

namespace GroupApi.Aplacation.Servies
{
    public class FirebaseAuthSerivsecs : IFirebaseAuthServies
    {
        private IFirebaseAuth _firebaseAuth;
        private  IFirebaseTokenRepotisory _firebaseTokenRepotisory;
        public FirebaseAuthSerivsecs(IFirebaseAuth firebaseAuth, IFirebaseTokenRepotisory firebaseTokenRepotisory)
        {
            _firebaseAuth = firebaseAuth;
            _firebaseTokenRepotisory = firebaseTokenRepotisory;
        }

        public async Task<string> GetIdFirebaseToken(FirebaseAuthModel firebaseAuthModel )
        {
            var token =  await _firebaseTokenRepotisory.GetIdToken(firebaseAuthModel);
            return token;
        }

        public async Task<FirebaseAuthModel> SignAnonimalAsync()
        {
            try
            {
                FirebaseAuthModel firebaseAuth = await _firebaseAuth.SignAnonimalAsync();
                return firebaseAuth;
            }
            catch  
            {
                return null; 
            }
        }
    }
}
