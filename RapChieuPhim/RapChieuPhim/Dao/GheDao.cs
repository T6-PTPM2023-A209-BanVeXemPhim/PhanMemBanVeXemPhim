﻿using RapChieuPhim.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RapChieuPhim.Dao
{
    public class GheDao
    {
        private Data db = new Data();
        public Ghe GetGheFindByID(int id)
        {
            return db.Ghes.Find(id);
        }
        public Ghe UpdateGhe(Ghe ghe)
        {
         db.Entry(ghe).State = EntityState.Modified;
            db.SaveChanges();

            return ghe;
        }
    }
}