using GroupApi.Aplacation.InterfaceServies;
using GroupApi.Doamin.Efenties_Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroupApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthFirebaseController : ControllerBase
    {
        private  IFirebaseAuthServies  _firebaseAuthServies {  get; set; } 
        public AuthFirebaseController (IFirebaseAuthServies firebaseAuthServies) 
        {
            _firebaseAuthServies = firebaseAuthServies;
        } 
        [HttpPost("auth-anonim")]
        public async Task<IActionResult> SignAnonimal()
        {
         var firebaseauth = await   _firebaseAuthServies.SignAnonimalAsync();
            if (firebaseauth == null)
                return BadRequest(new {error = "Ошибка в аутификации"});
            return Ok(firebaseauth);
        }
        [HttpPost("get-token")]
        public async Task<IActionResult> GetIdToken([FromBody] FirebaseAuthModel authin)
        {
            var firebaseauth = await _firebaseAuthServies.GetIdFirebaseToken(authin);
            if (firebaseauth == null)
                return BadRequest(new { error = "Ошибка в получении токена" });
            return Ok(new { FireBaseToken  = firebaseauth});
        }



    }
}
