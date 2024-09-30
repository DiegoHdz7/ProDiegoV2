using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ProDiegoV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDiegoV2.Colleges.Dto
{
    [AutoMapFrom(typeof(College))]
    public class CollegeDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string GPS { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Email { get; set; }
        public string DiegoString { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
