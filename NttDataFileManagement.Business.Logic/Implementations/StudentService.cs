using NttDataFileManagement.Business.Logic.Contracts;
using NttDataFileManagement.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttDataFileManagement.Business.Logic.Implementations
{
    public class StudentService : IStudentService
    {

        public bool Add(Student student)
        {
            throw new NotImplementedException();

        }

        private int CalculateAge(DateTime birthday)
        {
            int age = 0;

            return age;
        }
    }
}
