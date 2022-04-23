using AareonTechnicalTest.Models;

namespace AareonTechnicalTest.Services
{
    public class PermissionService : IPermissionService
    {
        public bool DeleteNotesNotAllowed(Person person)
        {
            if (person.IsAdmin)
                return false;
            else
                return true;
        }
    }
}
