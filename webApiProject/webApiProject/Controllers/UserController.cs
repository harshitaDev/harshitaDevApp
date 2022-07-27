using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiProject.Model;
using Microsoft.EntityFrameworkCore;

namespace webApiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {                        
        public void MapTodoItemsEndpoints<T>(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/api/TodoItems", async (TodoContext db) =>
            {
                return await db.TodoItems.ToListAsync();
            })
            .WithName("GetAllTodoItemss");
        }
    }
    

