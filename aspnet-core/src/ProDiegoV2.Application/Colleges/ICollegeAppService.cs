using Abp.Application.Services;
using ProDiegoV2.Colleges.Dto;
using ProDiegoV2.Students.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDiegoV2.Colleges
{
    public interface ICollegeAppService : IAsyncCrudAppService<CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>
    {

    }
}
