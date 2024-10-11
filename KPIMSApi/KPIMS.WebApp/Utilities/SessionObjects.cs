using KPIMS.Core.Models;

namespace KPIMS.WebApp.Utilities
{
    public class SessionObjects
    {
        private static DbEmployee? _employeeInSession;
        public static DbEmployee EmployeeInSession
        {
            set
            {
                _employeeInSession = value;
            }
            get
            {
                try
                {
                    if (_employeeInSession != null)
                        return _employeeInSession;
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
