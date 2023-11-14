using EntityFrameworkCore1.DAL;
using EntityFrameworkCore1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Group = EntityFrameworkCore1.Models.Group;

namespace EntityFrameworkCore1.Services
{
    internal class GroupService
    {
        AppDbContext context = new AppDbContext();

        private List<Group> groups = new List<Group>();

        public void Add(Group group)
        {
            if (group != null)
            {
                context.Groups.Add(group);
                context.SaveChanges();
            }
        }

        public void Delete(int groupId)
        {
            var groupRemove = context.Groups.Find(groupId);
            if (groupRemove != null)
            {
                groups.Remove(groupRemove);
                context.SaveChanges();
            }
        }

        public void Update(Group updateGroup)
        {
            var oldGroup = context.Groups.Find(updateGroup.Id);
            if (oldGroup != null)
            {
                oldGroup.Name = updateGroup.Name;
                context.SaveChanges();
            }
        }

        public List<Group> GetAll()
        {
            return groups;
        }
    }
}
