﻿using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces.Repositories
{
    public interface IRepositoryAlbum<T> :IRepository<T> where T : Entity
    {
    }
}
