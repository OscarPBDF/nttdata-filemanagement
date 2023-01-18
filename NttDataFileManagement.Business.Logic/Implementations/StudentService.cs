using NttDataFileManagement.Business.Logic.Contracts;
using NttDataFileManagement.Common.Model;
using NttDataFileManagement.DataAccess.Repository.Contracts;
using NttDataFileManagement.DataAccess.Repository.Implementations;
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
            student.Age = CalculateAge(student.Birthday);
            IStudentRepository studentRepository = new StudentRepository();
            studentRepository.Add(student);
            return true;

        }
        private int CalculateAge(DateTime birthday)
        {
            DateTime now = DateTime.Today;
            int age = DateTime.Today.Year - birthday.Year;

            if (DateTime.Today < birthday.AddYears(age))
                return --age;

            return age;
        }

    }
}
