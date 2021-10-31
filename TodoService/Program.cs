using System;
using System.Threading.Tasks;

namespace TestAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            TodoService todoService = new TodoService();
            await todoService.Save(new Todo
            {
                title = "Hello",
                body = "Hello part 2",
                useId = 1,
                id = 1
            });
        }
    }
}
