using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher.Data.Models;

namespace Teacher.Data.Services
{
    public class SqlTeacherData : ITeacherData
    {
        private readonly InformationDbContext db;
        public SqlTeacherData(InformationDbContext db)
        {
            this.db = db;
        }
        public void Add(TeacherInfo teacherinfo)
        {
            db.teacherInfos.Add(teacherinfo);
            db.SaveChanges();
        }

        public TeacherInfo Get(int id)
        {
            return db.teacherInfos.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<TeacherInfo> GetAll()
        {
            return from r in db.teacherInfos
                   orderby r.Name
                   select r;
            //return db.teacherInfos;
        }

        public void Update(TeacherInfo teacherInfo)
        {
            var entry = db.Entry(teacherInfo);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
