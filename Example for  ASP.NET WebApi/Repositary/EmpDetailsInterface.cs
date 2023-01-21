using SampleWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebAPI.Repositary
{
    public interface EmpDetailsInterface
    {
        List<EmpModel> GetAllEmpDetails();
        EmpModel GetEmpDetails(int id);
        string UpdateEmpDetails(EmpModel empm);
        string DeleteStudent(string username);

        string InsertStdentDetails(EmpModel empm);
    }
    class EmpDetailsClass : EmpDetailsInterface
    {
        Student_DataBaseEntities sb = new Student_DataBaseEntities();

        string EmpDetailsInterface.DeleteStudent(string username)
        {
            throw new NotImplementedException();
        }



        //List<EmpModel> EmpList = new List<EmpModel>()
        //{
        //    new EmpModel()
        //    {
        //        EmpModelId = 1,
        //        EmpModelName = "Pavan",
        //        Address = "Hyderabad",
        //        Department = "IT"
        //    },

        //    new EmpModel()
        //    {
        //        EmpModelId = 2,
        //        EmpModelName = "Sree",
        //        Address = "Hyderabad",
        //        Department = "IT"
        //    },
        //    new EmpModel()
        //    {
        //        EmpModelId = 3,
        //        EmpModelName = "Swathi",
        //        Address = "Bengaluru",
        //        Department = "EG"
        //    },
        //    new EmpModel()
        //    {
        //        EmpModelId = 4,
        //        EmpModelName = "Sandhya",
        //        Address = "Chennai",
        //        Department = "AC"
        //    },
        //    new EmpModel()
        //    {
        //        EmpModelId = 5,
        //        EmpModelName = "Vamshi",
        //        Address = "Hyderabad",
        //        Department = "HR"
        //    }
        //};
        List<EmpModel> EmpDetailsInterface.GetAllEmpDetails()
        {
            List<EmpModel> EmpList = null;
            EmpList = sb.Student_Details_Registration.Select(s => new EmpModel()
            {
                username = s.username,
                password = s.password,
                First_Name = s.First_Name


            }).ToList<EmpModel>();
            return EmpList;
        }

        EmpModel EmpDetailsInterface.GetEmpDetails(int id)
        {
            throw new NotImplementedException();
        }

        string EmpDetailsInterface.InsertStdentDetails(EmpModel empm)
        {
            throw new NotImplementedException();
        }

        string EmpDetailsInterface.UpdateEmpDetails(EmpModel empm)
        {
            var existingStudent = sb.Student_Details_Registration.Where(s => s.username == empm.username).FirstOrDefault();
            if (existingStudent != null)
            { 
                existingStudent.Degree = empm.Degree;

                sb.SaveChanges();
                sb.Dispose();
                return "Updated";
            }

            return " ";
        }

        //EmpModel EmpDetailsInterface.GetEmpDetails(int id)
        //{
        //    var EmpModel = EmpList.FirstOrDefault(x => x.EmpModelId == id);
        //  if (EmpModel == null)
        //{
        //  throw new Exception(" Data Not Found");
        // }
        // return EmpModel;
        //}

        //EmpModel EmpDetailsInterface.UpdateEmpDetails(EmpModel empm)
        //{
        // }
    }
}
