using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using ProDiegoV2.Authorization;
using ProDiegoV2.Students.Dto;
using ProDiegoV2.Models;
using MyCollegeV2.Students;

namespace ProDiegoV2.Students
{

    // [AbpAuthorize(PermissionNames.Pages_Students)]
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, UpdateStudentDto>, IStudentAppService
    {
        public StudentAppService
        (
            IRepository<Student, int> repository
        )
        : base(repository)
        {

        }

    }
}
