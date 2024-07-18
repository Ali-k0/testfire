using Microsoft.EntityFrameworkCore;
using testfire.Server.Models;

namespace BlazorApp.Server.Models
{
    public class Item
    {
        public int Id { get; set; }  // This is the primary key
        public string Name { get; set; }
    }
}
