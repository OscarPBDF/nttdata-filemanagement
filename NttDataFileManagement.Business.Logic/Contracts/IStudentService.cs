using NttDataFileManagement.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NttDataFileManagement.Business.Logic.Contracts
{
    public interface IStudentService
    {
        bool Add(Student student);
    }
}
