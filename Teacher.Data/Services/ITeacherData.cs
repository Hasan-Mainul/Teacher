using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teacher.Data.Models;

namespace Teacher.Data.Services
{
    public interface ITeacherData
    {
        IEnumerable<TeacherInfo> GetAll();
        TeacherInfo Get(int id);
        void Add(TeacherInfo teacherinfo);
        void Update(TeacherInfo teacherInfo);
    }
}
