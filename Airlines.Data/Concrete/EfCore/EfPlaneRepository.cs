using Airlines.Data.Abstract;
using Airlines.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airlines.Data.Concrete.EfCore
{
    public class EfPlaneRepository : IPlaneRepository
    {
        private AirlinesContext context;

        public EfPlaneRepository(AirlinesContext _context)
        {
            context = _context;
        }

        public void AddPlane(Plane entity)
        {
            context.Planes.Add(entity);
            context.SaveChanges();
        }

        public void DeletePlane(int PlaneId)
        {
            var plane = context.Planes.FirstOrDefault(p => p.PlaneId == PlaneId);
            if (plane != null)
            {
                context.Planes.Remove(plane);
                context.SaveChanges();
            }
        }

        public IQueryable<Plane> GetAll()
        {
            return context.Planes;
        }

        public Plane GetById(int PlaneId)
        {
            return context.Planes.FirstOrDefault(p => p.PlaneId == PlaneId);
        }

        public void UpdatePlane(Plane entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
