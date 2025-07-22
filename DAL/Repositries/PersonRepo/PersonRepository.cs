using DAL.AppContext;
using DAL.Models;
using DAL.Repositries.MainRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositries.PersonRepo
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(HotelDbContext context) : base(context)
        {
        }
        
    }
}
