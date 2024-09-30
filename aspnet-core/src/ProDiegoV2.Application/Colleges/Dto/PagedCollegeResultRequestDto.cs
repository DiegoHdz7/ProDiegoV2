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
    [AutoMapTo(typeof(College))]
    public class PagedCollegeResultRequestDto: PagedResultRequestDto
    { public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
