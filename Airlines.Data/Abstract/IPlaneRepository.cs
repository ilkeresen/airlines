using Airlines.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airlines.Data.Abstract
{
    public interface IPlaneRepository
    {
        IQueryable<Plane> GetAll();
        Plane GetById(int PlaneId);
        void AddPlane(Plane entity);
        void UpdatePlane(Plane entity);
        void DeletePlane(int PlaneId);
    }
}
