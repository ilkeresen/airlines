using Airlines.Data.Abstract;
using Airlines.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airlines.Data.Concrete.EfCore
{
    public class EfUserRepository : IUserRepository
    {
        private AirlinesContext context;

        public EfUserRepository(AirlinesContext _context)
        {
            context = _context;
        }

        public void AddUser(User entity)
        {
            context.Users.Add(entity);
            context.SaveChanges();
        }

        public void DeleteUser(int UserId)
        {
            var user = context.Users.FirstOrDefault(p => p.UserId == UserId);
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public IQueryable<User> GetAll()
        {
            return context.Users;
        }

        public User GetById(int UserId)
        {
            return context.Users.FirstOrDefault(p => p.UserId == UserId);
        }
        public User GetByLogin(string UserEmail, string UserPassword)
        {
            return context.Users.Where(p => p.UserEmail == UserEmail && p.UserPassword == UserPassword).FirstOrDefault();
        }
        public User GetByEmail(string UserEmail)
        {
            return context.Users.FirstOrDefault(p => p.UserEmail == UserEmail);
        }
        public User GetByPassword(string UserPassword)
        {
            return context.Users.FirstOrDefault(p => p.UserPassword == UserPassword);
        }

        public void UpdateUser(User entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
