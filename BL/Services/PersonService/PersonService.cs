using BL.Services.MainServices;
using DAL.Models;
using DAL.Repositries.MainRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.PersonService
{
    internal class PersonService : Service<Person>
    {
        public PersonService(IRepository<Person> repository) : base(repository)
        {
        }
        
    }
}
