using vanadium.Models;
using FluentValidation;

namespace vanadium.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() 
        {
            RuleFor(user => user.Email).NotEmpty();
            RuleFor(user => user.Password).NotEmpty();
        }
    }
}
