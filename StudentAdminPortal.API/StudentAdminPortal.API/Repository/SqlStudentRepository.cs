using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repository
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext db;

        public SqlStudentRepository(StudentAdminContext db)
        {
            this.db = db;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await db.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
