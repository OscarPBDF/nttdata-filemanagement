using NttDataFileManagement.Common.Model;
using NttDataFileManagement.DataAccess.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttDataFileManagement.DataAccess.Repository.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        public bool Add(Student student)
        {
            string path = @ConfigurationManager.AppSettings.Get("StudentsFilePath");

            fileWrite(student, path);
            return true;
        }

        public void fileWrite(Student student, string path)
        {
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(student.Id + ","
                           + student.Name + ","
                           + student.Surname + ","
                           + student.Birthday.ToString("dd/MM/yy") + ","
                           + student.Age);
                    //sw.Dispose();
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(student.Id + ","
                                + student.Name + ","
                                + student.Surname + ","
                                + student.Birthday.ToString("dd/MM/yy") + ","
                                + student.Age);
                }
            }
        }
    }
}
