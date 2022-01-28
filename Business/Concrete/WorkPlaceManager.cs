using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WorkPlaceManager : IWorkPlaceService
    {
        IWorkPlaceDal _workPlaceDal;
        public WorkPlaceManager(IWorkPlaceDal workPlaceDal)
        {
            _workPlaceDal = workPlaceDal;
        }
        public void Add(WorkPlace workPlace)
        {
            _workPlaceDal.Add(workPlace);
        }

        public void Delete(WorkPlace workPlace)
        {
            _workPlaceDal.Delete(workPlace);
        }

        public List<WorkPlace> GetAll()
        {
            return _workPlaceDal.GetAll();
        }

        public WorkPlace GetById(int id)
        {
            return _workPlaceDal.Get(w => w.Id == id);
        }

        public void Update(WorkPlace workPlace)
        {
            _workPlaceDal.Update(workPlace);
        }
    }
}
