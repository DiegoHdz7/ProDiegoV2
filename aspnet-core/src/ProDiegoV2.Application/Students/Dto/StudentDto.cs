using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ProDiegoV2.Models;

namespace ProDiegoV2.Students.Dto
{
    [AutoMapFrom(typeof(Student))]
    public class StudentDto : EntityDto<int>
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ProgramName { get; set; }
        public string DoB { get; set; }
        public bool IsActive { get; set; }
        public int CollegeId { get; set; }
        ///Dto.cs.fields1///

        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

        public College College { get; set; }



    }
}

