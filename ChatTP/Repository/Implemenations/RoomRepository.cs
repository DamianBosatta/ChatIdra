using ChatTP.DataBase;
using ChatTP.Models;
using ChatTP.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ChatTP.Repository.Implemenations
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext db) : base(db)
        {
        }

   
    }
}
