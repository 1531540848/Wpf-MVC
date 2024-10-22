using Microsoft.EntityFrameworkCore;
using WPFDAL;
using WPFMODEL;

namespace WPFBLL
{
    public class TeacherManager
    {
        public static ManagerContext managerContext = new ManagerContext();

        public static List<Managers> GetManager()
        {
            return managerContext.Managers.ToList();
        }
    }
}
