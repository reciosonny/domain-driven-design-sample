using SampleWebApp.Domain.Core;
using System.Collections.Generic;

namespace SampleWebApp.Domain.BusinessLogic {
    public interface IPermitsManager {
        void AddPermit(TblPermits p);
        void EditPermit(TblPermits p);
        TblPermits GetPermit(int id);
        IEnumerable<TblPermits> GetPermitLists();
    }
}