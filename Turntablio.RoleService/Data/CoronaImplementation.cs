using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turntablio.RoleService.Data
{
    public class CoronaImplementation : ICorona
    {
        void ICorona.DeleteAllCorona()
        {
            throw new NotImplementedException();
        }

        ICollection<Hero> ICorona.GetAllFrontlineAvengers()
        {
            // Heros.ForEach( hero => hero.SaveTheWorld() )
            throw new NotImplementedException();
        }

        void ICorona.AddMoreSantilizers(Santilizer santilizer)
        {
            throw new NotImplementedException();
        }

        ICollection<Covid> ICorona.GetAllCovidCases()
        {
            throw new NotImplementedException();
        }

        void ICorona.RemoveAllLockdowns()
        {
            throw new NotImplementedException();
        }

        void ICorona.RemoveAllQuarantineById(int id)
        {
            throw new NotImplementedException();
        }

        void ICorona.UpdateSuperHeros()
        {
            throw new NotImplementedException();
        }
    }
}
