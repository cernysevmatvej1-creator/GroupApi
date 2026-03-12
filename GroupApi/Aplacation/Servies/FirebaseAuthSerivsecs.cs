
using GroupApi.Aplacation.InterfaceServies;
using GroupApi.Doamin.Efenties_Models;
using GroupApi.Doamin.Interfais;

namespace GroupApi.Aplacation.Servies
{
    public class FirebaseAuthSerivsecs : IFirebaseAuthServies
    {
        private IFirebaseAuth _firebaseAuth;
        public FirebaseAuthSerivsecs(IFirebaseAuth firebaseAuth)
        {
            _firebaseAuth = firebaseAuth;
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
