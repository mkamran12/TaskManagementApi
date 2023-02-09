using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Interfaces
{
    public interface ITask
    {
       Task<Response> CreateTask(TaskModel model);
    }
}
