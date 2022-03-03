﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal;
        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }
        public void Add(Role role)
        {
            _roleDal.Add(role);
        }

        public void Delete(Role role)
        {
            _roleDal.Delete(role);
        }

        public List<Role> GetAll()
        {
            return _roleDal.GetAll();
        }

        public Role GetById(int id)
        {
            return _roleDal.Get(x=>x.RoleId == id);
        }

        public void Update(Role role)
        {
            _roleDal.Update(role);
        }
    }
}
