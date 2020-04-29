using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher.Data.Models;

namespace Teacher.Data.Services
{
    public class InformationDbContext : DbContext
    {
        public DbSet<TeacherInfo> teacherInfos { get; set; }
    }
}
