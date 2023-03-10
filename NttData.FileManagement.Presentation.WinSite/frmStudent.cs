using NttDataFileManagement.Business.Logic.Contracts;
using NttDataFileManagement.Business.Logic.Implementations;
using NttDataFileManagement.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NttData.FileManagement.Presentation.WinSite
{
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IStudentService studentService = new StudentService();
            Student student = new Student();

            student.Id = int.Parse(txtId.Text);
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;

            student.Birthday = DateTime.Parse(txtBirthday.Text);

            studentService.Add(student);

            MessageBox.Show("The student is saved");
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            /*string sAttr = @ConfigurationManager.AppSettings.Get("StudentsFilePath");
            MessageBox.Show(sAttr);*/
        }
    }
}
