using System;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.BirthYear == 1990 && 
                gamer.FirstName == "Yusuf" && gamer.LastName == "Türk" 
                && gamer.IdentityNumber == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
