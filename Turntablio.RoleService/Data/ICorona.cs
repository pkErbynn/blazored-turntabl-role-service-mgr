using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turntablio.RoleService.Data
{
    public interface ICorona
    {
        public ICollection<Covid> GetAllCovidCases();
        public ICollection<Hero> GetAllFrontlineAvengers();
        public void UpdateSuperHeros();

        public void RemoveAllQuarantineById(int id);
        public void AddMoreSantilizers(Santilizer santilizer);
        public void RemoveAllLockdowns();
        public void DeleteAllCorona();
    }
}
