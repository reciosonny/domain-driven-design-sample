using SampleWebApp.Domain.Core;
using SampleWebApp.Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Domain.BusinessLogic {
    public class PermitsManager : IPermitsManager {

        private readonly IUnitOfWork uow;
        private readonly IGenericRepository<TblPermits> permitRepository;
        public PermitsManager(IGenericRepository<TblPermits> permitRepository, IUnitOfWork uow) {
            this.uow = uow;
            this.permitRepository = permitRepository;
        }


        public void AddPermit(TblPermits p) {
            permitRepository.Add(p);
            uow.Complete();
        }

        public void EditPermit(TblPermits p) {
            permitRepository.Update(p);
        }

        public TblPermits GetPermit(int id) {
            return permitRepository.FindItem(id);
        }

        public IEnumerable<TblPermits> GetPermitLists() {
            return permitRepository.GetAllItems();
        }

    }
}