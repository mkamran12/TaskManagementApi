using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskManagement.Data;
using TaskManagement.Interfaces;
using TaskManagement.Models;

namespace TaskManagement.Repository
{
    public class TaskService : ITask
    {
        public readonly ApplicationDbContext _context;
        public TaskService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Response> CreateTask(TaskModel model)
        {

           var result=await  _context.AddAsync(model);
            if (result!=null)
            {
                _context.SaveChanges();
                return new Response()
                {
                    Message="Task Created Successfully",
                    status=true
                };
            }
            return new Response()
            {
                Message = "unable to create user",
                status=false
            };
           
           
        }
    }
}
