﻿using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL {
    public interface IUnitOfWork {
        public IRepository<Games> GameRepository {
            get;
        }
        public IRepository<Publishers> PublisherRepository {
            get;
        }
        public IRepository<Users> UserRepository {
            get;
        }
        void Commit();
        void Rollback();
    }
}
