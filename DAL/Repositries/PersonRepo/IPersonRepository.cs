﻿using DAL.Models;
using DAL.Repositries.MainRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositries.PersonRepo
{
    public interface IPersonRepository : IRepository<Person>
    {
    }
}
