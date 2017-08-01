using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SampleWebApp.Domain.Persistence {
    public class UnitOfWork : IUnitOfWork {

        private readonly DbContext _db;
        public UnitOfWork(DbContext db) {
            _db = db;
        }

        public async void CompleteAsync() {
            await _db.SaveChangesAsync();
        }

        public void Complete() {
            _db.SaveChanges();
        }



    }
}