using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWorkPlaceService
    {
        List<WorkPlace> GetAll();
        WorkPlace GetById(int id);
        void Add(WorkPlace workPlace);
        void Update(WorkPlace workPlace);
        void Delete(WorkPlace workPlace);
             
    }
}
