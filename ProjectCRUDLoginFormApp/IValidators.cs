using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCRUDLoginFormApp
{
    public interface IValidators
    {
        bool CheckIfLoginExist();
        bool CheckIfEmailExist();
        bool EmailValidator();
        bool PasswordValidation();
        void AddNewRecord();
    }
}
