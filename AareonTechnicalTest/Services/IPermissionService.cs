using AareonTechnicalTest.Models;

namespace AareonTechnicalTest.Services
{
    public interface IPermissionService
    {
        bool DeleteNotesNotAllowed(Person person);
    }
}